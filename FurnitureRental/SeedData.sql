USE FurnitureRental;
GO

/* Member Seeds */
INSERT INTO dbo.Member (first_name, last_name, sex, dob, phone, address1, address2, city, state, zip)
VALUES
('Alice', 'Johnson', 'Female', '1998-04-12', '4045551111', '123 Oak St', NULL, 'Atlanta', 'GA', '30301'),
('Alice', 'Smith',   'Female', '1995-08-20', '4045552222', '456 Pine St', 'Apt 2', 'Atlanta', 'GA', '30302'),
('Brian', 'Johnson', 'Male',   '1990-11-05', '7705553333', '789 Maple Ave', NULL, 'Marietta', 'GA', '30060'),
('Cathy', 'Brown',   'Female', '2001-02-14', '6785554444', '321 Cedar Rd', NULL, 'Decatur', 'GA', '30030'),
('David', 'Miller',  'Male',   '1987-07-09', '4705555555', '654 Birch Ln', NULL, 'Roswell', 'GA', '30075');
GO