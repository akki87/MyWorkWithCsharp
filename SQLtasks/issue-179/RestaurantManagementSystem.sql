create database RMS;
Go
--drop database RMS
USE RMS;
Create Table [User](
	UserID INT NOT NULL IDENTITY(220221,1),
	[Name] varchar(30) NOT NULL UNIQUE,
	Phone varchar(10) NOT NULL,
	UName VARCHAR(30) NOT NULL,
	[Password] VARCHAR(8) NOT NULL,
	CreatedBy INT NOT NULL,
	CreatedDate DateTime NOT NULL,
	ModifiedBy INT NOT NULL,
	ModifiedDate DateTime NOT NULL,
	[Status] BIT Default(0),
	Primary Key (UserID),
	)

CREATE TABLE Customer(
	CustomerID INT IDENTITY(9456,3) NOT NULL,
	[Name] VARCHAR(20),
	[Address] VARCHAR(100),
	Phone varchar(10),
	CName VARCHAR(20) NOT NULL unique,
	CreatedBy INT NOT NULL,
	CreatedDate DateTime NOT NULL,
	ModifiedBy INT NOT NULL,
	ModifiedDate DateTime NOT NULL,
	PRIMARY KEY (CustomerID),
	FOREIGN KEY (CreatedBy) REFERENCES [User](UserID),
	FOREIGN KEY (ModifiedBy) REFERENCES [User](UserID)
	)

CREATE TABLE Section(
	SectionID INT IDENTITY(201,1),
	[Name] VARCHAR(20) NOT NULL,
	CreatedBy INT NOT NULL,
	CreatedDate DateTime NOT NULL,
	ModifiedBy INT NOT NULL,
	ModifiedDate DateTime NOT NULL,
	Charges INT NOT NULL,
	PRIMARY KEY(SectionID),
	FOREIGN KEY (CreatedBy) REFERENCES [User](UserID),
	FOREIGN KEY (ModifiedBy) REFERENCES [User](UserID)
	)

CREATE TABLE DiningSet(
	DiningSetID INT NOT NULL IDENTITY(45,1),
	ChairCount INT NOT NULL,
	SectionID INT NOT NULL,
	[Status] BIT Default(0),
	PRIMARY KEY (DiningSetID),
	FOREIGN KEY(SectionID) REFERENCES Section(SectionID))

CREATE TABLE FoodCategory(
	CategoryID INT NOT NULL IDENTITY(501,1),
	[Name] VARCHAR(20) NOT NULL UNIQUE,
	CreatedBy INT NOT NULL,
	CreatedDate DateTime NOT NULL,
	ModifiedBy INT NOT NULL,
	ModifiedDate DateTime NOT NULL,
	[Status] BIT Default(0),
	PRIMARY KEY(CategoryID),
	FOREIGN KEY (CreatedBy) REFERENCES [User](UserID),
	FOREIGN KEY (ModifiedBy) REFERENCES [User](UserID))

CREATE TABLE FoodItem(
	ItemID INT not null IDENTITY(20,1),
	Name VARCHAR(40) NOT NULL,
	Details VARCHAR(100),
	CategoryID INT NOT NULL,
	CreatedBy INT NOT NULL,
	CreatedDate DateTime NOT NULL,
	ModifiedBy INT NOT NULL,
	ModifiedDate DateTime NOT NULL,
	[Status] BIT Default(0),
	Price DECIMAL NOT NULL,
	FOREIGN KEY (CategoryID) REFERENCES FoodCategory(CategoryID),
	FOREIGN KEY (CreatedBy) REFERENCES [User](UserID),
	FOREIGN KEY (ModifiedBy) REFERENCES [User](UserID),
	PRIMARY KEY (ItemID))

