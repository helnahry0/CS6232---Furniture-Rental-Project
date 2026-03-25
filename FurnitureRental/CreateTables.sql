USE FurnitureRental;
GO

/* Member Table */
IF OBJECT_ID('dbo.Member', 'U') IS NOT NULL
    DROP TABLE dbo.Member;
GO

CREATE TABLE dbo.Member (
    member_id INT IDENTITY(1,1) PRIMARY KEY,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    sex VARCHAR(20) NOT NULL,
    dob DATE NOT NULL,
    phone VARCHAR(10) NOT NULL,
    address1 VARCHAR(100) NOT NULL,
    address2 VARCHAR(100) NULL,
    city VARCHAR(50) NOT NULL,
    state CHAR(2) NOT NULL,
    zip VARCHAR(10) NOT NULL
);
GO