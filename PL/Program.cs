using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("*****************************************");
                Console.WriteLine("Elige una de las opciones");
                Console.WriteLine("1. AGREGAR USUARIO");
                Console.WriteLine("2. BORRAR USUARIO");
                Console.WriteLine("3. EDITAR USUARIO");
                Console.WriteLine("4. SALIR");
                Console.WriteLine("***************************************** \n");

                int valor = int.Parse(Console.ReadLine());
                switch (valor)
                {
                    case 1:
                        PL.Usuario.Add();
                        break;
                    case 2:
                        PL.Usuario.Delete();
                        break;
                    case 3:
                        PL.Usuario.Update();
                        break;
                    case 4:
                        salir = true;
                        break;
                    default:
                        Console.Write("Opcion no valida");
                        break;
                }
                Console.ReadKey();

            }
        }
    }
}