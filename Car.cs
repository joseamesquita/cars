using System;
using System.Collections.Generic;
using System.Linq;

public class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;

  public Car(string makeModel, int price, int miles)
  {
    MakeModel = makeModel;
    Price = price;
    Miles = miles;
  }

  public bool WorthBuying(int maxPrice)
  {
    return (Price < maxPrice);
  }
}

public class Program
{
  public static void Main()
  {
    Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792);
    Car yugo = new Car("1980 Yugo Koral", 700, 56000);
    Car ford = new Car("1988 Ford Country Squire", 1400, 239001);
    Car amc = new Car("1976 AMC Pacer", 400, 198000);

    List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    // int[] Total = {volkswagen.Price, yugo.Price, ford.Price, amc.Price};
  
    List<Car> CarsMatchingSearch = new List<Car>(0);

    foreach (Car automobile in Cars)
    { 
     if (automobile.WorthBuying(maxPrice))
      {
        CarsMatchingSearch.Add(automobile);
      }
    }

  if (CarsMatchingSearch.Count > 0)
  {
    foreach (Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.MakeModel);
    }
  } 
  else 
  {
    Console.WriteLine("No cars in your budget.");
    }
  }
}



//     foreach(Car automobile in CarsMatchingSearch)
//     {
//          Console.WriteLine(automobile.MakeModel);
//     }
//   }
// }