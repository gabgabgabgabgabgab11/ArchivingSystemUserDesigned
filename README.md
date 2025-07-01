# Archiving System User Designed

This project is an Archiving System developed in C#. It allows users to upload, manage, search, and retrieve documents, ensuring efficient document storage and retrieval with a MySQL database backend.

## Features

- User authentication and management
- Document upload and archiving
- Advanced search and filtering
- Document retrieval (view/download)
- Activity logging
- Error handling and robust input validation

## Prerequisites

- **Windows OS** (recommended)
- **.NET Framework** (version used in your project, e.g., .NET 6.0 or .NET Framework 4.8)
- **MySQL Server** (e.g., MySQL 8.x)
- **MySQL Connector/NET** (for C# database connectivity)
- **Visual Studio** (2019 or later recommended)

## Setup Instructions

### 1. Clone the Repository

```bash
git clone https://github.com/gabgabgabgabgabgab11/ArchivingSystemUserDesigned.git
```

Or download and extract the ZIP file from GitHub.

### 2. Set Up the Database

1. **Install MySQL Server** if not already installed.
2. **Create a new database** (e.g., `archiving_system`).
3. **Import the Database Schema:**
   - Locate the provided `.sql` file in the repository (e.g., `/Resources/archiving_system.sql`).
   - Use MySQL Workbench or the MySQL command line:
     ```bash
     mysql -u your_username -p archiving_system < path/to/archiving_system.sql
     ```
   - Adjust table names, users, and privileges as needed.

### 3. Update Database Configuration

1. In the project directory, locate the configuration file for the database connection (e.g., `App.config`, `appsettings.json`, or a settings class).
2. Update the connection string to match your MySQL server settings:
    ```
    Server=localhost;Database=archiving_system;Uid=your_username;Pwd=your_password;
    ```

### 4. Install Dependencies

1. Open the solution (`.sln` file) with Visual Studio.
2. Restore NuGet packages if prompted.
3. Make sure **MySQL Connector/NET** is installed (check via NuGet Package Manager).

### 5. Build and Run the Application

1. Build the solution in Visual Studio (`Build > Build Solution`).
2. Run the application (`Debug > Start Debugging` or press `F5`).

### 6. Using the Application

- **Login:** Use the default admin/user credentials if provided, or create a new user.
- **Upload Documents:** Use the interface to add new records and upload files.
- **Search & Retrieve:** Try the advanced search and retrieval features.
- **Monitor Activity:** View logs and manage users as needed.

## Troubleshooting

- **Database Connection Errors:** Double-check your connection string and MySQL server status.
- **Missing Dependencies:** Use NuGet Package Manager to install any missing packages.
- **File System Errors:** Ensure the application has permission to read/write in the designated upload folders.

## Customization

- Update UI elements and branding as desired.
- Extend functionality by adding new modules or features as needed.

## License

This project is for academic/demo purposes. See [LICENSE](LICENSE) for more information.

---

**For any issues or questions, please open an issue on this repository.**
