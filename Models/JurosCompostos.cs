using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace juros.Models
{
    public class JurosCompostos
    {
        public double Principal { get; set; }
        public double TaxaJuros { get; set; }
        public int Periodos { get; set; }

        public double CalcularJurosCompostos()
        {
            return Principal * Math.Pow((1 + TaxaJuros), Periodos);
        }   
    }
} 
       
