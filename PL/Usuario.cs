using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    internal class Usuario
    {
        //Metodo para pedir la informacion

        public static void Add()     //SELECT * - GetAll
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Ingresa el nombre del usuario");
            //string nombre = Console.ReadLine();
            usuario.Nombre = Console.ReadLine();

            Console.WriteLine("Ingresa el Apellido Paterno del usuario");
           // string apellidoPaterno = Console.ReadLine();
           usuario.ApellidoPaterno = Console.ReadLine();

            Console.WriteLine("Ingresa el Apellido Materno del usuario");
            // string apellidoMaterno = Console.ReadLine();
            usuario.ApellidoMaterno = Console.ReadLine();

            Console.WriteLine("Ingresa la Fecha de Nacimiento del usuario (MM/DD/AAAA");
            //edad = int.Parse(Console.ReadLine());
            usuario.FechaNacimiento = DateTime.Parse(Console.ReadLine());

            bool resutaldo = BL.Usuario.Add(usuario);
            if (resutaldo == true)
            {
                Console.WriteLine("Se inserto tu registro!");
            }
            else
            {
                Console.WriteLine("NO se inserto el registro");
            }
            Console.ReadKey();
        }

        public static void Delete()
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Ingrese el ID del usuario a eliminar");
            usuario.IdUsuario = int.Parse(Console.ReadLine());

           // BL.Usuario.Delete();
        }

        public static void Update()
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Ingresa el ID del usuario a modificar");
            //string nombre = Console.ReadLine();
            usuario.Nombre = Console.ReadLine();

            Console.WriteLine("Ingresa el nombre del usuario");
            //string nombre = Console.ReadLine();
            usuario.Nombre = Console.ReadLine();

            Console.WriteLine("Ingresa el Apellido Paterno del usuario");
            // string apellidoPaterno = Console.ReadLine();
            usuario.ApellidoPaterno = Console.ReadLine();

            Console.WriteLine("Ingresa el Apellido Materno del usuario");
            // string apellidoMaterno = Console.ReadLine();
            usuario.ApellidoMaterno = Console.ReadLine();

            Console.WriteLine("Ingresa la Fecha de Nacimiento del usuario (MM/DD/AAAA");
            //edad = int.Parse(Console.ReadLine());
            usuario.FechaNacimiento = DateTime.Parse(Console.ReadLine());

          
            bool resutaldo = BL.Usuario.Update(usuario);
            if (resutaldo == true)
            {
                Console.WriteLine("Se actualizó el registro!");
            }
            else
            {
                Console.WriteLine("NO se actualizo el registro");
            }
            Console.ReadKey();


        }

        public static void Getall()
        {
            BL.Usuario.
        }

    }

}
