using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Usuario
    {
        public Usuario() { }
        public Usuario(int idsuario, string nombre, string apellidoPUsuario, string apellidoMUsuario, DateTime fecNacimiento)
        {

            IdUsuario = idsuario;
            Nombre = nombre;
            ApellidoPaterno = apellidoPUsuario;
            ApellidoMaterno = apellidoMUsuario;
            FechaNacimiento = fecNacimiento;
        }

        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
