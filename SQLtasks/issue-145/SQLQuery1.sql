--CREATE DATABASE ORG;
--SHOW DATABASES;
USE ORG;
go

CREATE TABLE Worker (
    WORKER_ID INT NOT NULL PRIMARY KEY identity(3030,1),
    FIRST_NAME CHAR(25),
    LAST_NAME CHAR(25),
    SALARY Decimal(8,2),
    JOINING_DATE DATETIME,
    DEPARTMENT CHAR(25)
);
drop table Title
INSERT INTO Worker( FIRST_NAME, LAST_NAME, SALARY, JOINING_DATE, DEPARTMENT) VALUES
        ('Monika', 'Arora', 100000,convert( DateTime,'14-02-2020 ', 105 ), 'HR'),
        ('Niharika', 'Verma', 80000, convert(DateTime,'14-06-2011',105), 'Admin'),
        ('Vishal', 'Singhal', 300000,convert( DateTime,'14-02-2020' ,105), 'HR'),
        ('Amitabh', 'Singh', 500000, convert(DateTime,'14-02-2020' ,105), 'Admin'),
        ( 'Vivek', 'Bhati', 500000, convert(DateTime,'14-06-2011 ' ,105), 'Admin'),
        ( 'Vipul', 'Diwan', 200000, convert(DateTime,'14-06-2011 ' ,105), 'Account'),
        ( 'Satish', 'Kumar', 75000, convert(DateTime,'14-01-2020' ,105), 'Account'),
        ('Geetika', 'Chauhan', 90000, convert(DateTime,'14-04-2011' ,105), 'Admin');

CREATE TABLE Bonus (
    WORKER_REF_ID INT,
    BONUS_AMOUNT Decimal(8,2),
    BONUS_DATE DATETIME,
    FOREIGN KEY (WORKER_REF_ID)
        REFERENCES Worker(WORKER_ID)
        ON DELETE CASCADE
);

INSERT INTO Bonus 
    (WORKER_REF_ID,BONUS_AMOUNT, BONUS_DATE) VALUES
        (3030,5000, convert(Datetime,'16-02-2020',105)),
        ( 3031,3000, convert(Datetime,'16-06-2011',105)),
        (3032,14000, convert(datetime,'16-02-2020',105)),
        (3033,14500, convert(Datetime,'16-02-2020',105)),
        (3034,3500, convert(datetime,'16-06-2011',105));
CREATE TABLE Title (
    WORKER_REF_ID INT,
    WORKER_TITLE CHAR(25),
    AFFECTED_FROM DATETIME,
    FOREIGN KEY (WORKER_REF_ID)
        REFERENCES Worker(WORKER_ID)
        ON DELETE CASCADE
);
INSERT INTO Title 
    (WORKER_REF_ID,WORKER_TITLE, AFFECTED_FROM) VALUES
 ( 3030,'Manager', convert(datetime,'20-02-2016',105)),
 (3031,'Executive', convert(datetime,'11-06-2016',105)),
 (3032,'Executive', convert(datetime,'11-06-2016',105)),
 (3033,'Manager', convert(datetime,'11-06-2016',105)),
 (3034,'Asst. Manager', convert(datetime,'11-06-2016',105)),
 (3035,'Executive', convert(datetime,'11-06-2016',105)),
 (3036,'Lead', convert(datetime,'11-06-2016',105)),
 (3037,'Lead', convert(datetime,'11-06-2016',105));

 select * from Worker


 /* 1)Write an SQL query to fetch “FIRST_NAME” from Worker table in upper case.*/
 select upper(FIRST_NAME) from Worker;

/* 2)Write an SQL query to fetch unique values of DEPARTMENT from Worker table */
SELECT DISTINCT(DEPARTMENT) FROM Worker

/* 3)Write an SQL query to print the first three characters of  FIRST_NAME from Worker table.*/
SELECT SUBSTRING(FIRST_NAME,1,3) FROM Worker; 

/* 4)Write an SQL query to print the FIRST_NAME from Worker table after removing white spaces from the right side.*/
SELECT RTRIM(FIRST_NAME) FROM Worker

