
using FactoryPatternExercise2;

Console.WriteLine("What database would you like to work with");
Console.WriteLine("Type: sql");
Console.WriteLine("Type: mongo");
Console.WriteLine("Type: list");

var userInput = Console.ReadLine();

IDataAccess db = DataAccessFactory.GetDataAccessType(userInput);

var products = db.LoadData();
db.SaveData();

foreach (var product in products)
{
    
    Console.Write($"Name: {item.Name} Price:{item.Price}");
}
