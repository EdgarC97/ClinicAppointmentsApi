# Clinic Appointment Management API
A RESTful API for managing appointments, doctors' availability, users, and authentication in a clinic system.

## Table of Contents
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
  - [Configuration](#configuration)
- [Additional Considerations](#additional-considerations)

## Features
- CRUD operations for appointments, doctors' availability, and users
- Role-based authorization for different user types (e.g., Admin, User)
- JWT authentication for secure and protected endpoints
- Manage doctor schedules and appointment bookings
- Only Admin users can delete appointments
- User registration and login with hashed passwords

## Technologies Used
- ASP.NET Core
- Entity Framework Core
- MySQL
- JWT for authentication
- Swagger for API documentation

## Getting Started

### Prerequisites
- [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet)
- [MySQL Server](https://dev.mysql.com/downloads/)
- A code editor like [Visual Studio](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)

### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/clinic-appointments-api.git
   cd clinic-appointments-api

2. Restore dotnet packages:
   ```bash
   dotnet restore

3. Add .env file

4. Initialize the application:
   ```bash
   dotnet run

### For more details on the endpoints and their parameters, please refer to the Swagger documentation available at /swagger when the API is running.