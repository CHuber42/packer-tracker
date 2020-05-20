using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Items.Models;

namespace Items.Tests
{
  [TestClass]
  public class ItemsTests : IDisposable
  {
    public void Dispose()
    {
      Places.ClearAll();
    }


    [TestMethod]
    public void ItemsConstructor_NewItemGetsAddedToList_True()
    {
      Items test1 = new Items("Tent", "not-purchased", "99.99", "not-packed", "5lbs");
      Assert.AreEqual(Items.GetAll().Count, 1);
    }

    [TestMethod]
    public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
    {
      Items test2 = new Items("Tent", "not-purchased", "99.99", "not-packed", "5lbs");
      Items testTwo = new Items("SleepingBag", "purchased", "49.99", "packed", "2.5lbs");
      
      int tent = test2.Id;
      int sleepingBag = testTwo.Id;
      
      Assert.AreEqual(1, tent);
      Assert.AreEqual(2, sleepingBag);
    }

  }
}  