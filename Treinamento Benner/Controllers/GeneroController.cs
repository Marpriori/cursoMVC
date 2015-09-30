using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Treinamento_Benner.Context;

namespace Treinamento_Benner.Controllers
{
    public class GeneroController : Controller
    {
        private readonly LojaContext _db = new LojaContext();

        public ActionResult Index()
        {
            return View(_db.Generos);
        }
    }
}
