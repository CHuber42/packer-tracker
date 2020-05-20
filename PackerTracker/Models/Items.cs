using System;
using System.Collections.Generic;

namespace Items.Models
{
    public class Item
    {
      public string Name{get;set;}
      public bool Purchased{get;set;}
      public int Price{get;set;}
      public bool Packed{get;set;}
      public float weight{get;set;}
      private static List<Item> _itemList = new List<Item>(){};
      public int Id{get;set;}

      //Constructor
      public Item()
      {
        Name = name;
        Purchased = purchased;
        Price = price;
        Packed = packed;
        Weight = weight;
        _itemList.Add(this)               
        Id = _itemList.Count;
      }

      // //Return List of Places
      public static List<Item> GetAll()
      {
        return _itemList;
      }

      public static void ClearAll()
      {
        _itemList.Clear();
        return;
      }

      public static Item Find(int searchId)
      {
        return _itemList[searchId-1];
      }
    }
}