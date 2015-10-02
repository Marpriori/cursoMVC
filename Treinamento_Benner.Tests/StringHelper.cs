using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Treinamento_Benner.Tests
{
    public static class StringHelper
    {
        public static string ToPlural(this string palavra)
        {

            if(palavra.EndsWith("tem")) return palavra.Substring(0,palavra.Length-3)+"têm";

            if (palavra.EndsWith("el")) return palavra.Substring(0, palavra.Length - 2) + "éis";

            


            switch(palavra){
                case "dois":
                case "três":
                case "seis":
                case "dez":
                    return palavra;
            }

            if (palavra.EndsWith("ês")) return palavra.Substring(0, palavra.Length - 2) + "eses";

            if (palavra.Equals("existe")) return palavra + "m";

            if (palavra.EndsWith("ão")) return palavra.Substring(0, palavra.Length - 2) + "ões";

            return palavra+ "s";
        }
    }
}
