using System.ComponentModel.DataAnnotations;

namespace VirtualMuseum.Models
{
    public class ArtItem
    {
        [Key]
        [ScaffoldColumn(false)]
        public int ItemID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string ItemName { get; set; }

        [Required, StringLength(10000), Display(Name = "Item Description"), DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string ImagePath { get; set; }

        [Display(Name = "Price")]
        public double? UnitPrice { get; set; }

        public int? ItemTypeID { get; set; }

        public virtual ItemType ItemType { get; set; } 
    }
}