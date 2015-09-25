using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Treinamento_Benner.Models
{
    public class Genero
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public  ICollection<Album> Albums { get; set; }

    }
}