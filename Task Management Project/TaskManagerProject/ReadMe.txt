# Task Management System

## Overview

This project is a Task Management System designed to help Employees, Managers/Team Leaders, and Company Admins track tasks, manage team activities, and generate reports on task completion status.

## Features

- **Task Management:**
 - Create, update, and delete tasks.
 - Assign tasks to Employees.
 - Set due dates and track task completion status.

- **Attachments and Notes:**
 - Attach documents/files to tasks.
 - Add notes/comments to tasks.

- **Role-Based Access:**   -- Under Development
 - Employees can manage their own tasks.
 - Managers/Team Leaders can view and manage tasks of their team members.
 - Company Admins have access to reports and analytics. 

- **Reporting:**   -- Under Development
 - Generate reports to track task completion.
 - View tasks due in a Week, Month, etc.
 - Analyze team performance based on task metrics.

 ----------------------------------------------------------------------------------------------------------------------------------

## Technologies Used:

- **Backend:**
 - .NET Core - Cross-platform framework for building APIs and web applications.
 - Entity Framework Core (EF Core) - ORM framework for database interactions.
 - SQL Server - Relational database management system.
- **Frontend (Optional, if applicable):**
 - HTML, CSS, JavaScript (or frameworks like Angular, React, etc.).

## Setup Instructions
1. **Clone the Repository:**
  ```bash
  git clone
https://github.com/your/repository.git
  cd task-management-system
  ```
2. **Database Setup:**
  - Ensure SQL Server is installed and running.
  - Update the connection string in `appsettings.json` to point to your SQL Server instance.

3. **Run Migrations:**
  ```bash
  dotnet ef database update
  ```
  This will create the necessary database schema based on your EF Core migrations.

4. **Run the Application:**
  ```bash
  dotnet run
  ```
  The application will start and be accessible via `http://localhost:5000` (or another port specified).

5. **Access the Application:**
  - Open your web browser and go to `http://localhost:5000`.
  - Log in with appropriate credentials based on your role (Employee, Manager, Admin).

------------------------------------------------------------------------------------------------------------------------------------


## Folder Structure
- **/Controllers:** Contains API endpoints and MVC controllers.
- **/Models:** Entity Framework models representing database tables.
- **/Views:** (If using MVC) Contains Razor views for rendering UI.
- **/Services:** Business logic and services for task management and reporting.

## Contributing
Contributions are welcome! Please fork the repository and create a pull request with your changes.

## License
This project is licensed under the MIT License - see the [LICENSE](./LICENSE) file for details.

## Contact
For questions or support, contact [Chandrashekhar N] (chandrunandish@gmail.com).
---