using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendChallenge.Models;

/// <summary>
/// Maps user access tokens to user IDs
/// </summary>
public class UserToken
{
    // "Secret" Token that maps to a user. Used to look up the user
    [Key]
    public string Token { get; set; }
    
    // ID of user who token maps to
    [Required]
    [ForeignKey("User")]
    public int UserId { get; set; }
    public virtual User User { get; set; }
}