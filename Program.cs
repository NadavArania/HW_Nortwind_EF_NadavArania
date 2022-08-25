using HW_EF6_NadavArania.Models;
using Microsoft.EntityFrameworkCore;

namespace HW_EF6_NadavArania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NorthwindContext())
            {
                //Targil 1
                var listRegions = db.Regions.ToList();

                //Targil 2
                //listRegions.ForEach(x => Console.WriteLine($"Region Descrip : {x.RegionDescription}"));

                //Targil 3
                var listTerritories = db.Territories.ToList();

                //Targil 4
                //listTerritories.ForEach(x => Console.WriteLine($"Territory Descrip : {x.TerritoryDescription}"));

                // Targil 5
                //var region = db.Territories.Include(t => t.Region).Select(x => new {RegionDescription = x.Region.RegionDescription,TerritoryDiscription = x.TerritoryDescription}).ToList();
                //region.ForEach(y => Console.WriteLine($"Region : {y.RegionDescription} \nTerritory : {y.TerritoryDiscription}"));

                //Targil 7
                //var prodEmpName = db.OrderDetails.Select(x => new {ProdName = x.Product.ProductName, EmpName = x.Order.Employee.FirstName }).Distinct().ToList();
                //prodEmpName.ForEach(y => Console.WriteLine($"Product : {y.ProdName} \n -Employee Name : {y.EmpName}"));
            }
        }
    }
}