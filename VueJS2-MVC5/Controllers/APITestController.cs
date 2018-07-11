using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VueJS2_MVC5.Controllers
{
  public class APITestController : Controller
  {
    [HttpGet]
    public ActionResult Index()
    {
      return Json(new {message = "You have reached the backend :)" }, JsonRequestBehavior.AllowGet);
    }
  }
}
