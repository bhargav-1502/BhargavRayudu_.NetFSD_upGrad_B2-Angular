CREATE DATABASE EcommDb;

USE EcommDb;

CREATE TABLE categories (
    category_id INT PRIMARY KEY,
    category_name VARCHAR(100)
);

CREATE TABLE brands (
    brand_id INT PRIMARY KEY,
    brand_name VARCHAR(100)
);

CREATE TABLE products (
    product_id INT PRIMARY KEY,
    product_name VARCHAR(100),
    brand_id INT,
    category_id INT,
    model_year INT,
    list_price DECIMAL(10,2),
    FOREIGN KEY (brand_id) REFERENCES brands(brand_id),
    FOREIGN KEY (category_id) REFERENCES categories(category_id)
);

CREATE TABLE customers (
    customer_id INT PRIMARY KEY,
    first_name VARCHAR(50),
    last_name VARCHAR(50),
    phone VARCHAR(20),
    email VARCHAR(100),
    city VARCHAR(50)
);

CREATE TABLE stores (
    store_id INT PRIMARY KEY,
    store_name VARCHAR(100),
    city VARCHAR(50)
);

INSERT INTO categories VALUES
(1,'Sports Bikes'),
(2,'Hybrid Bikes'),
(3,'Electric Scooters'),
(4,'Bike Accessories'),
(5,'Touring Bikes');

INSERT INTO brands VALUES
(1,'Hero'),
(2,'Yamaha'),
(3,'Honda'),
(4,'Suzuki'),
(5,'Bajaj');

INSERT INTO products VALUES
(1,'Hero Sprint Pro',1,1,2023,45000),
(2,'Yamaha Street Ride',2,2,2022,52000),
(3,'Honda E-Scooter',3,3,2024,98000),
(4,'Suzuki Helmet Kit',4,4,2023,3500),
(5,'Bajaj Tour Master',5,5,2021,67000);

INSERT INTO customers VALUES
(1,'Kiran','Reddy','9123456780','kiran@gmail.com','Chennai'),
(2,'Meena','Nair','9123456781','meena@gmail.com','Bangalore'),
(3,'Suresh','Patel','9123456782','suresh@gmail.com','Ahmedabad'),
(4,'Priya','Das','9123456783','priya@gmail.com','Kolkata'),
(5,'Arjun','Mehta','9123456784','arjun@gmail.com','Chennai');

INSERT INTO stores VALUES
(1,'Metro Bike Store','Chennai'),
(2,'Speed Wheels','Bangalore'),
(3,'Urban Riders','Ahmedabad'),
(4,'Cycle Hub','Kolkata'),
(5,'Ride India','Pune');

SELECT 
    p.product_name,
    b.brand_name,
    c.category_name,
    p.model_year,
    p.list_price
FROM products p
JOIN brands b
ON p.brand_id = b.brand_id
JOIN categories c
ON p.category_id = c.category_id;

SELECT * FROM customers WHERE city = 'Chennai';

SELECT 
    c.category_name,
    COUNT(p.product_id) AS total_products
FROM categories c
LEFT JOIN products p
ON c.category_id = p.category_id
GROUP BY c.category_name;