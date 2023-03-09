using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMSCodeFirstApproach.Context;

namespace RMS.UnusedCode
{
    internal class UnusedCode
    {
        public new void Code()
        {
            //using (var context = new RMSContext())
            //{
            //    // Linq Query to get active staff group by roles
            //    var Users = (from u in context.Users
            //                 join ur in context.UserRoleMap on u.UserID equals ur.UserId
            //                 select new { u, ur.RoleId } into k
            //                 join role in context.Roles on k.RoleId equals role.RoleId
            //                 where k.u.Status == true
            //                 //from a in k.DefaultIfEmpty()
            //                 select new { UserId = k.u.UserID, UserName = k.u.Name, Phone = k.u.phone, Rolename = role.RoleName });

            //    foreach (var item in Users.ToList().GroupBy(x => x.Rolename).Select(x => x.Distinct()))
            //    {
            //        foreach (var r in item)
            //        {
            //            Console.WriteLine($"{r.UserId}\t{r.Phone.Trim()}\t{r.Rolename.Trim()}\t{r.UserName}");
            //        }
            //        Console.WriteLine();
            //    }

            //    // To fetch the DiningsetId and chair count of the table group by sections.
            //    var tables = from s in context.Sections
            //                 join d in context.DiningSets on s.SectionId equals d.SectionId
            //                 select new { s.Name, table = $"table{d.DiningSetId}", d.ChairCount };
            //    var Tables = tables.ToList().GroupBy(x => x.Name);
            //    foreach (var items in Tables)
            //    {
            //        Console.WriteLine(items.Key);
            //        foreach (var item in items)
            //        {
            //            Console.WriteLine($"{item.Name}\t{item.table}\t{item.ChairCount}");
            //        }
            //        Console.WriteLine();
            //    }

            //    // FoodItem with category grouping
            //    var FoodItems = from f in context.FoodItems
            //                    join fc in context.FoodCategories on f.CategoryID equals fc.CategoryId
            //                    select new { name = f.Name, details = f.Details, category = fc.Name, Price = f.Price } into result
            //                    //group result by result.category into h
            //                    select result;
            //    var fooditems = FoodItems.ToList().GroupBy(x => x.category);
            //    foreach (var items in fooditems)
            //    {
            //        Console.WriteLine(items.Key);
            //        foreach (var item in items)
            //        {
            //            Console.WriteLine($"{item.name}\t{item.details}\t{item.Price}\t{item.category}");
            //        }
            //        Console.WriteLine();
            //    }
            //}
        }
    }
}
