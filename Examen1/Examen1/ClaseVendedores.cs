using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class ClaseVendedores //Comandos de Ambos vendedores//
    {
        public string nombre { get; set; }
        static int codVendedor;
        public ClaseVendedores() { }


        private static Dictionary<int, string> listaVendedores = new Dictionary<int, string>()
        {
            {1, "Santiago"},
            {2, "Carlos"}
        };

        public void listadoVendedores()
        {
            foreach (var item in listaVendedores)
            {
                Console.WriteLine($"El codigo del Vendedor {item.Key} nombre {item.Value}");
            }
            Console.WriteLine("\n");
        }

        public string consultaVendedor()
        {

            Console.WriteLine("Ingrese el codigo del Vendedor");
            codVendedor = int.Parse(Console.ReadLine());
            if (listaVendedores.TryGetValue(codVendedor, out string resultado))
            {
                return "El nombre del vendedor es " + resultado + "\n";
            }
            else
            {
                return "El nombre del vendedor que usted ingresó no existe. \n";
            }

        }

    }
}
