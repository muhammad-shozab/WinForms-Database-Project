select*from users;

INSERT INTO users (username, password, role, status) VALUES('testing1', 'admin123', 'Cashier', 'Active')

select * from categories;


CREATE TABLE orders
(
    id INT PRIMARY KEY IDENTITY(1,1),
    customer_id INT NULL,
    prod_id VARCHAR(MAX) NULL,
    prod_name VARCHAR(MAX) NULL,
    category VARCHAR(MAX) NULL,
    qty INT NULL,
    orig_price FLOAT NULL,
    total_price FLOAT NULL,
    order_date DATE NULL
)
ALTER TABLE orders
ADD customer_id INT NULL

SELECT * FROM orders

CREATE TABLE customers (
    id INT PRIMARY KEY IDENTITY(1,1),
    customer_id INT NULL,
    total_price DECIMAL(10,2) NULL,  
    amount DECIMAL(10,2) NULL,
    change DECIMAL(10,2) NULL,
    order_date DATE NULL
);

SELECT * FROM customers;

ALTER TABLE customers
DROP COLUMN prod_id

SELECT COUNT(id) FROM customers
