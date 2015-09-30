using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Treinamento_Benner.Context;
using Treinamento_Benner.Models;

namespace Treinamento_Benner.Controllers
{
    
    public class AlbumController : BaseController
    {
        private LojaContext _db = new LojaContext();

        [AllowAnonymous]
        public ActionResult Index()
        {
            var albums = from album in _db.Albums
                         orderby album.Titulo ascending
                         select album;
            return View(albums);
        }
        [Authorize]
        public ActionResult Create()
        {

            DropDown();

            return View();
        }

        private void DropDown()
        {
            ViewBag.ArtistaId = new SelectList(_db.Artistas, "Id", "Nome");

            ViewBag.GeneroId = new SelectList(_db.Generos, "Id", "Nome");
        }

        //[HttpPost]
        //public ActionResult Create(FormCollection form)
        //{
        //     var titulo = form["Titulo"];
        //     var generoId = Convert.ToInt32(form["GeneroId"]);
        //    return View();
        //}

        [HttpPost]
        public ActionResult Create(Album album)
        {
            /*
             Cria o objeto enviado pelo post que deverá conferir com o objeto do album
             */



            //ModelState controla o estado do modelo
            if (ModelState.IsValid)
            {
                _db.Albums.Add(album);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            DropDown();
            return View(album);
        }

        public ActionResult Search(string q)
        {
            IQueryable<Album> query = _db.Albums.OrderBy(a => a.Titulo);
            if (!string.IsNullOrWhiteSpace(q))
                query = query.Where(a => a.Titulo.Contains(q));

            //var albums = from album in _db.Albums
            //             orderby album.Titulo ascending
            //             where album.Titulo.Contains(q)
            //             select album;


            return View(query);
        }

    }
}
