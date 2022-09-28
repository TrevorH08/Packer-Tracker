using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class Item
  {
    public string Name { get; }
    public float Cost { get; }
    public float Weight { get; }
    public bool Necessity { get; set; } = false;
    public string Type { get; set; }
    public bool Purchased { get; set; } = false;
    public int Id { get; }

    public bool Take { get; }
    private static List<Item> _instances = new List<Item>{};

    public Item(string name, float cost, float weight, bool necessity, string type, bool purchased)
    {
      Name = name;
      Cost = cost;
      Weight = weight;
      Necessity = necessity;
      Type = type;
      Purchased = purchased;
      _instances.Add(this);
      Id = _instances.Count;
      Take = ShouldTake();
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Item Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public bool ShouldTake()
    {
      return true;
    }

    public void SetPurchased()
    {
      Purchased = true;
    }

    public float TotalCost()
    {
      float totalCost = 0;
      return totalCost;
    }

    public static float TotalWeight()
    {
      float totalWeight = 0;
      foreach (Item item in _instances)
      {
        totalWeight += item.Weight;
      }
      return totalWeight;
    }

    
    /* Theme
      apocalypse
      - zombie
      - nuclear
      - flooding
      - san andreas type things
    */
    /*Properties
      item name: string
      cost: float in dollars $xx.xx
      purchased: bool 
      weight: float in lbs xx.xxlbs
      necessity: bool 
    */
    /* methods
      index - list - get
      create - form -get 
      find - get
      clearall - post
      getall -get 
      edit - form - get
      update - patch
      destroy - delete
      DoNotTake - if weight > XX && !necessity - do a thing
      Purchase - purchased = true
      TotalCost 
      TotalWeight
    */
  }
}