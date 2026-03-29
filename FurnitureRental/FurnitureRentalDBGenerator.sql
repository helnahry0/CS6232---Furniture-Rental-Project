/* Check if database already exists and delete it if it does exist*/
IF DB_ID('FurnitureRental') IS NOT NULL
BEGIN
    DROP DATABASE FurnitureRental
END
GO

CREATE DATABASE FurnitureRental
GO

USE FurnitureRental;
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO


CREATE TABLE dbo.Member (
    member_id INT IDENTITY(1,1) PRIMARY KEY,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    sex VARCHAR(20) NOT NULL CHECK (sex IN ('Male', 'Female')),
    dob DATE NOT NULL,
    phone VARCHAR(20) NOT NULL,
    address1 VARCHAR(100) NOT NULL,
    address2 VARCHAR(100) NULL,
    city VARCHAR(50) NOT NULL,
    state CHAR(2) NOT NULL,
    zip VARCHAR(10) NOT NULL
);
GO

/* Employee Table */
CREATE TABLE dbo.Employee
(
    employee_id INT IDENTITY(1,1) PRIMARY KEY,
    role VARCHAR(20) NOT NULL CHECK (role IN ('Admin', 'Employee')),
    dob DATE NOT NULL,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    phone VARCHAR(20) NOT NULL,
    address1 VARCHAR(100) NOT NULL,
    address2 VARCHAR(100) NULL,
    city VARCHAR(50) NOT NULL,
    state CHAR(2) NOT NULL,
    zip VARCHAR(10) NOT NULL,
    username VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(100) NOT NULL
);
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

/* Employee Seeds */
INSERT INTO dbo.Employee
(role, dob, first_name, last_name, phone, address1, address2, city, state, zip, username, password)
VALUES
('Admin', '1995-08-20', 'Jane', 'Smith', '4785552222', '456 Oak Rd', NULL, 'Warner Robins', 'GA', '31088', 'admin1', 'admin123'),
('Employee', '2000-01-01', 'Brendan', 'Warren', '4785551111', '123 Main St', NULL, 'Macon', 'GA', '31210', 'bwarren', 'test123'),
('Employee', '1999-03-10', 'Alex', 'Taylor', '7705553333', '789 Pine Ave', NULL, 'Atlanta', 'GA', '30301', 'ataylor', 'test456');
GO