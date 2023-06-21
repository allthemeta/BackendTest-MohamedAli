using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BackendChallenge.Models;

/// <summary>
/// Entity that represents the company a user belongs to
/// </summary>
public class Company
{
    // Unique id for the company
    [Key]
    public int CompanyId { get; set; }
    
    // Name of the company
    [Required]
    public string CompanyName { get; set; }
}