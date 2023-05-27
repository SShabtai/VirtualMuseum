using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirtualMuseum.Models;

namespace VirtualMuseum
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<ItemType> GetItemTypes()
        {
            var _db = new VirtualMuseum.Models.ItemContext();
            IQueryable<ItemType> query = _db.ItemTypes;
            return query;
        }
    }
}