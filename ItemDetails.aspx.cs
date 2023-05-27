using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirtualMuseum.Models;
using System.Web.ModelBinding;

namespace VirtualMuseum
{
    public partial class ItemDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<ArtItem> GetItem([QueryString("ItemID")] int? itemId)
        {
            var _db = new VirtualMuseum.Models.ItemContext();
            IQueryable<ArtItem> query = _db.ArtItems;
            if (itemId.HasValue && itemId > 0)
            {
                query = query.Where(i => i.ItemID == itemId);
            }
            else
            {
                query = null;
            }
            return query;
        }
    }
}