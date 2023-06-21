using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BackendChallenge.Enums;

namespace BackendChallenge.Models;

/// <summary>
/// Represents an incentive offered by a company
/// </summary>
public class Incentive
{
    // Unique Id for the incentive
    [Key]
    public int IncentiveId { get; set; }
    
    // Display name of the incentive
    public string IncentiveName { get; set; }
    
    // How many days an employee needs to work at the company to be eligible
    public int ServiceRequirementDays { get; set; }
    
    // What roles are eligible for this incentive
    public RoleEligibility RoleEligibility { get; set; }
    
    // Company that created this incentive
    [Required]
    [ForeignKey("Company")]
    public int CompanyId { get; set; }
    public virtual Company Company { get; set; }





}