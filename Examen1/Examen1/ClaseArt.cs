using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    public class ClaseArt //Clase de Articulos//
    {
        static private int i, opcion, x, num = 0, total;
        protected int codigo { get; set; }
        protected string nombre { get; set; }
        protected int precio { get; set; }

        public ClaseArt(int codigo, string nombre, int precio)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
        }

        public ClaseArt()
        {

        }


        static ClaseArt[] listaArticulos = new ClaseArt[5];
        public void agregarArticulo()
        {

            for (i = 0; i < listaArticulos.Length; i++)
            {
                Console.WriteLine($"Ingrese número del codigo del Articulo  {num + 1}");
                codigo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el nombre del Articulo");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el precio del Articulo");
                precio = int.Parse(Console.ReadLine());

                listaArticulos[i] = new ClaseArt(codigo, nombre, precio);
                num++;
            }
            Console.WriteLine("Presione Tab para continuar");
            Console.ReadKey();

        }

        public void removerArticulo()
        {

            verArticulos();

            Console.WriteLine("Ingrese número de Codigo del articulo que desea borrar");
            opcion = int.Parse(Console.ReadLine());
            for (x = 0; x < listaArticulos.Length; x++)
            {
                if (listaArticulos[x].codigo == opcion)
                {
                    listaArticulos[x].codigo = 0;
                    listaArticulos[x].nombre = "";
                    listaArticulos[x].precio = 0;
                    Console.WriteLine("El articulo ha sido borrado\n");
                }
                else
                {
                    Console.WriteLine("El articulo que ingresó no existe");
                }
            }


        }

        public void verArticulos()
        {
            Console.WriteLine("Detalles de los articulos:\n");
            for (x = 0; x < listaArticulos.Length; x++)
            {
                Console.WriteLine($"Codigo: {listaArticulos[x].codigo} Precio: {listaArticulos[x].precio} Nombre: {listaArticulos[x].nombre}");
            }
            Console.WriteLine("\nFin de los detalles consultados\n");
        }

        public void venta()
        {
            Console.WriteLine("Consultar si hay existencias. \nIngrese el Codigo del articulo:");
            opcion = int.Parse(Console.ReadLine());
            for (x = 0; x < listaArticulos.Length; x++)
            {
                if (listaArticulos[x].codigo == opcion)
                {
                    Console.WriteLine($"Detalles del producto. \nPrecio: {listaArticulos[x].precio} \nNombre: {listaArticulos[x].nombre}");
                    Console.WriteLine("\n¿Cuantos desea comprar?");
                    opcion = int.Parse(Console.ReadLine());
                    total = opcion * listaArticulos[x].precio;
                    Console.WriteLine($"\nEl monto total a cancelar es {total}");

                }
                else
                {
                    Console.WriteLine("El producto no existe");
                }

            }
        }

        public void existenciaArticulo()
        {
            Console.WriteLine("Consultar si hay existencia. \nIngrese el Codigo del articulo:");
            opcion = int.Parse(Console.ReadLine());
            for (x = 0; x < listaArticulos.Length; x++)
            {
                if (listaArticulos[x].codigo == opcion)
                {
                    Console.WriteLine($"Detalles del producto. \nPrecio: {listaArticulos[x].precio} \nNombre: {listaArticulos[x].nombre}");
                }
                else
                {
                    Console.WriteLine("El producto que usted ha seleccionado no existe");
                }

            }

        }
    }
}