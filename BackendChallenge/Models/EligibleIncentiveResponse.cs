namespace BackendChallenge.Models;

/// <summary>
/// Represents a response containing details of incentives for which a user is eligible.
/// </summary>
public class EligibleIncentiveResponse
{
    /// Gets or sets the ID of the incentive.
    public int IncentiveId { get; set; }

    /// Gets or sets the name of the incentive.
    public string IncentiveName { get; set; }

    /// Gets or sets the service requirement (in days) for the incentive.
    public int ServiceRequirement { get; set; }

    /// Gets or sets the role eligibility for the incentive. This could be "All", "IndividualContributor", or "Manager".
    public string RoleEligibility { get; set; }
}
