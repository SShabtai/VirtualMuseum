using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VirtualMuseum.Models;

namespace VirtualMuseum.Logic
{
  public class AddArtItem
  {
    public bool AddProduct(string ItemName, string ItemDesc, string ItemPrice, string ItemType, string ItemImagePath)
    {
      var myItem = new ArtItem();
            myItem.ItemName = ItemName;
            myItem.Description = ItemDesc;
            myItem.UnitPrice = Convert.ToDouble(ItemPrice);
            myItem.ImagePath = ItemImagePath;
            myItem.ItemTypeID = Convert.ToInt32(ItemType);

      using (ItemContext _db = new ItemContext())
      {
        // Add product to DB.
        _db.ArtItems.Add(myItem);
        _db.SaveChanges();
      }
      // Success.
      return true;
    }
  }
}