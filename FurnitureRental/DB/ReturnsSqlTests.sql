USE FurnitureRental;
GO

SELECT
    rt.rental_id,
    rd.furniture_id,
    f.furniture_name,
    rd.quantity_rented,
    rt.rental_date,
    rt.due_date,
    f.daily_rental_rate
FROM dbo.RentalTransaction rt
JOIN dbo.RentalDetail rd
    ON rt.rental_id = rd.rental_id
JOIN dbo.Furniture f
    ON rd.furniture_id = f.furniture_id
WHERE rt.member_id = 1
ORDER BY rt.rental_id, rd.furniture_id;

USE FurnitureRental;
GO

SELECT
    rtd.rental_id,
    rtd.furniture_id,
    SUM(rtd.quantity_returned) AS total_returned
FROM dbo.ReturnDetail rtd
GROUP BY
    rtd.rental_id,
    rtd.furniture_id
ORDER BY
    rtd.rental_id,
    rtd.furniture_id;

    USE FurnitureRental;
GO

SELECT
    rt.rental_id,
    rd.furniture_id,
    f.furniture_name,
    rd.quantity_rented,
    ISNULL(SUM(rtd.quantity_returned), 0) AS quantity_already_returned,
    rd.quantity_rented - ISNULL(SUM(rtd.quantity_returned), 0) AS quantity_remaining,
    rt.rental_date,
    rt.due_date,
    f.daily_rental_rate
FROM dbo.RentalTransaction rt
JOIN dbo.RentalDetail rd
    ON rt.rental_id = rd.rental_id
JOIN dbo.Furniture f
    ON rd.furniture_id = f.furniture_id
LEFT JOIN dbo.ReturnDetail rtd
    ON rd.rental_id = rtd.rental_id
   AND rd.furniture_id = rtd.furniture_id
WHERE rt.member_id = 1
GROUP BY
    rt.rental_id,
    rd.furniture_id,
    f.furniture_name,
    rd.quantity_rented,
    rt.rental_date,
    rt.due_date,
    f.daily_rental_rate
HAVING rd.quantity_rented - ISNULL(SUM(rtd.quantity_returned), 0) > 0
ORDER BY rt.rental_date DESC, rt.rental_id DESC, rd.furniture_id;