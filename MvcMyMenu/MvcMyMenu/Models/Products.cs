using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMyMenu.Models
{
    public class Products
    {
        public string full_description { get; set; }
        public Categories Category { get; set; }
        public long? Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string short_description { get; set; }
    }
}