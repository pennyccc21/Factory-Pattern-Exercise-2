using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class MongoDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
             new Product(){ Name ="PS4", Price = 200},
              new Product() { Name = "Guitar", Price = 1000},
              new Product() { Name="Blender", Price = 50},
              new Product () { Name="Kite", Price =25},
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading mongo data access");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am now saving data from mongo");
        }
    }
}
