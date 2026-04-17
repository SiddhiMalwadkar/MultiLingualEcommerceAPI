# Multilingual E-Commerce API

A RESTful Web API built using **ASP.NET Core** that supports **multi-language product management**. This project demonstrates how to implement **localization (i18n)** in a real-world e-commerce backend system.

---

##  Features

* Product Management (CRUD operations)
* Multi-language support (English 🇺🇸, German 🇩🇪)
* RESTful API architecture
* Clean project structure (Controller, Model, Data)
* Resource-based localization using `.resx` files
* Lightweight and scalable backend

---

## Tech Stack

* **Backend:** ASP.NET Core Web API
* **Database:** SQL Server / LocalDB
* **ORM:** Entity Framework Core
* **Localization:** Resource files (`.resx`)
* **Tools:** Visual Studio / VS Code, Git, GitHub

---

## 📂 Project Structure

```
MultiLingualEcommerceAPI/
│
├── Controllers/
│   └── ProductsController.cs
│
├── Models/
│   └── Product.cs
│
├── Data/
│   └── AppDbContext.cs
│
├── Resources/
│   ├── Controllers.ProductsController.en-US.resx
│   └── Controllers.ProductsController.de-DE.resx
│
├── Program.cs
└── README.md
```

---

## Localization Support

This API supports multiple languages using **resource files**:

* 🇺🇸 English → `en-US`
* 🇩🇪 German → `de-DE`

Language can be switched using request headers:

```
Accept-Language: en-US
Accept-Language: de-DE
```

---

## 📌 API Endpoints

| Method | Endpoint             | Description       |
| ------ | -------------------- | ----------------- |
| GET    | `/api/products`      | Get all products  |
| GET    | `/api/products/{id}` | Get product by ID |
| POST   | `/api/products`      | Add new product   |
| PUT    | `/api/products/{id}` | Update product    |
| DELETE | `/api/products/{id}` | Delete product    |

---

## How to Run the Project

1. Clone the repository:

```
git clone https://github.com/SiddhiMalwadkar/MultiLingualEcommerceAPI.git
```

2. Open in Visual Studio / VS Code

3. Restore dependencies:

```
dotnet restore
```

4. Run the project:

```
dotnet run
```

5. Test API using:

* Postman
* Swagger (if enabled)

---

## Key Learning Outcomes

* Implemented **multilingual support in ASP.NET Core**
* Understood **REST API design principles**
* Worked with **Entity Framework Core**
* Learned **resource-based localization**

---

## Future Enhancements

* Authentication & Authorization (JWT)
* Order Management Module
* Payment Integration
* Admin Dashboard
* More language support

---

## Author

**Siddhi Malwadkar**

* MCA Student

---

## ⭐ If you like this project

Give it a ⭐ on GitHub and feel free to connect!

---
