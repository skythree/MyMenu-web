using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMyMenu.Models;
using System.Net.Http;
using System.Web.Script.Serialization;

namespace MvcMyMenu.Controllers
{
    public class RestaurantController : Controller
    {
        //private MyMenuEntities storeDb = new MyMenuEntities();
        //
        // GET: /Restaurant/


        [HttpGet]
        public ActionResult Index()
        {
            //var restaurants = storeDb.Restaurants.ToList();
            using (var client = new HttpClient())
            {
                var result =
                    client.GetAsync(new Uri("http://www.getideafrom.me/api/rest/places")).Result;
                var tmp = result.Content.ReadAsStringAsync();

                var json_serializer = new JavaScriptSerializer();
                var places = json_serializer.Deserialize<Places[]>(tmp.Result);
                return View(places);

            }
        }
        [HttpGet]
        public ActionResult Browse(string restaurant)
        {
            //var restaurantModel = storeDb.Restaurants.Include("Menus").Single(r => r.Name == restaurant);
            using (var client = new HttpClient())
            {
                var result =
                    client.GetAsync(new Uri("http://www.getideafrom.me/api/rest/menus")).Result;
                var tmp = result.Content.ReadAsStringAsync();

                var json_serializer = new JavaScriptSerializer();
                var menu = json_serializer.Deserialize<Menu[]>(tmp.Result);
                return View(menu);            
            }
    
        }
        [HttpGet]
        public ActionResult Details(long? id)
        {
            //var menus = storeDb.Menus.Find(id);

            using (var client = new HttpClient())
            {
                var result =
                    client.GetAsync(new Uri("http://www.getideafrom.me/api/rest/categories")).Result;
                var tmp = result.Content.ReadAsStringAsync();

                var json_serializer = new JavaScriptSerializer();
                var categories = json_serializer.Deserialize<Categories[]>(tmp.Result);
                
                return View(categories);
               
               
            }
        }
        [HttpGet]
        public ActionResult Restaurants(string restaurants)
        {
            using (var client = new HttpClient())
            {
                var result =
                    client.GetAsync(new Uri("http://www.getideafrom.me/api/rest/products")).Result;
                var tmp = result.Content.ReadAsStringAsync();

                var json_serializer = new JavaScriptSerializer();
                var products = json_serializer.Deserialize<Products[]>(tmp.Result);
                
                return View(products);

            }
        }

    }
}
