using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendChallenge.Models;

/// <summary>
/// Represents a publicly available course
/// </summary>
public class Course
{
    // Unique Id for a course
    [Key]
    public int CourseId { get; set; }
    
    // Name of the course
    public string CourseName { get; set; }
}