CREATE TABLE [Order](
	OrderID INT NOT NULL IDENTITY(8000,1),
	DiningSetID INT NOT NULL,
	ChefID  INT NOT NULL,
	WaiterID INT NOT NULL,
	CustomerID INT NOT NULL,
	[OrderStatus] VARCHAR(20) NOT NULL,
	[Status] BIT Default(0),
	PRIMARY KEY (OrderID),
	FOREIGN KEY(DiningSetID) REFERENCES DiningSet(DiningSetID),
	FOREIGN KEY(ChefID) REFERENCES [USer](UserID),
	FOREIGN KEY(CustomerID) REFERENCES Customer(CustomerID),
	FOREIGN KEY(WaiterID) REFERENCES [USer](UserID))

CREATE TABLE OrderDetails(
	OrderID INT NOT NULL,
	ItemID INT NOT NULL,
	ItemName VARCHAR(20) NOT NULL,
	Quantity INT NOT NULL,
	Price DECIMAL(8,2) NOT NULL,
	FOREIGN KEY(ItemID) REFERENCES FoodItem(ItemID),
	FOREIGN KEY(OrderID) REFERENCES [Order](OrderID))

CREATE TABLE Bill(
	BillID INT NOT NULL IDENTITY(19780,1),
	OrderID INT NOT NULL,
	CustomerID INT NOT NULL,
	CustomerName VARCHAR(20) NOT NULL,
	OrderItems VARCHAR(MAX) NOT NULL,
	TotalCost Decimal NOT NULL,
	PRIMARY KEY (BillID),
	FOREIGN KEY(OrderID) REFERENCES [Order](OrderID),
	FOREIGN KEY(CustomerID) REFERENCES Customer(CustomerID),FOREIGN KEY(CustomerName) REFERENCES Customer(CName))

CREATE TABLE Roles(
	RoleID INT NOT NULL IDENTITY(7121,1),
	RoleName VARCHAR(20) NOT NULL UNIQUE,
	CreatedBy INT NOT NULL,
	CreatedDate DateTime NOT NULL,
	ModifiedBy INT NOT NULL,
	ModifiedDate DateTime NOT NULL,
	[Status] BIT DEFAULT(0),
	PRIMARY KEY(RoleID),	FOREIGN KEY (CreatedBy) REFERENCES [User](UserID),
	FOREIGN KEY (ModifiedBy) REFERENCES [User](UserID))

CREATE TABLE UserRoleMap(
	UserRoleID INT NOT NULL IDENTITY(8639,1),
	RoleID INT NOT NULL,
	UserID  INT NOT NULL,
	CreatedBy INT NOT NULL,
	CreatedDate DateTime NOT NULL,
	ModifiedBy INT NOT NULL,
	ModifiedDate DateTime NOT NULL,
	[Status] BIT DEFAULT(0),
	PRIMARY KEY(UserRoleID),FOREIGN KEY (CreatedBy) REFERENCES [User](UserID),
	FOREIGN KEY (ModifiedBy) REFERENCES [User](UserID),FOREIGN KEY (UserID) REFERENCES [User](UserID),
	FOREIGN KEY (RoleID) REFERENCES Roles(RoleID))	

insert into [User] values('Avishek','8798455465','Avishek@qualminds.com','Avishek1',0,GetDate(),0,GetDate(),0),
('Sasidhar','8798455465','Sasidhar@qualminds.com','Sasi5678',0,GetDate(),0,GetDate(),0),
('Koti','8798745465','Koti@qualminds.com','Guptha41',0,GetDate(),0,GetDate(),0),
('Raveendra','8798455465','Raveendra@qualminds.com','Rave985y',0,GetDate(),0,GetDate(),0),
('sahitha','8765465456','sahitha@qualminds.com','Saahi325',0,GetDate(),0,GetDate(),0),
('Akanksha','5462116486','Akanksha@qualminds.com','Anu@1389',0,GetDate(),0,GetDate(),0),
('Pavan','7682263828','Pavan@qualminds.com','Pavan@89',0,GetDate(),0,GetDate(),0),
('Yogesh','7866525465','Yogesh@qualminds.com','Yogesh25',0,GetDate(),0,GetDate(),0),
('Samvid','8499358774','Samvid@qualminds.com','Samvid45',0,GetDate(),0,GetDate(),0),
('Dharmendar','7247962929','Dharmendar@qualminds.com','Dharmend',0,GetDate(),0,GetDate(),0),
('Nagalakshmi','7866525465','Nagalakshmi@qualminds.com','Naga1325',0,GetDate(),0,GetDate(),0),
('Afrin','7866525465','Afrin@qualminds.com','Afrin385',0,GetDate(),0,GetDate(),0),
('Jagan','7866525465','Jagan@qualminds.com','Jagan725',0,GetDate(),0,GetDate(),0)

