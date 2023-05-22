# CommsCampaign

CommsCampaign is a web application that provides a RESTful API for managing scheduled messages and campaigns. It also includes a frontend built with React.js for creating new messages and campaigns.

## Features

- Create and manage campaigns with a name, description, and active status.
- Create and manage messages with a description, message text, and active status.
- Schedule messages within campaigns with start dates, times, and the number of contacts.
- Retrieve a list of scheduled messages based on specified criteria.

## Technologies Used

- Backend:
  - C#
  - ASP.NET Core Web API
  - MS SQL Server
  - Entity Framework Core

- Frontend:
  - React.js
  - React Router

## Prerequisites

- Node.js (v12 or above)
- .NET Core SDK
- MS SQL Server

## Getting Started

### Backend

1. Clone the repository.

2. Open the `API` folder in Visual Studio Code.

3. Update the database connection string in the `appsettings.json` file to point to your MS SQL Server instance.

4. Open a terminal in the `API` folder and run the following command to apply the database migrations:

   ```bash
   dotnet ef database update
   ```
 ### Run server backend:
 ```bash
 dotnet run
```

The server will start on 'https://localhost:5001.'

### Frontend

1. Open a new terminal in the project root folder.

2. Navigate to the client folder:
```
cd campaignui
```
3. Install the dependencies:
```
npm install
```

4. Start the frontend development server:
```
npm start

```
The frontend application will be served at 'http://localhost:3000'.














