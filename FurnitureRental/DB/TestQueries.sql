USE FurnitureRental
GO

/* Member Search Test Queries */

/* Search by Member ID */
DECLARE @MemberId INT = 1;

SELECT 
    member_id,
    first_name,
    last_name,
    sex,
    dob,
    phone,
    address1,
    address2,
    city,
    state,
    zip
FROM Member
WHERE member_id = @MemberId;
GO

/* Search by Phone */
DECLARE @Phone VARCHAR(10) = '4045551111';

SELECT 
    member_id,
    first_name,
    last_name,
    sex,
    dob,
    phone,
    address1,
    address2,
    city,
    state,
    zip
FROM Member
WHERE phone = @Phone;
GO

/* Search by First and Last Name */
DECLARE @FirstName VARCHAR(50) = 'Alice';
DECLARE @LastName VARCHAR(50) = 'Johnson';

SELECT 
    member_id,
    first_name,
    last_name,
    sex,
    dob,
    phone,
    address1,
    address2,
    city,
    state,
    zip
FROM Member
WHERE first_name = @FirstName
  AND last_name = @LastName;
  GO