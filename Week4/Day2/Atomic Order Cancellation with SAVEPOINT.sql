CREATE PROCEDURE CancelOrder
    @order_id INT
AS
BEGIN

    BEGIN TRY

        BEGIN TRANSACTION;

        SAVE TRANSACTION SavePoint_RestoreStock;

        UPDATE s
        SET s.quantity = s.quantity + oi.quantity
        FROM stocks s
        JOIN orders o ON s.store_id = o.store_id
        JOIN order_items oi ON oi.order_id = o.order_id
        AND oi.product_id = s.product_id
        WHERE o.order_id = @order_id;

        UPDATE orders
        SET order_status = 3
        WHERE order_id = @order_id;

        COMMIT TRANSACTION;

        PRINT 'Order cancelled successfully';

    END TRY

    BEGIN CATCH

        ROLLBACK TRANSACTION SavePoint_RestoreStock;

        PRINT 'Order cancellation failed';
        PRINT ERROR_MESSAGE();

    END CATCH

END;