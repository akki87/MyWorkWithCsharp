use RMS

/* For each second Query in each type the output result photo is in attachments */
/* INNER JOIN */
select FoodItem.ItemID,prices.Price  from FoodItem
inner join Prices on FoodItem.ItemID=Prices.ItemId;

select u.UserID,u.Name,STRING_AGG(v.RoleName, ', ') AS Roles from [User] as u
inner join (select Roles.RoleName,UserRoleMap.UserID  from Roles left join UserRoleMap on UserRoleMap.RoleID=Roles.RoleID) as v
on v.UserID=u.UserID group by u.UserID,u.Name;

/* LEFT JOIN */
select FoodItem.ItemID,FoodItem.Name,Prices.Price from FoodItem
left join Prices on FoodItem.ItemID=Prices.ItemId where Prices.Status=1

select u.UserID,u.Name,STRING_AGG(v.RoleName, ', ') AS Roles from [User] as u
left join (select Roles.RoleName,UserRoleMap.UserID  from Roles left join UserRoleMap on UserRoleMap.RoleID=Roles.RoleID) as v
on v.UserID=u.UserID group by u.UserID,u.Name;

/* RIGHT JOIN */
select FoodItem.ItemID,FoodItem.Name,Prices.Price from FoodItem
Right join Prices on FoodItem.ItemID=Prices.ItemId where Prices.Status=1

select u.UserID,u.Name,STRING_AGG(v.RoleName, ', ') AS Roles from [User] as u
right join (select Roles.RoleName,UserRoleMap.UserID  from Roles left join UserRoleMap on UserRoleMap.RoleID=Roles.RoleID) as v
on v.UserID=u.UserID group by u.UserID,u.Name;

/* FULL JOIN */
SELECT FoodItem.ItemID,FoodItem.Name,Prices.Price
FROM FoodItem
FULL JOIN Prices 
ON FoodItem.ItemID=Prices.ItemId;

select u.UserID,u.Name,STRING_AGG(v.RoleName, ', ') AS Roles from [User] as u
Full join (select Roles.RoleName,UserRoleMap.UserID  from Roles left join UserRoleMap on UserRoleMap.RoleID=Roles.RoleID) as v
on v.UserID=u.UserID group by u.UserID,u.Name;

/* CROSS JOINS */
select * from [Section]
cross join DiningSet

