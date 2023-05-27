using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VirtualMuseum.Models
{
    public class ItemType
    {
        [ScaffoldColumn(false)]
        public int ItemTypeID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string ItemTypeName { get; set; }

        [Display(Name = "Item Description")]
        public string Description { get; set; }

        public virtual ICollection<ArtItem> ArtItems { get; set; }
    }
}