CREATE TABLE Feedback (
    feedback_id VARCHAR(10) PRIMARY KEY,
    customer_id VARCHAR(10) NOT NULL,
    order_id VARCHAR(10) NOT NULL,
    message TEXT NOT NULL
);

INSERT INTO Feedback (feedback_id, customer_id, order_id, message) VALUES
('F001', 'C001', 'O001', 'The steak was amazing!'),
('F002', 'C002', 'O002', 'The noodles were too salty.'),
('F003', 'C003', 'O003', 'The service was a bit slow.'),
('F004', 'C004', 'O004', 'The drink was just okay.'),
('F005', 'C005', 'O005', 'The food took too long.');

CREATE TABLE Response (
    response_id VARCHAR(10) PRIMARY KEY,
    feedback_id VARCHAR(10) NOT NULL,
    response TEXT NOT NULL,
    FOREIGN KEY (feedback_id) REFERENCES Feedback(feedback_id)
);

INSERT INTO Response (response_id, feedback_id, response) VALUES
('R001', 'F001', 'Thank you for your feedback!'),
('R002', 'F002', 'We will adjust the recipe.'),
('R003', 'F003', 'We will work on improving it.'),
('R004', 'F004', 'Thank you for your input!'),
('R005', 'F005', 'We will speed up the process.');