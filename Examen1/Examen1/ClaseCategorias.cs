using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{


    internal class ClaseCategorias
    {
        static int numero;
        List<int> categorias = new List<int>()
        {
            1,
            2,
            3,
        };



        public void promocion()
        {

        }

        public void listaCategorias() //Lista de las categorias 1, 2 y 3//
        {
            Console.WriteLine($"Lista de Categorias: ");
            foreach (var item in categorias)
            {
                Console.WriteLine($"Categoria: {item}");
            }
            Console.WriteLine();
        }


        public bool existeCategoria()
        {
            Console.WriteLine("Seleccione la categoria que desea consultar: ");
            numero = int.Parse(Console.ReadLine());

            if (categorias.Contains(numero))
            {
                Console.WriteLine($"La categoria {numero}");
                return true;
            }
            else
                return true;
        }
    }



}
