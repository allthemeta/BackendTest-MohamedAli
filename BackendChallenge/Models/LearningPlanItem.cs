using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BackendChallenge.Enums;

namespace BackendChallenge.Models;

/// <summary>
/// Represents an item on the Learning Plan
/// </summary>
public class LearningPlanItem
{
    // Unique ID for this LearningPlanItem
    [Key]
    public int LearningPlanItemId { get; set; }
    
    // Learning Plan that this item belongs to
    [ForeignKey("LearningPlan")]
    public int LearningPlanId { get; set; }
    public virtual LearningPlan LearningPlan { get; set; }
    
    // The type of LearningPlanItme that this represents 
    [Required]
    public LearningItemType LearningItemType { get; set; }
    
    // The status of this LearningPlanItme
    [Required]
    public LearningItemStatus LearningItemStatus { get; set; }

    // If it's a course, the Id of the Course
    [ForeignKey("Course")]
    public int? CourseId { get; set; }
    public virtual Course? Course { get; set; }
    
    // If it's an incentive, the Id of the Incentive
    [ForeignKey("Incentive")]
    public int? IncentiveId { get; set; }
    public virtual Incentive? Incentive { get; set; }
}