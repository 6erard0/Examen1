using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{

    public static class ClaseMenu // Menú para los detalles de la consola//
    {
        static int opcion;
        static bool estadia = true;

        static ClaseArt articulo = new ClaseArt();
        static ClaseVendedores vendedor = new ClaseVendedores();
        static ClaseCategorias categorias = new ClaseCategorias();

        public static void menu()
        {

            do
            {
                Console.WriteLine("Menu inicial" + "\n1-Articulos. \n2-Facturacion. \n3-Reporte. \n4-Salir. " +
                 "Digite la opcion que desea seleccionar: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Seccion de Articulos. \nIngrese la opcion que desea realizar: \n  \n1-Agregar Articulos \n2-Remover Articulos \n3-Consultar Articulo");
                        opcion = int.Parse(Console.ReadLine());

                        switch (opcion)
                        {
                            case 1:
                                articulo.agregarArticulo();
                                break;
                            case 2:
                                articulo.removerArticulo();
                                break;
                            case 3:
                                articulo.existenciaArticulo();
                                break;
                            default:
                                Console.WriteLine("La opcion que selecciono no existe");
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Facturacion.");
                        articulo.venta();
                        Console.WriteLine(vendedor.consultaVendedor());

                        break;
                    case 3:
                        articulo.verArticulos();
                        vendedor.listadoVendedores();
                        categorias.listaCategorias();

                        break;
                    case 4:
                        Console.WriteLine("Usted ha salido del Sistema de consultas.");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("La opcion ingresada no es valida. \nTrate de nuevo.\n");

                        break;


                }
            } while (opcion != 4);
            Console.Write("Gracias por las consultas. \nLe esperamos pronto");




        }
    }
}
