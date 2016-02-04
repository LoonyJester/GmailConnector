using System.Web.Mvc;
using GCE.Services;
using RestSharp;

namespace GCE.Backend.Controllers
{
    public class HomeController : Controller
    {
        [Route("~/")]
        public ActionResult Index()
        {
            var log = MailGunWrapper.GetLogs();
            IRestResponse m = MailGunWrapper.GetMessage("https://api.mailgun.net/v2/domains/sandboxd58f1141cdf14f9ebeff0300adaf2bc8.mailgun.org/messages/WyJmZTdiMjJhZmNkIiwgWyIyMzQ2ZDVkZi0zMDc3LTQ1ZTQtOTA1Ny1kNTU4MmJlMDI1YWQiXSwgIm1haWxndW4iLCAib2RpbiJd");

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