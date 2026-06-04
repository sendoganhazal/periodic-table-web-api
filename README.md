# Periodic Table Web API 🧪✨

A lightweight, high-performance Web API that provides comprehensive chemical, physical, and structural data for **119 elements** of the periodic table. Built using modern backend technologies, this API is designed to serve as a robust data source for frontend perodic table applications.

---

## 🚀 Live Demo & Deployment
The API is containerized using Docker and successfully deployed on **Render**.
* **Live API URL:** `https://periodic-table-web-api-fjzo.onrender.com/api/elements`
* **Interactive API Documentation:** `https://periodic-table-web-api-fjzo.onrender.com/swagger/index.html`

---

## 🛠️ Tech Stack & Architecture

* **Backend Framework:** .NET 9.0 (ASP.NET Core Web API)
* **Database:** SQLite (Lightweight, file-based relational database)
* **ORM:** Entity Framework Core 9.0 (Code-First Approach)
* **Containerization:** Docker (Multi-stage builds)
* **Documentation:** Swagger / OpenAPI UI

---

## ✨ Features

- **Complete Data Seed:** Automatically seeds **119 elements** directly from a structured JSON file upon the first database migration.
- **Relational Data Mapping:** Handles complex elements data, including automated handling of sub-resources like nested element images (`ElementImage`).
- **Data Parsing:** Handles dynamic array formatting (such as electron shells and ionization energies) flattened neatly into SQLite-compatible structures.

---

## 🛣️ API Endpoints

### 📑 Elements Endpoints
| Method | Endpoint | Description |
| :--- | :--- | :--- |
| `GET` | `/api/elements` | Retrieves all 119 elements with full data and images. |
| `GET` | `/api/elements/{id}` | Retrieves a specific element by its unique Database ID. |
| `GET` | `/api/elements/atomic-number/{number}` | Retrieves a specific element by its Atomic Number. |

### 🗂️ Categories & Filtering Endpoints
| Method | Endpoint | Description |
| :--- | :--- | :--- |
| `GET` | `/api/elements/categories` | Returns a list of all unique categories (e.g., *Noble Gas, Alkali Metal*). |
| `GET` | `/api/elements/category/{categoryName}` | Filters and returns elements belonging to a specific category. |

---

## 🐳 How to Run Locally with Docker

If you prefer to run this project inside a container environment, ensure you have **Docker** installed, then execute:

1. **Build the Docker Image:**
   ```bash
   docker build -t periodic-table-api .

2. **Run the Container:**
   ```bash
 docker run -d -p 8080:80 --name periodic-api-instance periodic-table-api .

   
3. **Build the Docker Image:**
   ```bash
   docker build -t periodic-table-api .
