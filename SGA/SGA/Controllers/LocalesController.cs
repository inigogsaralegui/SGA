using System;
using System.Web.Mvc;
using Insya.Localization;

namespace SGA.Controllers
{
    public class LocalesController : Controller
    {

        public ActionResult Index(string lang = "es_ES")
        {
            Response.Cookies["CacheLang"].Value = lang;
			
            if (Request.UrlReferrer != null)
                Response.Redirect(Request.UrlReferrer.ToString());
             
			var message = Localization.Get("changedlng");
    
			return Content(message);
        }      

    }
}