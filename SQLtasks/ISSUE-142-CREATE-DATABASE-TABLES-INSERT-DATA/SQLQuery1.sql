
/* Creating Database with name as Banking */
--Create Database QM_BANKINGS
/* Create Table : DEPOSIT  with columns(Account_Number,Customer_Name,Branch_Name,Transaction_Amount,Transaction_Date)*/

USE QM_BANKING;
GO

CREATE TABLE Deposits(
		Account_Number VARCHAR(5) NOT NULL PRIMARY KEY,
		Customer_Name VARCHAR(20),
		Branch_Name VARCHAR(20),
		Transaction_Amount DECIMAL(8,2),
		Transaction_Date DATE);
			
--SELECT Account_Number,Customer_Name,Branch_Name,Transaction_Amount,FORMAT(CAST(Transaction_Date AS date),'dd-MMM-yy') AS Transaction_Date FROM DEPOSIT
--DELETE  FROM DEPOSIT
--DROP TABLE DEPOSIT

/* CREATE TABLE : BRANCH with columns (Branch_Name , City_Name_Name)*/

CREATE TABLE Branches(
		Branch_Name VARCHAR(20) NOT NULL  UNIQUE,
		Branch_City VARCHAR(20))
			

/* Create table : CUSTOMER with columns(Customer_Name,City_Name_Name)*/

CREATE TABLE Customers(
		Customer_Name VARCHAR(20),
		CityName VARCHAR(20))
			

/* Create table : BORROW with columns(Loan_Number,Customer_Name,BANME,Transaction_Amount) */

CREATE TABLE BorrowTransactions(
		Loan_Number VARCHAR(5) UNIQUE NOT NULL,
		Customer_Name VARCHAR(20) NOT NULL,
		Branch_Name VARCHAR(20) NOT NULL,
		Loan_Amount DECIMAL(8,2),
		CHECK (Loan_Amount > 0)
		)
			
/* Insert data into the DEPOSIT table. */

INSERT INTO Deposits VALUES('106','ANIL','VRCE',1000,CAST('01-MAR-1995' AS DATE)) ;
INSERT INTO Deposits VALUES('107','SUNIL','MGROAD',5000,CAST('04-JAN-1996' AS DATE)) ;
INSERT INTO Deposits VALUES('108','RAHUL','KARBOLBAGH',3500,CAST('17-NOV-1995' AS DATE));
INSERT INTO Deposits VALUES('109','MADHURI','CHANDNI',1200,CAST('17-DEC-1995' AS DATE)) ;
INSERT INTO Deposits VALUES('110','PRAMOD','MGROAD',3000,CAST('27-MAR-1995' AS DATE)) ;
INSERT INTO Deposits VALUES('111','ANIL','KARBOLBAGH',2000,CAST('31-MAR-1996' AS DATE)) ;

/* Insert data into the BRANCH Table */

INSERT INTO Branches VALUES('VRCE','NAGPUR') ,('KARBOLBAGH','DELHI') ,('CHANDNI','DELHI'),('MGROAD','BANGLORE')

/* Insert data into the CUSTOMER Table */

INSERT INTO Customers VALUES('ANIL','CALCUTA'), ('RAHUL','BARODA'),('MADHURI','NAGPUR'),('PRAMOD','NAGPUR') ,('SUNIL','DELHI') 

/* Insert data into the BORROW Table */

INSERT INTO BorrowTransactions(Loan_Number,Customer_Name,Branch_Name,Loan_Amount) VALUES('201','ANIL','VRCE',1000) 
INSERT INTO BorrowTransactions(Loan_Number,Customer_Name,Branch_Name,Loan_Amount) VALUES('206','RAHUL','KARBOLBAGH',5000) 
INSERT INTO BorrowTransactions(Loan_Number,Customer_Name,Branch_Name,Loan_Amount) VALUES('311','SUNIL','MGROAD',3000) 
INSERT INTO BorrowTransactions(Loan_Number,Customer_Name,Branch_Name,Loan_Amount) VALUES('321','MADHURI','CHANDNI',2000) 
INSERT INTO BorrowTransactions(Loan_Number,Customer_Name,Branch_Name,Loan_Amount) VALUES('201','PRAMOD','MGROAD',8000) 
--DROP TABLE BRANCH

/* Alter table constraints of Deposit table */
ALTER TABLE Deposits ALTER COLUMN Customer_Name VARCHAR(50) NOT NULL
ALTER TABLE Deposits ALTER COLUMN Branch_Name VARCHAR(50) NOT NULL
ALTER TABLE Deposits ALTER COLUMN Branch_Name VARCHAR(50) NOT NULL
ALTER TABLE Deposits ALTER COLUMN Transaction_Date DATE NOT NULL 


ALTER TABLE Branches ALTER COLUMN  Branch_Name VARCHAR(50) NOT NULL 
ALTER TABLE Branches ALTER COLUMN Branch_City VARCHAR(50) NOT NULL 

ALTER TABLE Customers ALTER COLUMN Customer_Name VARCHAR(50) NOT NULL 
ALTER TABLE Customers ALTER COLUMN CityName VARCHAR(50) NOT NULL 


--ADD CONSTRAINT AK_Loan_Number UNIQUE (Loan_Number);  
ALTER TABLE BorrowTransactions ALTER COLUMN Loan_Number DATE NOT NULL 
ALTER TABLE BorrowTransactions ALTER COLUMN Customer_Name DATE NOT NULL 
ALTER TABLE BorrowTransactions ALTER COLUMN Branch_Name DATE NOT NULL 
ALTER TABLE BorrowTransactions ALTER COLUMN Loan_Amount DATE NOT NULL 
--BEGIN
--SELECT * FROM Deposits
--END;

--SELECT * FROM BRANCH

--SELECT * FROM CUSTOMER

--SELECT * FROM BORROW

--DROP DATABASE QM_BANKINGS

