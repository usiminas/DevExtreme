using DevExtreme.MVC.Helpers;
using DevExtreme.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevExtreme.MVC.Controllers
{
    public class GridViewController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Listar()
        {

            if (CacheHelper.GetCache("Gridview") != null) {

                return Json((List<GridViewModel>)CacheHelper.GetCache("Gridview"), JsonRequestBehavior.AllowGet);
                
            }

            List<GridViewModel> lst = new List<GridViewModel>();

            for (int i = 0; i < 30; i++)
            {
                lst.Add(new GridViewModel()
                {
                    ID = (i + 1),
                    CompanyName = "CompanyName " + (i + 1),
                    Address = "Address " + (i + 1),
                    City = "City " + (i + 1),
                    State = "State " + (i + 1),
                    Zipcode = "Zipcode " + (i + 1),
                    Phone = "Phone " + (i + 1),
                    Fax = "Fax " + (i + 1),
                    Website = "Website " + (i + 1)
                });
            }

            CacheHelper.AddCache("Gridview", lst, DateTime.Now.AddMinutes(10));

            return Json(lst, JsonRequestBehavior.AllowGet);
        }
    }
}