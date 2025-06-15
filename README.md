# MagicVilla 🏡

**MagicVilla** is a full-stack villa booking platform built with ASP.NET Core Web API and ASP.NET MVC. It supports full CRUD operations, user authentication/authorization, and a responsive frontend for customers and admins.

---

## ✨ Features

- 🔐 User authentication with JWT
- 👤 Role-based authorization (Admin & Customer)
- 🏘 CRUD operations for villas
- 📅 Booking system with search & filter
- 🧭 API documentation with Swagger
- 🧰 AutoMapper integration
- ⚙️ Centralized error handling
- 📦 Repository + Unit of Work pattern
- 💬 Standardized API responses

---

## 🔧 Tech Stack

- **Backend**: ASP.NET Core Web API
- **Frontend**: ASP.NET Core MVC (Razor Views)
- **Database**: SQL Server (EF Core)
- **Authentication**: JWT
- **Mapping**: AutoMapper
- **ORM**: Entity Framework Core

---

## 🚀 Getting Started

### Prerequisites

- [.NET 7.0 SDK](https://dotnet.microsoft.com/en-us/download)
- SQL Server or LocalDB
- Visual Studio 2022 or Visual Studio Code

### Installation Steps

1. **Clone the repository**
   ```bash
   git clone https://github.com/mo7ammedwaleed/MagicVilla.git
   cd MagicVilla
````

2. **Configure the database**

   * Open `appsettings.json` in `MagicVilla/VillaAPI` and update your SQL connection string:

     ```json
     "ConnectionStrings": {
       "DefaultConnection": "Server=YOUR_SERVER;Database=MagicVilla;Trusted_Connection=True;MultipleActiveResultSets=true"
     }
     ```

3. **Apply Migrations**

   ```bash
   cd MagicVilla/VillaAPI
   dotnet ef database update
   ```

4. **Run the API**

   ```bash
   dotnet run
   ```

   Access Swagger at: `https://localhost:{PORT}/swagger`

5. **Run the Web App**

   ```bash
   cd ../MagicVilla_Web
   dotnet run
   ```

---

## 🔑 Authentication Flow

1. **Register**: `/api/v1/UsersAuth/register`
2. **Login**: `/api/v1/UsersAuth/login`
3. Add `Authorization: Bearer <token>` in headers for protected endpoints.

Roles:

* `admin`: Can manage villas and users
* `customer`: Can view and book villas

---

## 🧪 API Endpoints

**Swagger UI**: `https://localhost:{PORT}/swagger`

Example endpoints:

* `GET /api/v1/villa` - Get all villas
* `POST /api/v1/villa` - Create new villa (admin only)
* `POST /api/v1/villaNumber` - Assign villa number
* `POST /api/v1/UsersAuth/register` - Register user
* `POST /api/v1/UsersAuth/login` - Login and receive JWT

---

## 📁 Project Structure

```text
MagicVilla/
│
├── VillaAPI/           # ASP.NET Core Web API project
│   ├── Controllers/
│   ├── Models/
│   ├── DTOs/
│   ├── Repository/
│   ├── Services/
│   └── appsettings.json
│
├── MagicVilla_Utility/ # Shared utility classes (e.g. SD.cs)
│
├── MagicVilla_Web/     # ASP.NET MVC front-end
│   ├── Controllers/
│   ├── Views/
│   └── wwwroot/
│
└── README.md
````
## 📸 Screenshots
![Screenshot 2025-06-15 224942](https://github.com/user-attachments/assets/1530ba41-eb5c-45e0-a7ec-54c9b21b21a5)
![Screenshot 2025-06-15 224950](https://github.com/user-attachments/assets/0db1031c-0f22-4a72-9a54-acd0d1079008)
![Screenshot 2025-06-15 224935](https://github.com/user-attachments/assets/744915ac-0e60-4fd0-8725-3da92f7df676)
![Screenshot 2025-06-15 225025](https://github.com/user-attachments/assets/8a281c52-a575-408c-b1c5-b0398a9b1127)
![Screenshot 2025-06-15 225149](https://github.com/user-attachments/assets/118ad913-6e6a-4be1-b5b7-4437d9fefd72)
![Screenshot 2025-06-15 225155](https://github.com/user-attachments/assets/3fc0cd60-4620-4e9b-8a2b-2fb24d1aeae2)
![Screenshot 2025-06-15 225210](https://github.com/user-attachments/assets/000d8146-fdc6-4b91-a879-ea3ff68bccc5)
![Screenshot 2025-06-15 225216](https://github.com/user-attachments/assets/43eb711c-9510-48b7-b46b-b6658053d815)
![Screenshot 2025-06-15 225241](https://github.com/user-attachments/assets/66fc510d-eeac-4889-ba99-6d5fea8bc7c0)
![Screenshot 2025-06-15 225311](https://github.com/user-attachments/assets/acbd32c2-c234-43e5-8d81-91e77859ea7b)
![Screenshot 2025-06-15 231414](https://github.com/user-attachments/assets/b28f813e-9c7c-4464-98a1-9b06ad4dfb04)
![Screenshot 2025-06-15 231432](https://github.com/user-attachments/assets/af96ac24-b062-4e7c-b600-190b3876e573)
![Screenshot 2025-06-15 231425](https://github.com/user-attachments/assets/775d5ee5-18f5-43c4-887f-2e390ad8fb6f)
![Screenshot 2025-06-15 232021](https://github.com/user-attachments/assets/49f51b00-08d6-47bf-bda1-a2b5b7d329e9)
