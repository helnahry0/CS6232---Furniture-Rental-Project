USE FurnitureRental;
GO

/* Retrieve rentals for 1 member */
SELECT
    rental_id,
    member_id,
    employee_id,
    rental_date,
    due_date
FROM dbo.RentalTransaction
WHERE member_id = 1
ORDER BY rental_date DESC, rental_id DESC;

/* Retrieve specific rental items from a rental */
SELECT
    rd.rental_id,
    rd.furniture_id,
    f.furniture_name,
    rd.quantity_rented,
    f.daily_rental_rate
FROM dbo.RentalDetail rd
JOIN dbo.Furniture f
    ON rd.furniture_id = f.furniture_id
WHERE rd.rental_id = 1
ORDER BY rd.furniture_id;