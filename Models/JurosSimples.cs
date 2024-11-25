using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace juros.Models
{
    public class JurosSimples
    {
        public double Principal { get; set; }
        public double TaxaJuros { get; set; }
        public int Periodos { get; set; }

        public double CalcularJurosSimples()
        {
            return Principal + (Principal * TaxaJuros * Periodos);
        }   
    }
} 
       
