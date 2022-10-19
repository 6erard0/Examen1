using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class ClaseVend2 : ClaseVendedores, ClaseInterface.Ivendedor2 //Vendedor a crédito//
    {
        private string nombre { get; set; }

        public ClaseVend2(string nombre)
        {
            this.nombre = "Carlos";
        }


        public string ventasCredito()
        {
            return $"Con {nombre}, puede hacer las ventas a credito";

        }
    }
}
