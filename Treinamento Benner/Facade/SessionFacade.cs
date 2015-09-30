using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Treinamento_Benner.Models;

namespace Treinamento_Benner.Facade
{
    public static class SessionFacade
    {
        private const string SessionUsuario = "Usuario";
        public static Usuario Usuario
        {
            get
            {
                return
                    HttpContext.Current.Session != null ?
                    HttpContext.Current.Session[SessionUsuario] as Usuario : null;
            }
            set { HttpContext.Current.Session[SessionUsuario] = value; }
        }
    }


}