--select * from [User]

insert into Roles values('Manager',220222,Getdate(),220222,Getdate(),0),
('Administrator',220222,Getdate(),220222,Getdate(),0),
('chef',220222,Getdate(),220222,Getdate(),0),
('Waiter',220222,Getdate(),220222,Getdate(),0),
('starter chef',220222,Getdate(),220222,Getdate(),0),
('Receptionist',220222,Getdate(),220222,Getdate(),0),
('Assistant Manager',220222,Getdate(),220222,Getdate(),0),
('Dishwasher',220222,Getdate(),220222,Getdate(),0),
('Cashier',220222,Getdate(),220222,Getdate(),0),
('Barista',220222,Getdate(),220222,Getdate(),0),
('Server',220222,Getdate(),220222,Getdate(),0),
('Host',220222,Getdate(),220222,Getdate(),0),
('Executive Chef',220222,Getdate(),220222,Getdate(),0),
('Head waiter',220222,Getdate(),220222,Getdate(),0)
insert into Roles values('SuperUser',220222,Getdate(),220222,Getdate(),1)


update Roles set [Status]=1
select* from [Roles]
select * from [User]
--select * from Roles 
insert into UserRoleMap values(7135,220221,220222,Getdate(),220222,getDate(),1),
(7135,220222,220222,Getdate(),220222,getDate(),1),
(7135,220228,220222,Getdate(),220222,getDate(),1),
(7133,220228,220222,Getdate(),220222,getDate(),1),
(7123,220225,220222,Getdate(),220222,getDate(),1),
(7126,220225,220222,Getdate(),220222,getDate(),1),
(7123,220226,220222,Getdate(),220222,getDate(),1)
insert into UserRoleMap values(7126,220226,220222,Getdate(),220222,getDate(),1),
(7123,220227,220222,Getdate(),220222,getDate(),1),
(7134,220227,220222,Getdate(),220222,getDate(),1),
(7124,220229,220222,Getdate(),220222,getDate(),1),
(7124,220230,220222,Getdate(),220222,getDate(),1),
(7124,220231,220222,Getdate(),220222,getDate(),1)
insert into UserRoleMap values(7124,220232,220222,Getdate(),220222,getDate(),1),
(7126,220233,220222,Getdate(),220222,getDate(),1),
(7122,220222,220222,Getdate(),220222,getDate(),1),
(7122,220222,220222,Getdate(),220222,getDate(),1)

insert into Section values('Kailas',220222,GETDATE(),220222,GETDATE(),115),('Bhulok',220222,GETDATE(),220222,GETDATE(),89),('Pathal',220222,GETDATE(),220222,GETDATE(),45);

------drop table [User]
------insert into chef values('Akanksha','5687967560',GETDATE(),null),('Pavan','7682263828',GETDATE(),null),('Yogesh','7938473990',GETDATE(),null),('Samvid','8499358774',GETDATE(),null);

------insert into waiter values('Dharmendar','7247962929',GETDATE(),null),('Nagalakshmi','3738798743',GETDATE(),null),('Afrin','8973485485',GETDATE(),null),('Jagan','8927989879',GETDATE(),null),('Akanksha thota','9573733847',GETDATE(),null)
DECLARE @i INT = 203;
WHILE @i >= 201
	BEGIN
		PRINT (@i);
		declare @ccount int = 2;
		while @ccount <= 7
			begin
				insert into DiningSet values(@ccount,@i,1)
				set @ccount = @ccount + 1;
			end;
		set @i = @i - 1;
	END;

