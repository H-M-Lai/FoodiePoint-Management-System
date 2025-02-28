CREATE TABLE MENU_CATEGORY (
    category_id VARCHAR(10) PRIMARY KEY,
    category_name VARCHAR(50)
);

INSERT INTO MENU_CATEGORY VALUES
('C001', 'Western'),
('C002', 'Chinese'),
('C003', 'Drink'),
('C004', 'Dessert');

CREATE TABLE MENU_FOODITEM (
    item_id VARCHAR(10) PRIMARY KEY,
    category_id VARCHAR(10),
    item_name VARCHAR(100),
    price DECIMAL(5,2),
    description TEXT,
    chef_id VARCHAR(10),
    FOREIGN KEY (category_id) REFERENCES MENU_CATEGORY(category_id),
    FOREIGN KEY (chef_id) REFERENCES USERS(user_id)
);


CREATE TABLE MENU_FoodItem (
    item_id VARCHAR(10) PRIMARY KEY,
    category_id VARCHAR(10),
    item_name VARCHAR(100) NOT NULL,
    price DECIMAL(10,2) NOT NULL,
    description TEXT,
    chef_id VARCHAR(10),
    FOREIGN KEY (category_id) REFERENCES MENU_Category(category_id)
);

INSERT INTO MENU_FoodItem (item_id, category_id, item_name, price, description, chef_id) VALUES
('M001', 'C001', 'Steak', 25.99, 'Grilled beef steak', 'U003'),
('M002', 'C001', 'Pasta', 15.99, 'Creamy Alfredo pasta', 'U003'),
('M003', 'C001', 'Burger', 12.99, 'Cheeseburger with fries', 'U003'),
('M004', 'C001', 'Kung Pao Chicken', 13.99, 'Spicy stir-fried chicken', 'U004'),
('M005', 'C002', 'Sweet and Sour Pork', 12.99, 'Pork with sweet sauce', 'U004'),
('M006', 'C002', 'Fried Rice', 10.99, 'Egg and vegetable fried rice', 'U003'),
('M007', 'C003', 'Coffee', 4.99, 'Fresh brewed coffee', 'U004'),
('M008', 'C003', 'Orange Juice', 3.99, 'Fresh squeezed orange juice', 'U003'),
('M009', 'C004', 'Cheesecake', 6.99, 'Creamy cheesecake', 'U004'),
('M010', 'C004', 'Ice Cream', 4.99, 'Vanilla ice cream', 'U003');

UPDATE MENU_FoodItem
SET chef_id = 'U003'
WHERE category_id IN ('C001', 'C002');

-- 更新 Drink (C003) 和 Dessert (C004) 的菜品，让它们由 U004 负责
UPDATE MENU_FoodItem
SET chef_id = 'U004'
WHERE category_id IN ('C003', 'C004');