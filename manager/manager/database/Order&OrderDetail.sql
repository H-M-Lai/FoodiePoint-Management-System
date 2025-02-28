CREATE TABLE ORDER_TABLE (
    order_id VARCHAR(10) PRIMARY KEY,
    customer_id VARCHAR(10) NOT NULL,
    order_date DATE NOT NULL,
    total_price DECIMAL(10,2) NOT NULL,
    status VARCHAR(20) NOT NULL
);

INSERT INTO ORDER_TABLE (order_id, customer_id, order_date, total_price, status) VALUES
('O001', 'U005', '2025-02-26', 45.97, 'Completed'),
('O002', 'U005', '2025-02-25', 22.98, 'In Progress'),
('O003', 'U009', '2025-02-24', 18.99, 'Completed'),
('O004', 'U008', '2025-02-23', 32.50, 'In Progress'),
('O005', 'U010', '2025-02-22', 4.99, 'Completed'),
('O006', 'U009', '2025-02-21', 33.97, 'Completed'),
('O007', 'U005', '2025-02-20', 19.99, 'In Progress'),
('O008', 'U009', '2025-02-19', 37.75, 'Completed'),
('O009', 'U008', '2025-02-18', 29.99, 'Completed'),
('O010', 'U009', '2025-02-17', 23.99, 'In Progress');

CREATE TABLE ORDER_DETAIL (
    order_detail_id VARCHAR(10) PRIMARY KEY,
    order_id VARCHAR(10),
    item_id VARCHAR(10),
    quantity INT NOT NULL,
    subtotal_price DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (order_id) REFERENCES ORDER_TABLE(order_id),
    FOREIGN KEY (item_id) REFERENCES MENU_FoodItem(item_id)
);

INSERT INTO ORDER_DETAIL (order_detail_id, order_id, item_id, quantity, subtotal_price) VALUES
('OD001', 'O001', 'M001', 1, 25.99),
('OD002', 'O001', 'M006', 1, 13.99),
('OD003', 'O001', 'M002', 1, 15.99),
('OD004', 'O002', 'M003', 1, 12.99),
('OD005', 'O002', 'M004', 1, 18.99),
('OD006', 'O003', 'M005', 2, 32.50),
('OD007', 'O004', 'M007', 1, 4.99),
('OD008', 'O005', 'M001', 1, 25.99),
('OD009', 'O006', 'M008', 2, 7.89),
('OD010', 'O007', 'M009', 1, 19.99),
('OD011', 'O008', 'M002', 2, 37.75),
('OD012', 'O009', 'M006', 1, 29.99),
('OD013', 'O010', 'M007', 1, 4.99);

