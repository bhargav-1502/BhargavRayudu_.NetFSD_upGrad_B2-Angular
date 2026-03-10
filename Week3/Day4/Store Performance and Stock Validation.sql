SELECT 
    s.store_name,
    p.product_name,
    sales.total_quantity_sold,
    sales.total_revenue
FROM
(
    SELECT 
        o.store_id,
        oi.product_id,
        SUM(oi.quantity) AS total_quantity_sold,
        SUM((oi.quantity * oi.list_price) - oi.discount) AS total_revenue
    FROM orders o
    JOIN order_items oi ON o.order_id = oi.order_id
    GROUP BY o.store_id,oi.product_id
) AS sales
JOIN stores s ON sales.store_id = s.store_id
JOIN products p ON sales.product_id = p.product_id
ORDER BY s.store_name,p.product_name;


SELECT DISTINCT o.store_id, oi.product_id
FROM orders o
JOIN order_items oi ON o.order_id = oi.order_id

INTERSECT

SELECT store_id, product_id
FROM stocks;

SELECT DISTINCT o.store_id, oi.product_id
FROM orders o
JOIN order_items oi ON o.order_id = oi.order_id

EXCEPT

SELECT store_id, product_id
FROM stocks
WHERE quantity > 0;


UPDATE stocks
SET quantity = 0
WHERE product_id IN
(
    SELECT product_id
    FROM products
    WHERE model_year < 2017
);