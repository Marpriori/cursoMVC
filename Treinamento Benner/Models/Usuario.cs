using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Treinamento_Benner.Models
{
    public class Usuario
    {
        public Usuario()
        {
            Login = "";
            Senha = "";
        }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}