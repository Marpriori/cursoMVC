using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Treinamento_Benner.Facade;
using Treinamento_Benner.Models;

namespace Treinamento_Benner.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult Index()
        {
            return RedirectToAction("Login");
        }

        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            if (Request.IsAuthenticated && SessionFacade.Usuario != null)
                return RedirectToAction("Index", "Home");
            ViewBag.ReturnUrl = returnUrl;
            
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Usuario usuario, string returnUrl)
        {
            SessionFacade.Usuario = usuario;
            FormsAuthentication.SetAuthCookie(usuario.Login, true);
            return RedirectToLocal(returnUrl);
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            //confirmar se a URL está no meu domínio.
            if (Url.IsLocalUrl(returnUrl))
                return Redirect(returnUrl);
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            SessionFacade.Usuario = null;
            return RedirectToAction("Index", "Home");
        }

    }
}
