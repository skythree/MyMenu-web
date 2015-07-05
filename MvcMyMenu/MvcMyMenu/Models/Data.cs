using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcMyMenu.Models
{
    public class Data : DropCreateDatabaseIfModelChanges<MyMenuEntities>
    {
        protected override void Seed(MyMenuEntities context)
        {
            //var restaurants = new List<Restaurant>
            //{
            //    new Restaurant {Name = "Restaurant 1"},
            //    new Restaurant {Name = "Restaurant 2"},
            //    new Restaurant {Name = "Restaurant 3"},
            //    new Restaurant {Name = "Restaurant 4"}
            //};

            //new List<Menu>
            //{
            //    new Menu {Name = "Menu 1", Restaurant = restaurants.Single(r => r.Name == "Restaurant 1"), Price = 8 },
            //    new Menu {Name = "Menu 2", Restaurant = restaurants.Single(r => r.Name == "Restaurant 2"), Price = 8},
            //    new Menu {Name = "Menu 3", Restaurant = restaurants.Single(r => r.Name == "Restaurant 3"), Price = 8},
            //    new Menu {Name = "Menu 4", Restaurant = restaurants.Single(r => r.Name == "Restaurant 4"), Price = 8},
            //}.ForEach(m => context.Menus.Add(m));
        }
    }
}