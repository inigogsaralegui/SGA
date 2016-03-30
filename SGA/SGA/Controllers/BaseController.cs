using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGA.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        protected override IAsyncResult BeginExecuteCore(AsyncCallback callback, object state)
        {
            DefaultLocale();
            return base.BeginExecuteCore(callback, state);
        }

        public void DefaultLocale()
        {
            HttpCookie cookie = Request.Cookies.Get("CacheLang");
            if (cookie == null)
            {
                HttpCookie newCookie = new HttpCookie("CacheLang");
                newCookie.Value = "es_ES";
                Response.Cookies.Add(newCookie);
           }
        }

    }
}