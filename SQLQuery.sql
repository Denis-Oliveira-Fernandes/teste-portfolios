BEGIN   
    CREATE TABLE dbo.PORTFOLIOS
    (
        MarketValue float(50) NOT NULL, 
        FinancialInstrumentType NVARCHAR(50) NOT NULL, /*Type is a SQL reserved keyword*/
    )

	INSERT INTO PORTFOLIOS
				( MarketValue, FinancialInstrumentType )
	VALUES
				(800000, 'Stock'), 
				(1500000, 'Bond'), 
				(6000000, 'Derivative'), 
				(300000, 'Stock')

	SELECT CASE 
		WHEN MarketValue < 1000000 THEN 'Low Value' 
		WHEN MarketValue >= 1000000 and MarketValue <= 5000000 THEN 'Medium Value'  
		WHEN MarketValue > 5000000 THEN 'High Value'
	END
	FROM PORTFOLIOS;
END