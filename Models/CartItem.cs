using System.ComponentModel.DataAnnotations;

namespace VirtualMuseum.Models
{
  public class CartItem
  {
    [Key]
    public string ItemId { get; set; }

    public string CartId { get; set; }

    public int Quantity { get; set; }

    public System.DateTime DateCreated { get; set; }

    public int ArtItemId { get; set; }

    public virtual ArtItem ArtItem { get; set; }

  }
}