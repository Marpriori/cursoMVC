using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Treinamento_Benner.Models;

namespace Treinamento_Benner.Context
{
    public class LojaContext : DbContext
    {
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Artista> Artistas { get; set; }
        public DbSet<Album> Albums { get; set; }

    }
}