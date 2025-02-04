# Public Information API

## Overview
This is a simple public API that returns basic information in JSON format, including:
- Your registered email address (used to register on the HNG12 Slack workspace).
- The current date and time in ISO 8601 format (UTC).
- The GitHub URL of the project's codebase.

## Technology Stack
- **Programming Language**: C#
- **Framework**: ASP.NET Core Minimal API
- **Hosting**: Deployed on a publicly accessible endpoint
- **CORS Handling**: Enabled to allow cross-origin requests

## API Specification
### **Endpoint:**
```http
GET /
```
### **Response Format (200 OK)**
```json
{
  "email": "your-email@example.com",
  "current_datetime": "2025-02-04T12:34:56.789Z",
  "github_url": "https://github.com/yourusername/your-repo"
}
```

## Setup Instructions
### **1️⃣ Clone the Repository**
```bash
git clone https://github.com/whiteSama001/PublicInfoAPI.git
cd PublicInfoAPI
```

### **2️⃣ Run Locally**
Ensure you have .NET SDK installed, then run:
```bash
dotnet run
```
Your API will be available at:
```
http://localhost:5000/
```

### **3️⃣ Deployment**
This API is deployed to a publicly accessible endpoint. You can deploy it using:
- **Azure App Service** (Recommended for free hosting)

## Documentation
This API supports CORS and returns responses in JSON format.
To learn more about C# and ASP.NET Core, visit:
- [HNG - Hire C# Developers](https://hng.tech/hire/csharp-developers)

## License
This project is licensed under the MIT License.

---
**Maintainer:** Your Name - [GitHub](https://github.com/whitesama001)

