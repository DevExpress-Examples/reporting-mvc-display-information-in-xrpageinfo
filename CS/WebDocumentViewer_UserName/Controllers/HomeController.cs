using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebDocumentViewer_UserName.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult Viewer() {
            return View();
        }
    }
}