insert into FoodCategory values('RiceAndBiryani',220222,GETDATE(),220222,GETDATE(),1),
('Starters',220222,GETDATE(),220222,GETDATE(),1),
('MainCourse',220222,GETDATE(),220222,GETDATE(),1),
('Roti&Naans',220222,GETDATE(),220222,GETDATE(),1),
('FastFood',220222,GETDATE(),220222,GETDATE(),1),
('Sweets',220222,GETDATE(),220222,GETDATE(),1),
('Burgers',220222,GETDATE(),220222,GETDATE(),1),
('SandWiches',220222,GETDATE(),220222,GETDATE(),1),
('Salads',220222,GETDATE(),220222,GETDATE(),1),
('Beverages',220222,GETDATE(),220222,GETDATE(),1),
('Appetizers',220222,GETDATE(),220222,GETDATE(),1)


insert into FoodItem
values ('Veg Fried Rice','Serves one, with garlic Sauce',501,220222,GETDATE(),220222,GETDATE(),1,130),('Plain Rice','Severs one',501,220222,GETDATE(),220222,GETDATE(),1,90),
('Veg Fried Rice','serves only one',501,220222,GETDATE(),220222,GETDATE(),1,140),
('Paneer Biryani','',501,220222,GETDATE(),220222,GETDATE(),1,220),
('Mushroom Biryani','',501,220222,GETDATE(),220222,GETDATE(),1,220),
('chicken Biryani','',501,220222,GETDATE(),220222,GETDATE(),1,140),
('Mutton Biryani','',501,220222,GETDATE(),220222,GETDATE(),1,150),
('chicken Biryani','Boneless',501,220222,GETDATE(),220222,GETDATE(),1,320),
('Fish Biryani','',501,220222,GETDATE(),220222,GETDATE(),1,320),
('Prawns Biryani','',501,220222,GETDATE(),220222,GETDATE(),31,20),
('chicken Biryani','Full',501,220222,GETDATE(),220222,GETDATE(),1,230),
('Mutton Biryani','Full',501,220222,GETDATE(),220222,GETDATE(),1,250),
('chicken Biryani','Family Pack servers four',501,220222,GETDATE(),220222,GETDATE(),1,550),
('chicken BiryaniJumbo','Family Pack servers 6',501,220222,GETDATE(),220222,GETDATE(),1,750),
('Mutton Biryani','Family Pack servers four',501,220222,GETDATE(),220222,GETDATE(),1,650),
('Mutton Biryani Jumbo','Family Pack servers six',501,220222,GETDATE(),220222,GETDATE(),1,850),
('spl.chicken Biryani','serves one',501,220222,GETDATE(),220222,GETDATE(),1,310),('spl.Mutton Biryani','',501,220222,GETDATE(),220222,GETDATE(),1,360),
('veg Biryani','Family',501,220222,GETDATE(),220222,GETDATE(),1,350),
('Veg Biryani','Jumbo',501,220222,GETDATE(),220222,GETDATE(),1,450),
('Veg Biryani','single',501,220222,GETDATE(),220222,GETDATE(),1,110),('Baby Corn Crispy','',502,220222,GETDATE(),220222,GETDATE(),1,170),
('Chilli baby Corn','',502,220222,GETDATE(),220222,GETDATE(),1,170),('Baby Corn Manchurian','',502,220222,GETDATE(),220222,GETDATE(),1,170),
('Chilli chicken','',502,220222,GETDATE(),220222,GETDATE(),1,240),('lollypop chicken','',502,220222,GETDATE(),220222,GETDATE(),1,250),
('chicken-65','',502,220222,GETDATE(),220222,GETDATE(),1,240),('Pepper chicken majestic ','',502,220222,GETDATE(),220222,GETDATE(),1,250),
('chilli fish dry','',502,220222,GETDATE(),220222,GETDATE(),1,260),('Apollo Fish','',502,220222,GETDATE(),220222,GETDATE(),1,260),
('Pepper chicken','',502,220222,GETDATE(),220222,GETDATE(),1,250),('Kaju paneer','',503,220222,GETDATE(),220222,GETDATE(),1,190),
('Kahdai paneer','',503,220222,GETDATE(),220222,GETDATE(),1,190),('Palak paneer','',503,220222,GETDATE(),220222,GETDATE(),1,180),
('Paneer Butter masala','',503,220222,GETDATE(),220222,GETDATE(),1,180),('Paneer Tikka masala','',503,220222,GETDATE(),220222,GETDATE(),1,190),('Egg curry','',503,220222,GETDATE(),220222,GETDATE(),1,130),
('Chicken masala','',503,220222,GETDATE(),220222,GETDATE(),1,240),
('Chicken nawabi','',503,220222,GETDATE(),220222,GETDATE(),1,240),
('shahi nawabi','',503,220222,GETDATE(),220222,GETDATE(),1,240),
('Butter Chicken','',503,220222,GETDATE(),220222,GETDATE(),1,240),('Methi Chicken','',503,220222,GETDATE(),220222,GETDATE(),1,240),
('Chicken punjabi','',503,220222,GETDATE(),220222,GETDATE(),1,250),('Chicken Andhra style','',503,220222,GETDATE(),220222,GETDATE(),1,250),('Chicken Tikka masala','',503,220222,GETDATE(),220222,GETDATE(),1,250),('Hyderbadi Chicken','',503,220222,GETDATE(),220222,GETDATE(),1,240),
('Chicken Arabi','',503,220222,GETDATE(),220222,GETDATE(),1,240),
('Chicken Kolapuri','',503,220222,GETDATE(),220222,GETDATE(),1,240),
('Chicken Afghani','',503,220222,GETDATE(),220222,GETDATE(),1,240),
('Chicken Kolapuri','',503,220222,GETDATE(),220222,GETDATE(),1,240),
('Mutton Fry','',503,220222,GETDATE(),220222,GETDATE(),1,260),
('Mutton shahi kurma','',503,220222,GETDATE(),220222,GETDATE(),1,260),
('Mutton shahi kurma','',503,220222,GETDATE(),220222,GETDATE(),1,260),
('Mutton Andhra','',503,220222,GETDATE(),220222,GETDATE(),1,260),
('Mutton Afghani','',503,220222,GETDATE(),220222,GETDATE(),1,270),
('Mutton Arabi','',503,220222,GETDATE(),220222,GETDATE(),1,260),
('Mutton Kolhapuri','',503,220222,GETDATE(),220222,GETDATE(),1,260),
('Mutton Mandi','',503,220222,GETDATE(),220222,GETDATE(),1,290),
('Fish Masala','',503,220222,GETDATE(),220222,GETDATE(),1,260),
('Afghani Fish Masala','',503,220222,GETDATE(),220222,GETDATE(),1,260),
('Fish Anhdra','',503,220222,GETDATE(),220222,GETDATE(),1,280),
('Andhra prawns masala','',503,220222,GETDATE(),220222,GETDATE(),1,260),
('Tandoori Roti','',504,220222,GETDATE(),220222,GETDATE(),1,20),('Rumali Roti','',504,220222,GETDATE(),220222,GETDATE(),1,20),
('Plain naan','',504,220222,GETDATE(),220222,GETDATE(),1,25),('Butter Naan','',504,220222,GETDATE(),220222,GETDATE(),1,30),
('Gralic naan','',504,220222,GETDATE(),220222,GETDATE(),1,35),
('chicken noodles','',505,220222,GETDATE(),220222,GETDATE(),1,120),
('chicken noodles-chinese','',505,220222,GETDATE(),220222,GETDATE(),1,140),
('chicke sezwan noodles','',505,220222,GETDATE(),220222,GETDATE(),1,140),
('spl.veg noodles','',505,220222,GETDATE(),220222,GETDATE(),1,110),
('Egg noodles','',505,220222,GETDATE(),220222,GETDATE(),1,90),('chicken manchurian','',505,220222,GETDATE(),220222,GETDATE(),1,150),
('Double ka meetha','',506,220222,GETDATE(),220222,GETDATE(),1,80),('Kaddu ka kheer','',506,220222,GETDATE(),220222,GETDATE(),1,80),
('Khubani ka meetha','',506,220222,GETDATE(),220222,GETDATE(),1,80),
('chicken zinger','',507,220222,GETDATE(),220222,GETDATE(),1,90),
('veg burger','',507,220222,GETDATE(),220222,GETDATE(),1,80),('Fish Burger','',507,220222,GETDATE(),220222,GETDATE(),1,110),('Fruit salad','',509,220222,GETDATE(),220222,GETDATE(),1,60),('spl.Fruit salad','',509,220222,GETDATE(),220222,GETDATE(),1,80),
('Fruit salad-Custard Ice cream','',509,220222,GETDATE(),220222,GETDATE(),1,100),('Sprite','300ml',510,220222,GETDATE(),220222,GETDATE(),1,25),('Thumbs Up','300ml',510,220222,GETDATE(),220222,GETDATE(),1,25),('Soda','any flavour',510,220222,GETDATE(),220222,GETDATE(),1,70),
('chicken Nugget','6 pcs',511,220222,GETDATE(),220222,GETDATE(),1,80),('chicken popcorn','',511,220222,GETDATE(),220222,GETDATE(),1,150),
('chicken boneless twister','6 pcs',511,220222,GETDATE(),220222,GETDATE(),1,180),('Fish popcorn','',511,220222,GETDATE(),220222,GETDATE(),1,200),
('French Fries','',511,220222,GETDATE(),220222,GETDATE(),1,80)

