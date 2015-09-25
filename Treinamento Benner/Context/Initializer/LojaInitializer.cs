using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Treinamento_Benner.Context.Initializer
{
    public class LojaInitializer: DropCreateDatabaseAlways<LojaContext>
    {
        protected override void Seed(LojaContext context)
        {
            context.Artistas.Add(new Models.Artista { Nome = "Al Di Meola" });
            context.Generos.Add(new Models.Genero { Nome = "Jazz" });
            context.Albums.Add(new Models.Album
            {
                Artista = new Models.Artista { Nome = "Chuck Berry" },
                Genero = new Models.Genero { Nome = "Rock and roll" },
                Valor = 9.99m,
                Titulo = "Rock, Rock, Rock",
                UrlArte = "http://www.bsnpubs.com/chess/chess/chess1425.jpg"

            });
            base.Seed(context);
        }
    }
}