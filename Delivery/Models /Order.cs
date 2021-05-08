using System;
using System.Collections.Generic;


namespace Delivery.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string TimeCreated { get; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> { };

    public Order(string title, string description, int price)
    {
      Title = title;
      Description = description;
      Price = price;
      _instances.Add(this);
      Id = _instances.Count;
      TimeCreated = TimeStamp();
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId - 1];
    }

    public string TimeStamp()
    {
      DateTime date = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
      // converts to string format
      string date_str = date.ToString("dd/MM/yyyy");
      return date_str;
    }

  }
}