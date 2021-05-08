using System.Collections.Generic;

namespace Delivery.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> { };
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }

    public Vendor(string VendorName, string description)
    {
      Name = VendorName;
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order> { };
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static List<Vendor> GetAll()
    {
      return _instances;
    }
    public void AddItem(Item item)
    {
      Orders.Add(item);
    }

    public static Vendor Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}