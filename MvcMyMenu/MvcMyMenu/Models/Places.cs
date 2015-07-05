using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMyMenu.Models
{
    [Serializable]
    public class Places
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public Menu Menu { get; set; }
        public Products[] Products { get; set; }
   

    }
}