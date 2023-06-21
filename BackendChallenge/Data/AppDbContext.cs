using BackendChallenge.Enums;
using BackendChallenge.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendChallenge.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }

    public DbSet<User> Users { get; set; }
    public DbSet<UserToken> UserTokens { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<Incentive> Incentives { get; set; }
    public DbSet<LearningPlan> LearningPlans { get; set; }
    public DbSet<LearningPlanItem> LearningPlanItems { get; set; }
    public DbSet<ManagementRelationship> ManagementRelationships { get; set; }
    public DbSet<Course> Courses { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        SeedData(builder);
    }

    public void SeedData(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserToken>().HasData(
            new UserToken
            {
                Token = "1MEYQDDgwrTkYPtu7Vhfyjp7qkuGnf4ztR",
                UserId = 1
            },
            new UserToken
            {
                Token = "1F7Xg1CJdffsnv9uEXj6GhLERQSam4xwx6",
                UserId = 2
            },
            new UserToken
            {
                Token = "1CAZ4osj74GJDsjYHkTcoJrWXDGyazcsLr",
                UserId = 3
            },
            new UserToken
            {
                Token = "1DeyjK5vvSwjc9o9jYArVo2yov2SnjnXEE",
                UserId = 4
            },
            new UserToken
            {
                Token = "13ZaMF5UhrKpNeykfMQi2dXWR7TfdVdnmK",
                UserId = 5
            },
            new UserToken
            {
                Token = "1GdK8dmV8mDetnWV9kdchqSgXxBDMjz4ia",
                UserId = 6
            }
        );

        modelBuilder.Entity<Company>().HasData(
            new Company
            {
                CompanyId = 1,
                CompanyName = "Acme Inc."
            },
            new Company
            {
                CompanyId = 2,
                CompanyName = "General Co."
            }
        );

        modelBuilder.Entity<User>().HasData(
            new User
            {
                UserId = 1,
                FirstName = "Karalynn",
                LastName = "Northcote",
                TenureDays = 365,
                CompanyId = 1
            },
            new User
            {
                UserId = 2,
                FirstName = "Sean",
                LastName = "Carter",
                TenureDays = 250,
                CompanyId = 1
            },
            new User
            {
                UserId = 3,
                FirstName = "Fielding",
                LastName = "Cabera",
                TenureDays = 5,
                CompanyId = 1
            },
            new User
            {
                UserId = 4,
                FirstName = "Dan",
                LastName = "Fawlkes",
                TenureDays = 150,
                CompanyId = 1
            },
            new User
            {
                UserId = 5,
                FirstName = "Pete",
                LastName = "Peterson",
                TenureDays = 120,
                CompanyId = 2
            },
            new User
            {
                UserId = 6,
                FirstName = "Jane",
                LastName = "Rowe",
                TenureDays = 119,
                CompanyId = 2
            }
        );

        modelBuilder.Entity<ManagementRelationship>().HasData(
            new ManagementRelationship
            {
                ManagementRelationshipId = 1,
                ManageeId = 2,
                ManagerId = 1
            },
            new ManagementRelationship
            {
                ManagementRelationshipId = 2,
                ManageeId = 3,
                ManagerId = 2
            },
            new ManagementRelationship
            {
                ManagementRelationshipId = 3,
                ManageeId = 4,
                ManagerId = 2
            },
            new ManagementRelationship
            {
                ManagementRelationshipId = 4,
                ManageeId = 6,
                ManagerId = 5
            }
            );

        modelBuilder.Entity<LearningPlan>().HasData(
            new LearningPlan
            {
                LearningPlanId = 1,
                UserId = 1,
                PlanStatus = PlanStatus.Deleted
            },
            new LearningPlan
            {
                LearningPlanId = 2,
                UserId = 1,
                PlanStatus = PlanStatus.Active
            },
            new LearningPlan
            {
                LearningPlanId = 3,
                UserId = 2,
                PlanStatus = PlanStatus.Active
            },
            new LearningPlan
            {
                LearningPlanId = 4,
                UserId = 3,
                PlanStatus = PlanStatus.Active
            },
            new LearningPlan
            {
                LearningPlanId = 5,
                UserId = 4,
                PlanStatus = PlanStatus.Completed
            },
            new LearningPlan
            {
                LearningPlanId = 6,
                UserId = 4,
                PlanStatus = PlanStatus.Completed
            },
            new LearningPlan
            {
                LearningPlanId = 7,
                UserId = 5,
                PlanStatus = PlanStatus.Active
            },
            new LearningPlan
            {
                LearningPlanId = 8,
                UserId = 6,
                PlanStatus = PlanStatus.Active
            }
        );

        modelBuilder.Entity<Course>().HasData(
            new Course
            {
                CourseId = 1,
                CourseName = "Intro to Machine Learning"
            },
            new Course
            {
                CourseId = 2,
                CourseName = "Data Structures and Algorithms"
            },
            new Course
            {
                CourseId = 3,
                CourseName = "Principles of Communication"
            },
            new Course
            {
                CourseId = 4,
                CourseName = "Managerial Economics"
            },
            new Course
            {
                CourseId = 5,
                CourseName = "Design Thinking"
            }
        );

        modelBuilder.Entity<Incentive>().HasData(
            new Incentive
            {
                IncentiveId = 1,
                IncentiveName = "Completion Bonus",
                ServiceRequirementDays = 90,
                RoleEligibility = RoleEligibility.All,
                CompanyId = 1
            },
            new Incentive
            {
                IncentiveId = 2,
                IncentiveName = "Software Engineering Scholarship",
                ServiceRequirementDays = 180,
                RoleEligibility = RoleEligibility.All,
                CompanyId = 1
            },
            new Incentive
            {
                IncentiveId = 3,
                IncentiveName = "20% Time",
                ServiceRequirementDays = 90,
                RoleEligibility = RoleEligibility.IndividualContributor,
                CompanyId = 1
            },
            new Incentive
            {
                IncentiveId = 4,
                IncentiveName = "Software Engineering Scholarship",
                ServiceRequirementDays = 30,
                RoleEligibility = RoleEligibility.All,
                CompanyId = 2
            },
            new Incentive
            {
                IncentiveId = 5,
                IncentiveName = "20% Time",
                ServiceRequirementDays = 90,
                RoleEligibility = RoleEligibility.IndividualContributor,
                CompanyId = 2
            }, new Incentive
            {
                IncentiveId = 6,
                IncentiveName = "Management Scholarship",
                ServiceRequirementDays = 0,
                RoleEligibility = RoleEligibility.Manager,
                CompanyId = 1
            }
        );

        modelBuilder.Entity<LearningPlanItem>().HasData(
            new LearningPlanItem
            {
                LearningPlanItemId = 1,
                LearningPlanId = 1,
                LearningItemType = LearningItemType.Course,
                LearningItemStatus = LearningItemStatus.Active,
                CourseId = 1,
                IncentiveId = null,
            }, new LearningPlanItem
            {
                LearningPlanItemId = 2,
                LearningPlanId = 1,
                LearningItemType = LearningItemType.Incentive,
                LearningItemStatus = LearningItemStatus.Active,
                CourseId = null,
                IncentiveId = 1,
            }, new LearningPlanItem
            {
                LearningPlanItemId = 3,
                LearningPlanId = 3,
                LearningItemType = LearningItemType.Course,
                LearningItemStatus = LearningItemStatus.Active,
                CourseId = 4,
                IncentiveId = null,
            }, new LearningPlanItem
            {
                LearningPlanItemId = 4,
                LearningPlanId = 3,
                LearningItemType = LearningItemType.Course,
                LearningItemStatus = LearningItemStatus.Active,
                CourseId = 5,
                IncentiveId = null,
            }, new LearningPlanItem
            {
                LearningPlanItemId = 5,
                LearningPlanId = 3,
                LearningItemType = LearningItemType.Incentive,
                LearningItemStatus = LearningItemStatus.Active,
                CourseId = null,
                IncentiveId = 1,
            }
        );
    }
}