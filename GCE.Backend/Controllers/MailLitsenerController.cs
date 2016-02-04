using System.Web.Mvc;

namespace GCE.Backend.Controllers
{
    [RoutePrefix("maillistener")]
    public class MailLitsenerController : Controller
    {



        [Route("")]
        [AcceptVerbs(HttpVerbs.Post)]
        [ValidateInput(false)]
        public ActionResult Index()
        {
            

//            var t  = Request.Unvalidated.Form["stripped-html"];
            return Content("OK");
        }
    }
}