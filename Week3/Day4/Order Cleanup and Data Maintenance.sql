CREATE TABLE archived_orders
(
    order_id INT,
    customer_id INT,
    order_status INT,
    order_date DATE,
    required_date DATE,
    shipped_date DATE,
    store_id INT,
    staff_id INT
);

INSERT INTO archived_orders
SELECT *
FROM orders
WHERE order_status = 3
AND order_date < DATEADD(YEAR, -1, GETDATE());

DELETE FROM orders
WHERE order_status = 3
AND order_date < DATEADD(YEAR, -1, GETDATE());

SELECT customer_id
FROM orders o1
GROUP BY customer_id
HAVING COUNT(*) =
(
    SELECT COUNT(*)
    FROM orders o2
    WHERE o2.customer_id = o1.customer_id
    AND o2.order_status = 4
);

SELECT 
    order_id,
    order_date,
    shipped_date,
    DATEDIFF(DAY, order_date, shipped_date) AS Processing_Delay_Days
FROM orders;

SELECT 
    order_id,
    order_date,
    required_date,
    shipped_date,
    CASE 
        WHEN shipped_date > required_date THEN 'Delayed'
        ELSE 'On Time'
    END AS Delivery_Status
FROM orders;