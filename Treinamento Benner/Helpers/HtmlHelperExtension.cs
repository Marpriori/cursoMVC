using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Treinamento_Benner.Helpers
{
    public static class HtmlHelperExtension
    {

        public static MvcHtmlString LinkVoltar(this HtmlHelper html, string idLink, string texto = "Voltar")
        {
            var stringLink = string.Format(
                "<a id='{0}' href='javascript:history.go(-1);' class='btn btn-default btn-xs'><i class='fa fa-step-backward'></i> {1}</a>", idLink, texto);
            return new MvcHtmlString(stringLink);
        }

    }
}