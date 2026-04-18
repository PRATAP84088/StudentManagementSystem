# 🎓 Student Management System

A web application built with **ASP.NET MVC** and **Entity Framework Core** for managing student records.

## 📋 Features

- ✅ View all students in a searchable, clean table
- ✅ Add new student records
- ✅ Edit existing student details
- ✅ View full student profile
- ✅ Delete student records with confirmation
- ✅ Search by name, course, or email
- ✅ Seed data for quick testing

## 🛠 Tech Stack

| Layer        | Technology                        |
|--------------|-----------------------------------|
| Language     | C#                                |
| Framework    | ASP.NET MVC (.NET 8)              |
| ORM          | Entity Framework Core             |
| Database     | SQL Server (LocalDB)              |
| Frontend     | HTML, CSS (custom)                |
| IDE          | Visual Studio                     |
| Version Control | Git & GitHub                   |

## 🚀 Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [SQL Server / LocalDB](https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or VS Code

### Setup

1. **Clone the repository**
   ```bash
   git clone https://github.com/PRATAP84088/StudentManagementSystem.git
   cd StudentManagementSystem
   ```

2. **Restore NuGet packages**
   ```bash
   dotnet restore
   ```

3. **Apply database migrations**
   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

4. **Run the application**
   ```bash
   dotnet run
   ```

5. **Open in browser**
   ```
   https://localhost:5001
   ```

## 📁 Project Structure

```
StudentManagementSystem/
│
├── Controllers/
│   └── StudentsController.cs     # CRUD actions
│
├── Models/
│   ├── Student.cs                # Student entity
│   └── ApplicationDbContext.cs   # EF Core DbContext + seed data
│
├── Views/
│   ├── Students/
│   │   ├── Index.cshtml          # Student list with search
│   │   ├── Create.cshtml         # Add student form
│   │   ├── Edit.cshtml           # Edit student form
│   │   ├── Details.cshtml        # Student profile
│   │   └── Delete.cshtml         # Delete confirmation
│   └── Shared/
│       └── _Layout.cshtml        # Common layout/navbar
│
├── wwwroot/
│   └── css/site.css              # Custom styles
│
├── appsettings.json              # DB connection string
├── Program.cs                    # App entry point & middleware
└── StudentManagementSystem.csproj
```

## 🗄 Database Schema

```sql
Table: Students
- Id              INT           PRIMARY KEY (auto)
- FirstName       NVARCHAR(50)  NOT NULL
- LastName        NVARCHAR(50)  NOT NULL
- Email           NVARCHAR(MAX) NOT NULL
- PhoneNumber     NVARCHAR(MAX) NOT NULL
- Course          NVARCHAR(100) NOT NULL
- EnrollmentDate  DATETIME2     NOT NULL
```

Website link:- http://18.215.159.255/

## 👤 Author

**Pratap Singh**  
📧 pratap84088@gmail.com  
🔗 [LinkedIn](https://www.linkedin.com/in/-pratap-singh-/)  
🐙 [GitHub](https://github.com/PRATAP84088)

---
*Built as part of the portfolio project for Bachelor of Technology, CSE – Lovely Professional University*
