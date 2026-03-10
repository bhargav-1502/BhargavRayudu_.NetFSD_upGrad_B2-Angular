CREATE TRIGGER trg_ValidateOrderStatus
ON orders
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY

        IF EXISTS (
            SELECT 1
            FROM inserted
            WHERE order_status = 4
            AND shipped_date IS NULL
        )
        BEGIN
            ROLLBACK TRANSACTION;

            THROW 50002, 
            'Cannot mark order as Completed without shipped date.', 
            1;
        END

    END TRY

    BEGIN CATCH
        ROLLBACK TRANSACTION;
        PRINT ERROR_MESSAGE();
    END CATCH
END;

UPDATE orders
SET order_status = 4
WHERE order_id = 1;