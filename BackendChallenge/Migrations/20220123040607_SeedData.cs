using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendChallenge.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "CompanyName" },
                values: new object[] { 1, "Acme Inc." });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "CompanyName" },
                values: new object[] { 2, "General Co." });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CourseName" },
                values: new object[] { 1, "Intro to Machine Learning" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CourseName" },
                values: new object[] { 2, "Data Structures and Algorithms" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CourseName" },
                values: new object[] { 3, "Principles of Communication" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CourseName" },
                values: new object[] { 4, "Managerial Economics" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CourseName" },
                values: new object[] { 5, "Design Thinking" });

            migrationBuilder.InsertData(
                table: "Incentives",
                columns: new[] { "IncentiveId", "CompanyId", "IncentiveName", "RoleEligibility", "ServiceRequirementDays" },
                values: new object[] { 1, 1, "Completion Bonus", 0, 90 });

            migrationBuilder.InsertData(
                table: "Incentives",
                columns: new[] { "IncentiveId", "CompanyId", "IncentiveName", "RoleEligibility", "ServiceRequirementDays" },
                values: new object[] { 2, 1, "Software Engineering Scholarship", 0, 180 });

            migrationBuilder.InsertData(
                table: "Incentives",
                columns: new[] { "IncentiveId", "CompanyId", "IncentiveName", "RoleEligibility", "ServiceRequirementDays" },
                values: new object[] { 3, 1, "20% Time", 1, 90 });

            migrationBuilder.InsertData(
                table: "Incentives",
                columns: new[] { "IncentiveId", "CompanyId", "IncentiveName", "RoleEligibility", "ServiceRequirementDays" },
                values: new object[] { 4, 2, "Software Engineering Scholarship", 0, 30 });

            migrationBuilder.InsertData(
                table: "Incentives",
                columns: new[] { "IncentiveId", "CompanyId", "IncentiveName", "RoleEligibility", "ServiceRequirementDays" },
                values: new object[] { 5, 2, "20% Time", 1, 90 });

            migrationBuilder.InsertData(
                table: "Incentives",
                columns: new[] { "IncentiveId", "CompanyId", "IncentiveName", "RoleEligibility", "ServiceRequirementDays" },
                values: new object[] { 6, 1, "Management Scholarship", 2, 0 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CompanyId", "FirstName", "LastName", "TenureDays" },
                values: new object[] { 1, 1, "Karalynn", "Northcote", 365 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CompanyId", "FirstName", "LastName", "TenureDays" },
                values: new object[] { 2, 1, "Sean", "Carter", 250 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CompanyId", "FirstName", "LastName", "TenureDays" },
                values: new object[] { 3, 1, "Fielding", "Cabera", 5 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CompanyId", "FirstName", "LastName", "TenureDays" },
                values: new object[] { 4, 1, "Dan", "Fawlkes", 150 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CompanyId", "FirstName", "LastName", "TenureDays" },
                values: new object[] { 5, 2, "Pete", "Peterson", 120 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CompanyId", "FirstName", "LastName", "TenureDays" },
                values: new object[] { 6, 2, "Jane", "Rowe", 119 });

            migrationBuilder.InsertData(
                table: "LearningPlans",
                columns: new[] { "LearningPlanId", "PlanStatus", "UserId" },
                values: new object[] { 1, 2, 1 });

            migrationBuilder.InsertData(
                table: "LearningPlans",
                columns: new[] { "LearningPlanId", "PlanStatus", "UserId" },
                values: new object[] { 2, 0, 1 });

            migrationBuilder.InsertData(
                table: "LearningPlans",
                columns: new[] { "LearningPlanId", "PlanStatus", "UserId" },
                values: new object[] { 3, 0, 2 });

            migrationBuilder.InsertData(
                table: "LearningPlans",
                columns: new[] { "LearningPlanId", "PlanStatus", "UserId" },
                values: new object[] { 4, 0, 3 });

            migrationBuilder.InsertData(
                table: "LearningPlans",
                columns: new[] { "LearningPlanId", "PlanStatus", "UserId" },
                values: new object[] { 5, 1, 4 });

            migrationBuilder.InsertData(
                table: "LearningPlans",
                columns: new[] { "LearningPlanId", "PlanStatus", "UserId" },
                values: new object[] { 6, 1, 4 });

            migrationBuilder.InsertData(
                table: "LearningPlans",
                columns: new[] { "LearningPlanId", "PlanStatus", "UserId" },
                values: new object[] { 7, 0, 5 });

            migrationBuilder.InsertData(
                table: "LearningPlans",
                columns: new[] { "LearningPlanId", "PlanStatus", "UserId" },
                values: new object[] { 8, 0, 6 });

            migrationBuilder.InsertData(
                table: "ManagementRelationships",
                columns: new[] { "ManagementRelationshipId", "ManageeId", "ManagerId" },
                values: new object[] { 1, 2, 1 });

            migrationBuilder.InsertData(
                table: "ManagementRelationships",
                columns: new[] { "ManagementRelationshipId", "ManageeId", "ManagerId" },
                values: new object[] { 2, 3, 2 });

            migrationBuilder.InsertData(
                table: "ManagementRelationships",
                columns: new[] { "ManagementRelationshipId", "ManageeId", "ManagerId" },
                values: new object[] { 3, 4, 2 });

            migrationBuilder.InsertData(
                table: "ManagementRelationships",
                columns: new[] { "ManagementRelationshipId", "ManageeId", "ManagerId" },
                values: new object[] { 4, 6, 5 });

            migrationBuilder.InsertData(
                table: "UserTokens",
                columns: new[] { "Token", "UserId" },
                values: new object[] { "13ZaMF5UhrKpNeykfMQi2dXWR7TfdVdnmK", 5 });

            migrationBuilder.InsertData(
                table: "UserTokens",
                columns: new[] { "Token", "UserId" },
                values: new object[] { "1CAZ4osj74GJDsjYHkTcoJrWXDGyazcsLr", 3 });

            migrationBuilder.InsertData(
                table: "UserTokens",
                columns: new[] { "Token", "UserId" },
                values: new object[] { "1DeyjK5vvSwjc9o9jYArVo2yov2SnjnXEE", 4 });

            migrationBuilder.InsertData(
                table: "UserTokens",
                columns: new[] { "Token", "UserId" },
                values: new object[] { "1F7Xg1CJdffsnv9uEXj6GhLERQSam4xwx6", 2 });

            migrationBuilder.InsertData(
                table: "UserTokens",
                columns: new[] { "Token", "UserId" },
                values: new object[] { "1GdK8dmV8mDetnWV9kdchqSgXxBDMjz4ia", 6 });

            migrationBuilder.InsertData(
                table: "UserTokens",
                columns: new[] { "Token", "UserId" },
                values: new object[] { "1MEYQDDgwrTkYPtu7Vhfyjp7qkuGnf4ztR", 1 });

            migrationBuilder.InsertData(
                table: "LearningPlanItems",
                columns: new[] { "LearningPlanItemId", "CourseId", "IncentiveId", "LearningItemStatus", "LearningItemType", "LearningPlanId" },
                values: new object[] { 1, 1, null, 0, 0, 1 });

            migrationBuilder.InsertData(
                table: "LearningPlanItems",
                columns: new[] { "LearningPlanItemId", "CourseId", "IncentiveId", "LearningItemStatus", "LearningItemType", "LearningPlanId" },
                values: new object[] { 2, null, 1, 0, 1, 1 });

            migrationBuilder.InsertData(
                table: "LearningPlanItems",
                columns: new[] { "LearningPlanItemId", "CourseId", "IncentiveId", "LearningItemStatus", "LearningItemType", "LearningPlanId" },
                values: new object[] { 3, 4, null, 0, 0, 3 });

            migrationBuilder.InsertData(
                table: "LearningPlanItems",
                columns: new[] { "LearningPlanItemId", "CourseId", "IncentiveId", "LearningItemStatus", "LearningItemType", "LearningPlanId" },
                values: new object[] { 4, 5, null, 0, 0, 3 });

            migrationBuilder.InsertData(
                table: "LearningPlanItems",
                columns: new[] { "LearningPlanItemId", "CourseId", "IncentiveId", "LearningItemStatus", "LearningItemType", "LearningPlanId" },
                values: new object[] { 5, null, 1, 0, 1, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Incentives",
                keyColumn: "IncentiveId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Incentives",
                keyColumn: "IncentiveId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Incentives",
                keyColumn: "IncentiveId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Incentives",
                keyColumn: "IncentiveId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Incentives",
                keyColumn: "IncentiveId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "LearningPlanItems",
                keyColumn: "LearningPlanItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LearningPlanItems",
                keyColumn: "LearningPlanItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LearningPlanItems",
                keyColumn: "LearningPlanItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LearningPlanItems",
                keyColumn: "LearningPlanItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LearningPlanItems",
                keyColumn: "LearningPlanItemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LearningPlans",
                keyColumn: "LearningPlanId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LearningPlans",
                keyColumn: "LearningPlanId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LearningPlans",
                keyColumn: "LearningPlanId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LearningPlans",
                keyColumn: "LearningPlanId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "LearningPlans",
                keyColumn: "LearningPlanId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "LearningPlans",
                keyColumn: "LearningPlanId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ManagementRelationships",
                keyColumn: "ManagementRelationshipId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ManagementRelationships",
                keyColumn: "ManagementRelationshipId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ManagementRelationships",
                keyColumn: "ManagementRelationshipId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ManagementRelationships",
                keyColumn: "ManagementRelationshipId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserTokens",
                keyColumn: "Token",
                keyValue: "13ZaMF5UhrKpNeykfMQi2dXWR7TfdVdnmK");

            migrationBuilder.DeleteData(
                table: "UserTokens",
                keyColumn: "Token",
                keyValue: "1CAZ4osj74GJDsjYHkTcoJrWXDGyazcsLr");

            migrationBuilder.DeleteData(
                table: "UserTokens",
                keyColumn: "Token",
                keyValue: "1DeyjK5vvSwjc9o9jYArVo2yov2SnjnXEE");

            migrationBuilder.DeleteData(
                table: "UserTokens",
                keyColumn: "Token",
                keyValue: "1F7Xg1CJdffsnv9uEXj6GhLERQSam4xwx6");

            migrationBuilder.DeleteData(
                table: "UserTokens",
                keyColumn: "Token",
                keyValue: "1GdK8dmV8mDetnWV9kdchqSgXxBDMjz4ia");

            migrationBuilder.DeleteData(
                table: "UserTokens",
                keyColumn: "Token",
                keyValue: "1MEYQDDgwrTkYPtu7Vhfyjp7qkuGnf4ztR");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Incentives",
                keyColumn: "IncentiveId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LearningPlans",
                keyColumn: "LearningPlanId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LearningPlans",
                keyColumn: "LearningPlanId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: 1);
        }
    }
}
