<Query Kind="Statements">
  <Connection>
    <ID>df9ce768-9e23-47fb-8db4-cab7a0a2cf9e</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>(localdb)\MSSQLLocalDB</Server>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <Database>RMS</Database>
    <DriverData>
      <LegacyMFA>false</LegacyMFA>
    </DriverData>
  </Connection>
</Query>


var Biryanis = from f in FoodCategories
				join c in FoodItems
				on f.CategoryID equals c.CategoryID where f.CategoryID==501 select new {f.CategoryID,Category=f.Name, FoodName=c.Name,itemId=c.ItemID} into res
				join  k in Prices on res.itemId equals k.ItemId select new {res.FoodName,k.Price} ;
var starters = from f in FoodCategories
				join c in FoodItems
				on f.CategoryID equals c.CategoryID where f.CategoryID==502 select new {f.CategoryID,Category=f.Name, FoodName=c.Name,itemId=c.ItemID} into res
				join  k in Prices on res.itemId equals k.ItemId select new {res.FoodName,k.Price} ;
var Beverages = from f in FoodCategories
				join c in FoodItems
				on f.CategoryID equals c.CategoryID where f.CategoryID==511 select new {f.CategoryID,Category=f.Name, FoodName=c.Name,itemId=c.ItemID} into res
				join  k in Prices on res.itemId equals k.ItemId select new {res.FoodName,k.Price} ;
var MainCourse = from f in FoodCategories
				join c in FoodItems
				on f.CategoryID equals c.CategoryID where f.CategoryID==503 select new {f.CategoryID,Category=f.Name, FoodName=c.Name,itemId=c.ItemID} into res
				join  k in Prices on res.itemId equals k.ItemId select new {res.FoodName,k.Price} ;
var FastFood = from f in FoodCategories
				join c in FoodItems
				on f.CategoryID equals c.CategoryID where f.CategoryID==505 select new {f.CategoryID,Category=f.Name, FoodName=c.Name,itemId=c.ItemID} into res
				join  k in Prices on res.itemId equals k.ItemId select new {res.FoodName,k.Price} ;

var chefs = from c in Users
			join ur in UserRoleMaps on c.UserID equals ur.UserID select new {c.UserID,c.Name,c.UName,c.Phone,ur.RoleID} into res
			join r in Roles on res.RoleID equals r.RoleID where r.RoleID==7123 select new { r.RoleName,res.Name,res.UserID,};
var Waiters = from c in Users
			join ur in UserRoleMaps on c.UserID equals ur.UserID select new {c.UserID,c.Name,c.UName,c.Phone,ur.RoleID} into res
			join r in Roles on res.RoleID equals r.RoleID where r.RoleID==7124 select new { r.RoleName,res.Name,res.UserID,};

				
//Customers.Dump();
chefs.Dump();
Waiters.Dump();
starters.Dump();
MainCourse.Dump();
FastFood.Dump();
Beverages.Dump();
Roles.Dump();