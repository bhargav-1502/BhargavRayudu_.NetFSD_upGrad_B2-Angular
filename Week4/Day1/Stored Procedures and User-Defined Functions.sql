CREATE PROCEDURE sp_TotalSalesPerStore
AS
BEGIN
    SELECT 
        s.store_id,
        s.store_name,
        SUM((oi.quantity * oi.list_price) - oi.discount) AS Total_Sales
    FROM orders o
    JOIN order_items oi ON o.order_id = oi.order_id
    JOIN stores s ON o.store_id = s.store_id
    GROUP BY s.store_id, s.store_name;
END;

EXEC sp_TotalSalesPerStore;


CREATE PROCEDURE sp_GetOrdersByDateRange
    @StartDate DATE,
    @EndDate DATE
AS
BEGIN
    SELECT *
    FROM orders
    WHERE order_date BETWEEN @StartDate AND @EndDate;
END;

EXEC sp_GetOrdersByDateRange '2017-01-01','2018-12-31';

CREATE FUNCTION fn_CalcDiscountPrice
(
    @price DECIMAL(10,2),
    @quantity INT,
    @discount DECIMAL(10,2)
)
RETURNS DECIMAL(10,2)
AS
BEGIN
    RETURN (@price * @quantity) * (1 - ISNULL(@discount,0) / 100);
END;

SELECT dbo.fn_CalcDiscountPrice(100,2,10) AS TotalPrice;

CREATE FUNCTION fn_Top5SellingProducts()
RETURNS TABLE
AS
RETURN
(
    SELECT TOP 5
        p.product_name,
        SUM(oi.quantity) AS Total_Sold
    FROM order_items oi
    JOIN products p ON oi.product_id = p.product_id
    GROUP BY p.product_name
    ORDER BY Total_Sold DESC
);

SELECT * FROM fn_Top5SellingProducts();