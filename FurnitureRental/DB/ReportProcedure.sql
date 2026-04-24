CREATE OR ALTER PROCEDURE dbo.getMostPopularFurnitureDuringDates
    @StartDate DATE,
    @EndDate DATE
AS
BEGIN
    SET NOCOUNT ON;

    WITH RentalBase AS
    (
        SELECT
            rt.rental_id,
            rt.member_id,
            rt.rental_date,
            rd.furniture_id,
            f.furniture_name,
            fc.category_name,
            DATEDIFF(YEAR, m.dob, rt.rental_date) AS renter_age
        FROM dbo.RentalTransaction rt
        INNER JOIN dbo.RentalDetail rd
            ON rt.rental_id = rd.rental_id
        INNER JOIN dbo.Furniture f
            ON rd.furniture_id = f.furniture_id
        INNER JOIN dbo.FurnitureCategory fc
            ON f.category_id = fc.category_id
        INNER JOIN dbo.Member m
            ON rt.member_id = m.member_id
        WHERE CAST(rt.rental_date AS DATE) BETWEEN @StartDate AND @EndDate
    ),
    QualifiedFurniture AS
    (
        SELECT
            furniture_id,
            category_name,
            furniture_name,
            COUNT(DISTINCT rental_id) AS rental_transaction_count
        FROM RentalBase
        GROUP BY furniture_id, category_name, furniture_name
        HAVING COUNT(DISTINCT rental_id) >= 2
    ),
    TotalTransactions AS
    (
        SELECT COUNT(DISTINCT rental_id) AS total_rental_transactions
        FROM RentalBase
    )
    SELECT
        qf.furniture_id,
        qf.category_name,
        qf.furniture_name,
        qf.rental_transaction_count,
        tt.total_rental_transactions,
        CAST(qf.rental_transaction_count * 100.0 / NULLIF(tt.total_rental_transactions, 0) AS DECIMAL(5,2)) AS rental_percentage,
        CAST(
            SUM(CASE WHEN rb.renter_age BETWEEN 18 AND 29 THEN 1 ELSE 0 END) * 100.0
            / NULLIF(COUNT(*), 0)
            AS DECIMAL(5,2)
        ) AS age18to29_percentage,
        CAST(
            SUM(CASE WHEN rb.renter_age NOT BETWEEN 18 AND 29 THEN 1 ELSE 0 END) * 100.0
            / NULLIF(COUNT(*), 0)
            AS DECIMAL(5,2)
        ) AS outside18to29_percentage
    FROM QualifiedFurniture qf
    INNER JOIN RentalBase rb
        ON qf.furniture_id = rb.furniture_id
    CROSS JOIN TotalTransactions tt
    GROUP BY
        qf.furniture_id,
        qf.category_name,
        qf.furniture_name,
        qf.rental_transaction_count,
        tt.total_rental_transactions
    ORDER BY
        qf.rental_transaction_count DESC,
        qf.furniture_id DESC;
END;
GO