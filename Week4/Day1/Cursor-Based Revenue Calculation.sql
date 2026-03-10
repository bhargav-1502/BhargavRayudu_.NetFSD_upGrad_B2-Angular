CREATE PROCEDURE sp_CursorRevenueCalculation
AS
BEGIN
    BEGIN TRY

        BEGIN TRANSACTION

        CREATE TABLE #Revenue
        (
            store_id INT,
            order_id INT,
            revenue DECIMAL(12,2)
        )

        DECLARE @order_id INT
        DECLARE @store_id INT
        DECLARE @revenue DECIMAL(12,2)

        DECLARE order_cursor CURSOR FOR
        SELECT order_id, store_id
        FROM orders
        WHERE order_status = 4

        OPEN order_cursor

        FETCH NEXT FROM order_cursor INTO @order_id, @store_id

        WHILE @@FETCH_STATUS = 0
        BEGIN

            SELECT @revenue =
            SUM(quantity * list_price * (1 - discount))
            FROM order_items
            WHERE order_id = @order_id

            INSERT INTO #Revenue
            VALUES (@store_id, @order_id, ISNULL(@revenue,0))

            FETCH NEXT FROM order_cursor INTO @order_id, @store_id
        END

        CLOSE order_cursor
        DEALLOCATE order_cursor

        SELECT 
            store_id,
            SUM(revenue) AS total_store_revenue
        FROM #Revenue
        GROUP BY store_id

        COMMIT TRANSACTION

    END TRY

    BEGIN CATCH
        ROLLBACK TRANSACTION
        PRINT ERROR_MESSAGE()
    END CATCH
END;

EXEC sp_CursorRevenueCalculation