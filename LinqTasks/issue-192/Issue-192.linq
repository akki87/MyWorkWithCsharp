<Query Kind="Program">
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

void Main()
{
	// Deleting Inactive Records.
	var users = (from u in Users
					join k in UserRoleMaps on u.UserID equals k.UserID select new{u.UserID,u.Name,u.Phone,u.CreatedBy,k.RoleID,u.Status} into res 
					join r in Roles on res.RoleID equals r.RoleID  select new {res.Name,res.Phone,r.RoleName,res.Status}).ToList();
	users.RemoveAll(x => x.Status==false);
	users.Dump();

	
	// Fetching Table Id and chair counts using group by .
	Sections.ToList();
	Sections.Dump();
	var sections = from s in Sections
					join d in DiningSets on s.SectionID equals d.SectionID select new {s.Name,table=$"Table{d.DiningSetID}",d.ChairCount} into result group result by result.Name ;
	
	sections.Dump();
	
	// Fetching TableId and chair count using having.
	var chairs = from s in Sections
					join d in DiningSets on s.SectionID equals d.SectionID where d.ChairCount > 4 group d by s.Name into k select k
					;
	
	chairs.Dump();
	var top10 = FoodItems.Where(x => x.CategoryID==503).Take(10);
	top10.Dump();
	
	// Food Menu using group by
	var menu = from f in FoodItems
				join fc in FoodCategories on f.CategoryID equals fc.CategoryID select new {name=f.Name,details=f.Details,category=fc.Name} into result group result by result.category into h select h;
	menu.Dump();
	
	var modifiedUsers = from u in Users 
						join t in Users on u.CreatedBy equals t.UserID select new{u.Name,u.Phone,u.UName,u.Password,CreatedBy=t.Name};
	modifiedUsers.Dump();
	
	
	
}

