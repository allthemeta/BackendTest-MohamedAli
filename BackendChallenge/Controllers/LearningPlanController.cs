using BackendChallenge.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackendChallenge.Controllers;

[ApiController]
[Route("learning-plan")]
/// <summary>
/// The LearningPlanController handles API requests related to a user's learning plan.
/// </summary>
public class LearningPlanController : ControllerBase
{
    private readonly AppDbContext _db;

    /// <summary>
    /// Represents a response from a learning plan request, which includes the user ID and plan items.
    /// </summary>
    public class LearningPlanResponse
    {
        public int UserId { get; set; }
        public List<PlanItemResponse> PlanItems { get; set; }
    }

    /// <summary>
    /// Represents a single item in a learning plan.
    /// </summary>
    public class PlanItemResponse
    {
        public int LearningPlanItemId { get; set; }
        public string LearningItemType { get; set; }
        public string LearningItemName { get; set; }
        public int ItemId { get; set; }
    }

    public LearningPlanController(AppDbContext db)
    {
        _db = db;
    }

    /// <summary>
    /// GetLearningPlan retrieves the learning plan for a user identified by a user token passed in the request header.
    /// </summary>
    /// <param name="UserToken">The token of the authenticated user. It should be passed in the header of the request.</param>
    /// <returns>A learning plan associated with the user or an error message if any issues occur.</returns>
    [HttpGet]
    public async Task<ActionResult<LearningPlanResponse>> GetLearningPlan([FromHeader] string UserToken)
    {
        try
        {
            // Fetch the user associated with the provided token
            var authenticatedUserToken = await _db.UserTokens.Include(ut => ut.User).FirstOrDefaultAsync(ut => ut.Token == UserToken);

            if (authenticatedUserToken == null)
            {
                // Respond with error if the token is invalid
                return Unauthorized(new { error = "Invalid token." });
            }

            if (authenticatedUserToken.User == null)
            {
                // Respond with error if the user associated with the token does not exist
                return Unauthorized(new { error = "User associated with this token doesn't exist." });
            }

            // Fetch the learning plan for the user
            var learningPlan = await _db.LearningPlans
                .Include(lp => lp.LearningPlanItems)
                .ThenInclude(lpi => lpi.Course)
                .Include(lp => lp.LearningPlanItems)
                .ThenInclude(lpi => lpi.Incentive)
                .FirstOrDefaultAsync(lp => lp.UserId == authenticatedUserToken.UserId);

            if (learningPlan == null)
            {
                // Respond with error if the user does not have a learning plan
                return NotFound(new { error = "Learning plan not found for this user." });
            }

            // Format the learning plan items for the response
            var planItems = learningPlan.LearningPlanItems.Select(lpi => new PlanItemResponse
            {
                LearningPlanItemId = lpi.LearningPlanItemId,
                LearningItemType = lpi.LearningItemType.ToString(),
                LearningItemName = lpi.LearningItemType == Enums.LearningItemType.Course && lpi.Course != null ? lpi.Course.CourseName : lpi.Incentive?.IncentiveName ?? "No Name",
                ItemId = lpi.LearningItemType == Enums.LearningItemType.Course && lpi.Course != null ? lpi.Course.CourseId : lpi.Incentive?.IncentiveId ?? 0
            }).ToList();

            // Return the learning plan
            return Ok(new LearningPlanResponse { UserId = authenticatedUserToken.User.UserId, PlanItems = planItems });
        }
        catch (Exception ex)
        {
            // Log exception here and respond with a server error
            return StatusCode(500, new { error = $"An error occurred while processing the request: {ex.Message}" });
        }
    }
}