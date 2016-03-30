using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SGA.Models;

namespace SGA.Controllers
{
    public class HomeController : BaseController
    {
        private USRS usuario = new USRS();
        // GET: Home
        public ActionResult Index()
        {
            return View(usuario.Listar());
        }

        public ActionResult Crud(string user = null)
        {
            return View(user != null ? usuario.Obtener(user) : usuario);
        }

        public ActionResult Ver(string user)
        {
            return View(usuario.Obtener(user));
        }

        public ActionResult Guardar(USRS usuario)
        {
            usuario.Guardar();

            return Redirect("~/home/crud/"+usuario.sUSRS_USUARIO);
        }

        //public ActionResult ChangeCurrentCulture(int culture)
        //{
        //    //
        //    // Change the current culture for this user.
        //    //
        //    System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-ES");
        //    //
        //    // Cache the new current culture into the user HTTP session. 
        //    //
        //    Session["CurrentUICulture"] = culture;
        //    //
        //    // Redirect to the same page from where the request was made! 
        //    //
        //    return Redirect(Request.UrlReferrer.ToString());
        //}
    }
}