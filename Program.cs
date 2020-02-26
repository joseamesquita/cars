using System;
using System.Collections.Generic;
using Dealership.Models;

namespace Dealership {

  public class Program
  {
    public static void Main()
    {
      Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, "black");
      Car yugo = new Car("1980 Yugo Koral", 700, 56000, "gray");
      Car ford = new Car("1988 Ford Country Squire", 1400, 239001, "black");
      Car amc = new Car("1976 AMC Pacer", 400, 198000, "red");

      List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

      Console.WriteLine("Enter maximum price: ");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);

      Console.WriteLine("Enter a color: ");
      string color = Console.ReadLine();


      List<Car> CarsMatchingSearch = new List<Car>(0);

      foreach (Car automobile in Cars)
      {
        if (automobile.WorthBuying(maxPrice) && automobile.CarColor(color))
        {
          CarsMatchingSearch.Add(automobile);
        }
      }

      foreach(Car automobile in CarsMatchingSearch)
      {
        Console.WriteLine("----------------------");
        Console.WriteLine(automobile.GetMakeModel());
        Console.WriteLine(automobile.GetMiles() + " miles");
        Console.WriteLine("$" + automobile.GetPrice());
        Console.WriteLine(Car.MakeSound("bang"));
        Console.WriteLine(automobile.GetCarColor());
      }
    }
  }

}