----print IDENT_CURRENT( 'FoodCategory' )  
insert into Customer values('Yogesh Nethula','','8639248231',('CUST'+cast(IDENT_CURRENT( 'Customer' ) as varchar(10))),220224,Getdate(),220224,Getdate())
select * from FoodItem
select * from Section
select * from DiningSet
select * from Roles
select * from [User]
select * from UserRoleMap
select Distinct [User].Name,[User].UserID,Roles.RoleName from UserRoleMap 
join [User] on [User].UserID=UserRoleMap.UserID
join Roles on UserRoleMap.RoleId=Roles.RoleID where Roles.Rolename=Upper('waiter')

 
select distinct [User].Name,[User].UserID,string_Agg(RoleName,',')as roles  from UserRoleMap 
join [User] on [User].UserID=UserRoleMap.UserID
join Roles on UserRoleMap.RoleId=Roles.RoleID where[User].UserID=220225 group by [User].Name,[User].UserID

select * from UserRoleMap
select * from DiningSet
select * from Customer
select * from [Order]
select * from FoodItem
select * from OrderDetails
select * from [User]
select * from Section
update [user] set Createdby=220222
update [user] set Modifiedby=220222

insert into [Order] values(50,220226,220230,9456,'started preparing',1),(47,220226,220230,9456,'ready',1);

insert into OrderDetails values(8000,35,(select Name from FoodItem where ItemID=35),2,(select Price*2 from FoodItem where ItemId=35)),
(8000,27,(select Name from FoodItem where ItemID=27),1,(select Price*1 from FoodItem where ItemId=27)),
(8000,34,(select Name from FoodItem where ItemID=34),2,(select Price*2 from FoodItem where ItemId=34)),
(8001,85,(select Name from FoodItem where ItemID=85),6,(select Price*6 from FoodItem where ItemId=85)),
(8001,95,(select Name from FoodItem where ItemID=95),4,(select Price*4 from FoodItem where ItemId=95))

insert into Bill values(8000,9456,'CUST9456',(select String_agg(ItemName,',') from Orderdetails where OrderID=8000),(select sum(Price) from OrderDetails where OrderID=8000)),
(8001,9456,'CUST9456',(select String_agg(ItemName,',') from Orderdetails where OrderID=8001),(select sum(Price) from OrderDetails where OrderID=8001))
select * from Bill

select ItemId,CreatedBy,CreatedDate,ModifiedBy,ModifiedDate,Price,[Status] into Prices from FoodItem
alter table FoodItem drop column price
select * from prices
--drop database RMS