CREATE TABLE USERS (
    user_id VARCHAR(10) PRIMARY KEY,
    username VARCHAR(50),
    email VARCHAR(100),
    password VARCHAR(50),
    role VARCHAR(50)
);

INSERT INTO USERS VALUES
('U001', 'admin_john', 'john.admin@foodie', 'Admin123', 'Admin'),
('U002', 'manager_amy', 'amy.manager@foodie', 'Manager123', 'Manager'),
('U003', 'chef_david', 'david.chef@foodie', 'Chef123', 'Chef'),
('U004', 'chef_linda', 'linda.chef@foodie', 'Chef123', 'Chef'),
('U005', 'reserv_sara', 'sara.reserv@foodie', 'Reservation123', 'Reservation Coordinator');

CREATE TABLE CUSTOMER (
    customer_id VARCHAR(10) PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    phone VARCHAR(20),
    email VARCHAR(255),
    password VARCHAR(255)
);

INSERT INTO CUSTOMER (customer_id, name, phone, email, password) VALUES
('C001', 'Alice', '+60 12-345 6789', 'alice@email.com', 'Alice123'),
('C002', 'Bob', '+60 16-987 6543', 'bob@email.com', 'Bob123'),
('C003', 'Carol', '+60 11-223 3445', 'carol@email.com', 'Carol123'),
('C004', 'David', '+60 14-556 7788', 'david@email.com', 'David123'),
('C005', 'Emma', '+60 17-333 4444', 'emma@email.com', 'Emma123'),
('C006', 'Frank', '+60 18-444 5555', 'frank@email.com', 'Frank123'),
('C007', 'Grace', '+60 19-555 6666', 'grace@email.com', 'Grace123'),
('C008', 'Henry', '+60 13-666 7777', 'henry@email.com', 'Henry123'),
('C009', 'Ivy', '+60 15-777 8888', 'ivy@email.com', 'Ivy123'),
('C010', 'Jack', '+60 10-888 9999', 'jack@email.com', 'Jack123');