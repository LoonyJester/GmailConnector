using System.Web.Mvc;
using GCE.Services;
using RestSharp;

namespace GCE.Backend.Controllers
{
    public class HomeController : Controller
    {
        [Route("~/")]
        public ActionResult Index(string url)
        {
//            var log = MailGunWrapper.GetLogs();
            if (!string.IsNullOrEmpty(url))
            {
                IRestResponse m = MailGunWrapper.GetMessage(url);
                return View();
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}