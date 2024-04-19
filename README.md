# ProductsService

Here's a challenge I'd like us to go through during our upcoming interview. Use an IDE of choice, and during the interview, you will walk us through your solution.

## Scenario:

You are tasked with building a microservice to manage a list of products for an e-commerce platform. The microservice should provide basic CRUD operations for products.

## Requirements:

1. Microservice Implementation:
    - Setup dev environment
    - Create a new [ASP.NET](http://asp.net/) Core Web API project for the product microservice.
    - Implement endpoints to perform CRUD operations for products: Create, Read (All and Single), Update, and Delete.
    - Use in-memory storage or a lightweight database like SQLite for simplicity.
2. Data Model:
    - Define a simple data model for products with properties such as ID, Name, Price, Description, and Category.
3. API Endpoints:
    - Implement HTTP endpoints for the following operations:
    - GET /api/products: Retrieve a list of all products.
    - GET /api/products/{id}: Retrieve a specific product by ID.
    - POST /api/products: Create a new product.
    - PUT /api/products/{id}: Update an existing product.
    - DELETE /api/products/{id}: Delete a product by ID.
4. Validation:
    - Add basic input validation to ensure required fields are provided and data constraints are met (e.g., non-negative price).