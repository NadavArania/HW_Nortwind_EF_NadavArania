using HW_EF6_NadavArania.Models;
using System.Text.Json;

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
                listRegions.ForEach(x => Console.WriteLine($"Region Descrip : {x.RegionDescription}"));

                //Targil 3
                var listTerritories = db.Territories.ToList();

                //Targil 4
                listTerritories.ForEach(x => Console.WriteLine($"Territory Descrip : {x.TerritoryDescription}"));

                // Targil 5
                foreach (var region in listRegions)
                {
                    Console.WriteLine(region.RegionDescription);
                    foreach (var territory in listTerritories)
                    {
                        Console.WriteLine("\n -" + territory.TerritoryDescription);
                    }
                };
            }
        }
    }
}