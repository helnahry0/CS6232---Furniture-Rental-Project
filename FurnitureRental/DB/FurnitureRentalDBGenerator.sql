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

/* Member Table */
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
    zip VARCHAR(5) NOT NULL
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
    zip VARCHAR(5) NOT NULL,
    username VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(100) NOT NULL
);
GO

/* Furniture Category */
CREATE TABLE dbo.FurnitureCategory
(
    category_id INT IDENTITY(1,1) PRIMARY KEY,
    category_name VARCHAR(50) NOT NULL UNIQUE
);
GO

/*Furniture Style */
CREATE TABLE dbo.FurnitureStyle
(
    style_id INT IDENTITY(1,1) PRIMARY KEY,
    style_name VARCHAR(50) NOT NULL UNIQUE
);
GO

/* Furniture */
CREATE TABLE dbo.Furniture
(
    furniture_id INT IDENTITY(1,1) PRIMARY KEY,
    category_id INT NOT NULL,
    style_id INT NOT NULL,
    furniture_name VARCHAR(100) NOT NULL,
    description VARCHAR(255) NULL,
    daily_rental_rate DECIMAL(10,2) NOT NULL CHECK (daily_rental_rate >= 0),
    quantity_on_hand INT NOT NULL CHECK (quantity_on_hand >= 0),

    CONSTRAINT FK_Furniture_Category
        FOREIGN KEY (category_id) REFERENCES dbo.FurnitureCategory(category_id),

    CONSTRAINT FK_Furniture_Style
        FOREIGN KEY (style_id) REFERENCES dbo.FurnitureStyle(style_id)
);
GO

/* Rental */
CREATE TABLE dbo.RentalTransaction
(
    rental_id INT IDENTITY(1,1) PRIMARY KEY,
    member_id INT NOT NULL,
    employee_id INT NOT NULL,
    rental_date DATE NOT NULL,
    due_date DATE NOT NULL,

    CONSTRAINT FK_RentalTransaction_Member
        FOREIGN KEY (member_id) REFERENCES dbo.Member(member_id),

    CONSTRAINT FK_RentalTransaction_Employee
        FOREIGN KEY (employee_id) REFERENCES dbo.Employee(employee_id)
);
GO

/* Rental Detail */
CREATE TABLE dbo.RentalDetail
(
    rental_id INT NOT NULL,
    furniture_id INT NOT NULL,
    quantity_rented INT NOT NULL CHECK (quantity_rented > 0),

    CONSTRAINT PK_RentalDetail
        PRIMARY KEY (rental_id, furniture_id),

    CONSTRAINT FK_RentalDetail_RentalTransaction
        FOREIGN KEY (rental_id) REFERENCES dbo.RentalTransaction(rental_id),

    CONSTRAINT FK_RentalDetail_Furniture
        FOREIGN KEY (furniture_id) REFERENCES dbo.Furniture(furniture_id)
);
GO

/* Return Transaction */
CREATE TABLE dbo.ReturnTransaction
(
    return_id INT IDENTITY(1,1) PRIMARY KEY,
    member_id INT NOT NULL,
    employee_id INT NOT NULL,
    return_date DATE NOT NULL,

    CONSTRAINT FK_ReturnTransaction_Member
        FOREIGN KEY (member_id) REFERENCES dbo.Member(member_id),

    CONSTRAINT FK_ReturnTransaction_Employee
        FOREIGN KEY (employee_id) REFERENCES dbo.Employee(employee_id)
);
GO

/* Return Details */
CREATE TABLE dbo.ReturnDetail
(
    return_id INT NOT NULL,
    rental_id INT NOT NULL,
    furniture_id INT NOT NULL,
    quantity_returned INT NOT NULL CHECK (quantity_returned > 0),
    fine_or_refund_amount DECIMAL(10,2) NOT NULL DEFAULT 0,

    CONSTRAINT PK_ReturnDetail
        PRIMARY KEY (return_id, rental_id, furniture_id),

    CONSTRAINT FK_ReturnDetail_ReturnTransaction
        FOREIGN KEY (return_id) REFERENCES dbo.ReturnTransaction(return_id),

    CONSTRAINT FK_ReturnDetail_RentalDetail
        FOREIGN KEY (rental_id, furniture_id)
        REFERENCES dbo.RentalDetail(rental_id, furniture_id)
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

/* Furniture Category Seeds */
INSERT INTO dbo.FurnitureCategory (category_name)
VALUES
('Bed'),
('Desk'),
('Chair'),
('Table'),
('Sofa');
GO

/* Furniture Style Seeds */
INSERT INTO dbo.FurnitureStyle (style_name)
VALUES
('Traditional'),
('Contemporary'),
('Modern'),
('Rustic');
GO

/* Furniture Seeds */
INSERT INTO dbo.Furniture
(category_id, style_id, furniture_name, description, daily_rental_rate, quantity_on_hand)
VALUES
(1, 3, 'Queen Bed', 'Modern queen-size bed frame', 25.00, 4),
(2, 2, 'Office Desk', 'Contemporary office desk', 18.00, 6),
(3, 4, 'Dining Chair', 'Rustic wooden dining chair', 8.00, 20),
(4, 1, 'Coffee Table', 'Traditional coffee table', 12.00, 5),
(5, 2, 'Sectional Sofa', 'Contemporary sectional sofa', 30.00, 3);
GO

/*Temporary Rental Transaction Seeds */
INSERT INTO dbo.RentalTransaction
(member_id, employee_id, rental_date, due_date)
VALUES
(1, 2, '2026-04-01', '2026-04-07'),
(1, 3, '2026-04-10', '2026-04-15'),
(2, 2, '2026-04-12', '2026-04-18');
GO

/* Temporary Rental Detail Seeds */
INSERT INTO dbo.RentalDetail
(rental_id, furniture_id, quantity_rented)
VALUES
(1, 1, 1),
(1, 3, 2),
(2, 2, 1),
(2, 4, 1),
(2, 5, 2),
(3, 3, 4);
GO