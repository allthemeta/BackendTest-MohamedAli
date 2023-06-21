using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendChallenge.Models;

/// <summary>
/// Represents a user in the system
/// </summary>
public class User
{
    // Unique ID for the user
    [Key]
    public int UserId { get; set; }
    
    // First name of the user
    [Required]
    public string FirstName { get; set; }
    
    // Last name of the user
    [Required]
    public string LastName { get; set; }
    
    // How many days the user has worked for their company
    [DefaultValue(0)]
    public int TenureDays { get; set; }
    
    // The company that the user belongs to
    [ForeignKey("Company")]
    public int CompanyId { get; set; }
    public virtual Company Company { get; set; }
    
}