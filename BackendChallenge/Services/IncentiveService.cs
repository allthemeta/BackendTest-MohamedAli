using BackendChallenge.Data;
using BackendChallenge.Models;
using BackendChallenge.Enums;

namespace BackendChallenge.Services
{
    /// <summary>
    /// IncentiveService is responsible for business logic related to incentives.
    /// </summary>
    public class IncentiveService
    {
        private readonly AppDbContext _context;

        public IncentiveService(AppDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// GetEligibleIncentivesForUser returns a list of incentives for which the specified user is eligible.
        /// </summary>
        /// <param name="user">The user for whom to fetch the eligible incentives.</param>
        /// <param name="isManager">A flag indicating whether the user is a manager. This is used to filter incentives based on role eligibility.</param>
        /// <returns>A list of incentives for which the user is eligible.</returns>
        public List<EligibleIncentiveResponse> GetEligibleIncentivesForUser(User user, bool isManager)
        {
            return _context.Incentives
                // Filters incentives based on user's tenure, company, and role
                .Where(i => i.ServiceRequirementDays <= user.TenureDays && i.CompanyId == user.CompanyId
                        && (i.RoleEligibility == RoleEligibility.All ||
                            (i.RoleEligibility == RoleEligibility.IndividualContributor && !isManager) ||
                            (i.RoleEligibility == RoleEligibility.Manager && isManager)))
                .Select(i => new EligibleIncentiveResponse
                {
                    IncentiveId = i.IncentiveId,
                    IncentiveName = i.IncentiveName,
                    ServiceRequirement = i.ServiceRequirementDays,
                    RoleEligibility = i.RoleEligibility.ToString()
                }).ToList();
        }
    }
}