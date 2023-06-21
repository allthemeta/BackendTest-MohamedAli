# Backend Challenge Starter
This project is designed to handle various operations related to Users, Learning Plans, and Incentives in a company. It has the following main controllers: `UsersController`, `LearningPlanController`, and `IncentivesController`.

## UsersController
Handles operations related to Users. It can return all active users belonging to the same company as the authenticated user.

## LearningPlanController
Handles API requests related to a user's learning plan. The learning plan for a user can be fetched using a unique user token.

## IncentivesController
Handles API requests related to user incentives. It returns the incentives for which a user is eligible.

# Running the project
assuming you have .NET Core 6 installed.

1. Navigate to the backend challenge folder
cd ./BackendChallenge

2. Run the project
dotnet run

3. Verify it's working by navigating to these endpoints in your browser.

### Check if server is running
It should display the text "working".
https://localhost:7076/users/working


### Fetch Active Users
Returns a list of active users (userId, firstName, lastName) belonging to the same company as the authenticated user. You will need to provide a valid UserToken in the header.
https://localhost:7076/users

### Fetch Learning Plan
Returns the learning plan for a user. You will need to provide a valid UserToken in the header.
https://localhost:7076/learning-plan

### Fetch Eligible Incentives
Returns the incentives for which a user is eligible. You will need to provide a valid UserToken in the header.
https://localhost:7076/incentives

```