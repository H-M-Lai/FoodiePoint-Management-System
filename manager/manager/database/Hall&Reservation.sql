CREATE TABLE HALLS (
    hall_id VARCHAR(10) PRIMARY KEY,
    hall_name VARCHAR(100) NOT NULL,
    capacity INT NOT NULL,
    quantity INT NOT NULL
);

INSERT INTO HALLS (hall_id, hall_name, capacity, quantity) VALUES
('H001', 'Crystal Hall', 150, 1),
('H002', 'Sapphire Room', 100, 1),
('H003', 'Emerald Lounge', 50, 1),
('H004', 'Cozy Corner', 20, 2);

CREATE TABLE RESERVATION (
    reservation_id VARCHAR(10) PRIMARY KEY,
    customer_id VARCHAR(10) NOT NULL,
    hall_id VARCHAR(10) NOT NULL,
    reservation_date DATE NOT NULL,
    reservation_time TIME NOT NULL,
    special_request VARCHAR(255),
    status VARCHAR(50) NOT NULL,
    FOREIGN KEY (hall_id) REFERENCES HALLS(hall_id)
);

INSERT INTO RESERVATION (reservation_id, customer_id, hall_id, reservation_date, reservation_time, special_request, status) VALUES
('R001', 'C001', 'H001', '2025-12-05', '18:00', 'Birthday party', 'Confirmed'),
('R002', 'C002', 'H002', '2025-12-12', '12:30', 'Vegetarian menu', 'Pending'),
('R003', 'C003', 'H003', '2025-08-02', '19:00', 'Anniversary', 'Completed'),
('R004', 'C004', 'H004', '2025-02-20', '14:00', 'No request', 'Canceled'),
('R005', 'C005', 'H001', '2025-03-15', '20:00', 'Window seat', 'Confirmed'),
('R006', 'C006', 'H002', '2025-03-25', '11:00', 'Company meeting', 'Confirmed'),
('R007', 'C007', 'H003', '2025-04-10', '15:30', 'Vegan options', 'Pending'),
('R008', 'C008', 'H004', '2025-04-18', '17:45', 'Wedding proposal', 'Completed'),
('R009', 'C009', 'H003', '2025-05-05', '20:00', 'No request', 'Canceled'),
('R010', 'C010', 'H001', '2025-05-22', '13:15', 'High tea event', 'Confirmed');