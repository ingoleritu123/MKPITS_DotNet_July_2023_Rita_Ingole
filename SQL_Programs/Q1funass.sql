CREATE FUNCTION dbo.CalculateTax(@income DECIMAL(19, 2))
RETURNS DECIMAL(18, 2)
AS
BEGIN
    DECLARE @taxRate DECIMAL(5, 2);
    DECLARE @tax DECIMAL(19, 2);

   
    SET @taxRate = 0.15;

   
    SET @tax = @income * @taxRate;

   
    RETURN @tax;
END;

select dbo.CalculateTax(20000) as CalculateTax

drop function CalculateTax