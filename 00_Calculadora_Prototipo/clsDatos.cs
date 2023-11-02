using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _00_Calculadora_Prototipo
{
    public class clsDatos
    {
        public string val1Str { get; set; }
        public string val2Str { get; set; }
        public string valor { get; set; }
        public int funcion { get; set; }
        public double val1Double { get; set; }
        public double val2Double { get; set; }
        public double resultado { get; set; }
        
 
        public clsDatos()
        {
            val1Str = "";
            val2Str = "";
            valor = "";
            funcion = 0;
            val1Double = 0;
            val2Double = 0;
            resultado = 0;
        }

    }
}