using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GroupA.Models;
using GroupA.ViewModel;

namespace GroupA.Controllers
{
    public class ShoppingController : Controller
    {
        // GET: Shopping
        private UTFDbEntities objECartDbEntities;
      
        public ShoppingController()
        {
            objECartDbEntities = new UTFDbEntities();
            
        }
        // GET: Shopping
        public ActionResult Index()
        {
            IEnumerable<ShoppingViewModel> listOfShoppingViewModels = (from objItem in objECartDbEntities.Items
                                                                       join
                                                                           objCate in objECartDbEntities.Categories
                                                                           on objItem.CategoryId equals objCate.CategoryId
                                                                       select new ShoppingViewModel()
                                                                       {
                                                                           ImagePath = objItem.ImagePath,
                                                                           ItemName = objItem.ItemName,
                                                                           Description = objItem.Description,
                                                                           ItemPrice = (decimal)objItem.ItemPrice,
                                                                           ItemId = objItem.ItemId,
                                                                           Category = objCate.CategoryName,
                                                                           ItemCode = objItem.ItemCode
                                                                       }

                ).ToList();
            return View(listOfShoppingViewModels);
        }
    }
}