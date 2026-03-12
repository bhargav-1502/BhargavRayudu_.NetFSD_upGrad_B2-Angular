ALTER TRIGGER trg_UpdateStock
ON order_items
AFTER INSERT
AS
BEGIN

    IF EXISTS
    (
        SELECT 1
        FROM stocks s
        JOIN orders o 
            ON s.store_id = o.store_id
        JOIN inserted i 
            ON i.order_id = o.order_id
           AND i.product_id = s.product_id
        WHERE s.quantity < i.quantity
    )
    BEGIN
        RAISERROR('Insufficient Stock Available',16,1);
        ROLLBACK TRANSACTION;
        RETURN;
    END

    UPDATE s
    SET s.quantity = s.quantity - i.quantity
    FROM stocks s
    JOIN orders o 
        ON s.store_id = o.store_id
    JOIN inserted i 
        ON i.order_id = o.order_id
       AND i.product_id = s.product_id;

END;


BEGIN TRY

BEGIN TRANSACTION

INSERT INTO orders
(customer_id, order_status, order_date, required_date, shipped_date, store_id, staff_id)
VALUES
(1, 1, GETDATE(), DATEADD(day, 5, GETDATE()), NULL, 1, 1);

DECLARE @order_id INT
SET @order_id = SCOPE_IDENTITY()

INSERT INTO order_items
(order_id,item_id,product_id,quantity,list_price,discount)
VALUES
(@order_id,1,1,2,379.99,0.10)

COMMIT TRANSACTION

PRINT 'Order placed successfully'

END TRY

BEGIN CATCH

ROLLBACK TRANSACTION

PRINT 'Order Failed - Insufficient Stock'

END CATCH