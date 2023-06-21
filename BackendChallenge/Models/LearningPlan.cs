using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BackendChallenge.Enums;

namespace BackendChallenge.Models;

/// <summary>
/// Represents a user's programs and incentives
/// </summary>
public class LearningPlan
{
    public LearningPlan()
    {
        LearningPlanItems = new Collection<LearningPlanItem>();
    }
    
    // Unique id for the Learning Plan
    [Key]
    public int LearningPlanId { get; set; }
    
    // The ID of the user whose user plan this is
    [ForeignKey("User")]
    public int UserId { get; set; }
    public virtual User User { get; set; }
    
    // The status of the Learning Plan
    [DefaultValue(PlanStatus.Active)]
    public PlanStatus PlanStatus { get; set; }
    
    public virtual ICollection<LearningPlanItem> LearningPlanItems { get; set; }
}