Use RMS

SELECT [Name], 
       Details, 
       CategoryID,
	   p.Price,
	   ROW_NUMBER()OVER(ORDER BY FoodItem.CategoryID) RowNumber
       FROM FoodItem
	Join Prices p on FoodItem.ItemID= p.ItemId

SELECT [Name], 
       Details, 
       CategoryID,
	   p.Price,
	   DENSE_RANK() OVER(Partition by FoodItem.CategoryID ORDER BY p.Price desc) [Rank]
       FROM FoodItem
	   Join Prices p on FoodItem.ItemID= p.ItemId 
	   order by FoodItem.CategoryID desc 


SELECT
	FoodItem.Name,
    FoodItem.CategoryID,
	p.Price
FROM
	FoodItem
join Prices p on p.ItemId=FoodItem.ItemID 
GROUP BY
    GROUPING SETS (
        (FoodItem.CategoryID, p.Price,FoodItem.Name),
        ()
);

SELECT
    FoodItem.CategoryID,
	p.Price
FROM
	FoodItem
join Prices p on p.ItemId=FoodItem.ItemID 
    GROUP BY ROLLUP (FoodItem.CategoryID, p.Price)

SELECT
  SUM(payment_amount),
  YEAR(payment_date) AS 'Payment Year',
  store_id AS 'Store'
FROM payment
GROUP BY GROUPING SETS (YEAR(payment_date), store_id)
--ORDER BY YEAR(payment_date), store_id;

SELECT
  SUM(payment_amount),
  YEAR(payment_date) AS 'Payment Year',
  store_id AS 'Store'
FROM payment
GROUP BY ROLLUP (YEAR(payment_date), store_id)
ORDER BY YEAR(payment_date), store_id;

SELECT
  SUM(payment_amount),
  YEAR(payment_date) AS 'Payment Year',
  store_id AS 'Store'
FROM payment
GROUP BY CUBE (YEAR(payment_date), store_id)
ORDER BY YEAR(payment_date), store_id


