using System;

namespace Dealership.Models {

  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;
    private string _color;

    public Car(string makeModel, int price, int miles, string color)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
      _color = color;
    } 

    public static string MakeSound(string sound)
    {
      return "Our cars sound like " + sound;
    }

    public bool CarColor(string color)
    {
      return (_color == color);
    }

    public string GetCarColor()
    {
      return _color;
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }

    public int GetPrice()
    {
      return _price;
    }

    public int GetMiles()
    {
      return _miles;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (_price < maxPrice);
    }
  }

}