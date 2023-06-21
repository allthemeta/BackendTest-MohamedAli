using Microsoft.AspNetCore.Mvc;
using BackendChallenge.Data;
using Microsoft.EntityFrameworkCore;

namespace BackendChallenge.Controllers;

[ApiController]
[Route("users")]
public class UsersController : ControllerBase
{
    private readonly ILogger<UsersController> _logger;
    private readonly AppDbContext _db;

    public class UserResponse
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }


    public UsersController(ILogger<UsersController> logger, AppDbContext db)
    {
        _logger = logger;
        _db = db;
    }

    [HttpGet("working")]
    public async Task<ActionResult<string>> Index(CancellationToken token)
    {
        var x = await _db.Users.FirstOrDefaultAsync(token);
        return Ok("it's working");
    }

    /// <summary>
    /// Endpoint to get all active users from the same company as the authenticated user.
    /// </summary>
    /// <param name="UserToken">The token of the authenticated user. It should be passed in the header of the request.</param>
    /// <returns>A list of active users (userId, firstName, lastName) belonging to the same company as the authenticated user.</returns>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<UserResponse>>> GetActiveUsers([FromHeader] string UserToken)
    {
        try
        {
            var authenticatedUserToken = await _db.UserTokens.Include(ut => ut.User).FirstOrDefaultAsync(ut => ut.Token == UserToken);

            if (authenticatedUserToken == null)
            {
                return Unauthorized(new { error = "Invalid token." });
            }

            if (authenticatedUserToken.User == null)
            {
                return Unauthorized(new { error = "User associated with this token doesn't exist." });
            }

            var companyId = authenticatedUserToken.User.CompanyId;

            var users = await _db.Users
                .Where(u => u.CompanyId == companyId)
                .Select(u => new UserResponse
                {
                    UserId = u.UserId,
                    FirstName = u.FirstName,
                    LastName = u.LastName
                })
                .ToListAsync();

            if (!users.Any())
            {
                return NotFound(new { error = "No active users found for this company." });
            }

            return Ok(users);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while trying to fetch active users.");
            return StatusCode(500, new { error = $"An error occurred while processing the request: {ex.Message}" });
        }
    }
}