using Microsoft.AspNetCore.Mvc;
using BackendChallenge.Data;
using BackendChallenge.Services;
using Microsoft.EntityFrameworkCore;

namespace BackendChallenge.Controllers;

/// <summary>
/// The IncentivesController handles API requests related to user incentives.
/// </summary>
[ApiController]
[Route("incentives")]
public class IncentivesController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly IncentiveService _incentiveService;

    public IncentivesController(AppDbContext context, IncentiveService incentiveService)
    {
        _context = context;
        _incentiveService = incentiveService;
    }

    /// <summary>
    /// GetEligibleIncentives handles a GET request to fetch the incentives for which a user is eligible.
    /// </summary>
    /// <param name="UserToken">The token of the user for whom the incentives are fetched.</param>
    /// <returns>A JSON response containing the user ID and a list of eligible incentives.</returns>
    [HttpGet]
    public IActionResult GetEligibleIncentives([FromHeader] string UserToken)
    {
        var user = _context.UserTokens
            .Include(ut => ut.User)
            .FirstOrDefault(ut => ut.Token == UserToken)?.User;

        if (user == null)
            return Unauthorized("Invalid user token");

        // Determine if the user is a manager.
        var isManager = _context.ManagementRelationships.Any(mr => mr.ManagerId == user.UserId);

        var eligibleIncentives = _incentiveService.GetEligibleIncentivesForUser(user, isManager);

        return Ok(new
        {
            UserId = user.UserId,
            Incentives = eligibleIncentives
        });
    }
}