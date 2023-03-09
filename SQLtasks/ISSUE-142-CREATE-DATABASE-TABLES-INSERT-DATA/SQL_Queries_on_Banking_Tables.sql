Use QM_BANKING
/* select all the records rom Deposits table */
SELECT * FROM Deposits

/* select customer_Name,Account no from Depsoits */
SELECT Customer_Name as Name,Account_Number as AccountNumber FROM Deposits

/* select name of cutomer living in nagpur */
SELECT Customer_Name as Name,CityName as City FROM Customers WHERE CityName='NAGPUR';

/* select customer name who opened account after 17-NOV-95 */
SELECT Customer_Name as Name,Transaction_Date as Date FROM Deposits WHERE Transaction_Date > CAST('17-NOV-95' AS DATE)

/* select account number and amount of the customer havig account opened between 01-12-95 and 01-06-96*/
SELECT Account_Number as AccountNumber,Transaction_Amount as Amount,Transaction_date as Date FROM Deposits WHERE Transaction_date BETWEEN CAST('01-DEC-95' AS DATE) AND CAST('01-jun-96' AS DATE)

/* select all records where customername starts with capital C */
SELECT * FROM Deposits WHERE Customer_Name LIKE 'C%'

/* slect all records from borrow where 2'nd character of customer name is U */
SELECT * FROM BorrowTransactions	WHERE Upper(Customer_Name) Like '_U%'

/* select all records from Deposits where branchName is Chandini or MGROAD */
SELECT * FROM Deposits WHERE Branch_name IN ('CHANDNI','MGROAD')

/* select all records from Deposits where branchName is NOT Chandini or MGROAD */
SELECT * FROM Deposits WHERE Branch_name NOT IN ('CHANDNI' , 'MGROAD')

/* SELECT ALL RECORDS FROM THE TABLE BORROW WHERE AMOUNT IN BETWEEN 2000 AND 3000 */
SELECT * FROM BorrowTransactions WHERE Loan_Amount BETWEEN 2000 AND 3000

/* calculate TA(10% of Loan_amount),Da(20% of Loan_amount) and Total of each from Borrow table also projectCustomer_Name and Amount*/
SELECT Customer_Name,Loan_Amount, (0.1 * Loan_Amount) as TA, (0.2 * Loan_Amount) as DA , ((0.1 * Loan_Amount) + (0.2 * Loan_Amount)) as Total from BorrowTransactions