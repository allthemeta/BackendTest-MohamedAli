using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendChallenge.Models;

/// <summary>
/// Represents manager/management relationships
/// </summary>
public class ManagementRelationship
{
    // Unique ID for the relationship
    [Key]
    public int ManagementRelationshipId { get; set; }
    
    // Person who is being managed
    [Required]
    [ForeignKey("User")]
    public int ManageeId { get; set; }
    public virtual User Managee { get; set; }
    
    // The manager
    [Required]
    [ForeignKey("User")]
    public int ManagerId { get; set; }
    public virtual User Manager { get; set; }
}