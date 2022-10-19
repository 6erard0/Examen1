using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class ClaseVend1 : ClaseVendedores, ClaseInterface.Ivendedor1 //Vendedor al contado//
    {
        private string nombre { get; set; }

        public ClaseVend1(string nombre)
        {
            this.nombre = "Santiago";
        }

        public void ventasContado()
        {
            Console.WriteLine($"Con {nombre}, puede hacer las ventas a Contado");
        }
    }
}
