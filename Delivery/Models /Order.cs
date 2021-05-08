using System;
using System.Collections.Generic;
using System.Globalization;

namespace Delivery.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public string Price { get; set; }
    public string TimeCreated { get; }
    public int Id { get; }
    private static List<Item> _instances = new List<Item> { };

    public Order(string title, string price, string description)
    {
      Title = title;
      Description = description;
      Price = price;
      _instances.Add(this);
      Id = _instances.Count;
      TimeCreated = TimeStamp();
    }
    public string TimeStamp()
    {
      DateTime date = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
      // converts to string format
      string date_str = date.ToString("dd/MM/yyyy");
      return date_str;
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

  }
}