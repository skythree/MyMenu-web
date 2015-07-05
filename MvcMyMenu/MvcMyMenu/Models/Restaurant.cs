using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMyMenu.Models
{
    public partial class Restaurant
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public Menu Menus { get; set; }
        public Products Products { get; set; }
        public Categories Categories { get; set; }
        public string full_description { get; set; }
        public string short_description { get; set; }
    }
}