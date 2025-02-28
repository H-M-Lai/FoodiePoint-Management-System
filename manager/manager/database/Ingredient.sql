CREATE TABLE INGREDIENT (
    ingredient_id VARCHAR(10) PRIMARY KEY,
    ingredient_name VARCHAR(100) NOT NULL,
    quantity_available INT NOT NULL,
    unit VARCHAR(10) NOT NULL
);

INSERT INTO INGREDIENT (ingredient_id, ingredient_name, quantity_available, unit) VALUES
('I001', 'Beef', 50, 'kg'),
('I002', 'Chicken', 40, 'kg'),
('I003', 'Pork', 30, 'kg'),
('I004', 'Rice', 100, 'kg'),
('I005', 'Noodles', 60, 'kg'),
('I006', 'Vegetables', 80, 'kg'),
('I007', 'Cheese', 20, 'kg'),
('I008', 'Flour', 30, 'kg'),
('I009', 'Coffee Beans', 25, 'kg'),
('I010', 'Milk', 50, 'L'),
('I011', 'Sugar', 40, 'kg'),
('I012', 'Eggs', 100, 'pcs');