/* 5)Write an SQL query to print the DEPARTMENT from Worker table after removing white spaces from the left side.*/
SELECT LTRIM(FIRST_NAME) FROM Worker

/* 6)Write an SQL query that fetches the unique values of DEPARTMENT from Worker table and prints its length.*/
SELECT DISTINCT(DEPARTMENT),LEN(DEPARTMENT) FROM Worker

/* 7)Write an SQL query to print the FIRST_NAME from Worker table after replacing ‘a’ with ‘BC’.*/
SELECT REPLACE(DEPARTMENT, 'a' ,'BC') FROM Worker 

/* 8)Write an SQL query to print the FIRST_NAME and LAST_NAME from Worker table into a single column COMPLETE_NAME. A space char should separate them*/
 SELECT  CONCAT(FIRST_NAME,LAST_NAME) AS COMPLETE_NAME FROM Worker

 /* 9) Write an SQL query to print all Worker details from the Worker table order by FIRST_NAME Ascending. */
 SELECT * FROM Worker ORDER BY FIRST_NAME ASC

 /* 10)Write an SQL query to print all Worker details from the Worker table order by FIRST_NAME Ascending and DEPARTMENT Descending. */
 SELECT * FROM Worker ORDER BY FIRST_NAME ASC,DEPARTMENT DESC

 /* 11) Write an SQL query to print details for Workers with the first name as “Vipul” and “Satish” from Worker table. */
  SELECT * FROM Worker WHERE FIRST_NAME IN ('Vipul','Satish')

  /* 12)Write an SQL query to print details of workers excluding first names, “Vipul” and “Satish” from Worker table.*/
    SELECT * FROM Worker WHERE FIRST_NAME not IN ('Vipul','Satish')

/* 13)Write an SQL query to print details of the Workers whose FIRST_NAME ends with ‘h’ and contains six alphabets.*/
SELECT * FROM Worker WHERE UPPER(FIRST_NAME) LIKE '%h' AND LEN(FIRST_NAME) = 6

/* 14)Write an SQL query to print details of the Workers whose SALARY lies between 100000 and 500000.*/
SELECT *FROM Worker WHERE SALARY BETWEEN 100000 AND 500000

/* 15) Write an SQL query to show the top n (say 10) records of a table.*/
SELECT TOP(10) FIRST_NAME,LAST_NAME FROM Worker

/* 16)Write an SQL query to determine the nth (say n=5) highest salary from a table.*/
select * from(
select First_Name,Last_Name,salary,DENSE_RANK() over(order By salary desc) as DenseRank from worker 
)as tbl where DENSERANK = 5;

/* 17) Write an SQL query to determine the 5th highest salary without using TOP or limit method.*/
 select * From(select First_name,Last_Name, salary, Row_Number() over(order By salary DESC) As RowNumber from worker) as tbl where ROWNUMBER = 5;

 /* 18)Write an SQL query to show one row twice in results from a table.*/
 select * from Worker union all select * from Worker

 /* 19)Write an SQL query to show all departments along with the number of people in there.*/
 SELECT DEPARTMENT, count(*) as count FROM Worker GROUP BY DEPARTMENT;

 /* 20)Write an SQL query to show the last record from a table.*/
 SELECT TOP 1 * FROM Worker ORDER BY FIRST_NAME DESC

/* 21)Write an SQL query to fetch the first row of a table.*/
 SELECT TOP 1 * FROM Worker

 /* 22)Write an SQL query to print the name of employees having the highest salary in each department.*/
SELECT WORKER_ID, FIRST_NAME , LAST_NAME,SALARY,DEPARTMENT FROM Worker  WHERE SALARY IN (SELECT max(SALARY) FROM Worker GROUP BY DEPARTMENT);

/* 23)Write an SQL query to fetch three max salaries from a table.*/
select DEPARTMENT,Max(SALARY) as salareis from worker group by DEPARTMENT; 

/* 24) Write an SQL query to fetch departments along with the total salaries paid for each of them.*/
select DEPARTMENT,SUM(SALARY) as salareis from worker group by DEPARTMENT; 

/*25)Write an SQL query to fetch the names of workers who earn the highest salary.*/
SELECT first_name, salary FROM worker WHERE salary = (SELECT Max(salary) FROM worker)

