select* from catagories;

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

SELECT * FROM orders

