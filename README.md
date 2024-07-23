# Employment Verification Application

## Description

This is a simple web application that allows users to verify employment details for a given employee.

## Technologies Used

- Frontend: React
- Backend: ASP.NET Core Web API
- Database: In-memory data structure

## How to Run the Application

### Prerequisites

- Node.js (for frontend)
- .NET Core SDK (for backend)

### Frontend

1. Navigate to the `frontend` directory.
2. Install dependencies: `npm install`
3. Start the application: `npm start`
4. The frontend will be running at `http://localhost:3000`.

### Backend

1. Navigate to the `backend` directory.
2. Build the application: `dotnet build`
3. Run the application: `dotnet run`
4. The backend API will be running at `http://localhost:5000`.

### Assumptions

- The verification logic checks for exact matches of employee ID, company name, and verification code.
- The data is prepopulated with a few sample records for testing purposes.

## API Endpoint

- POST `/api/verify-employment`
  - Request body:
    ```json
    {
      "employeeId": 1,
      "companyName": "ABC Corp",
      "verificationCode": "ABC123"
    }
    ```
  - Response:
    ```json
    {
      "verified": true
    }
    ```



