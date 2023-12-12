using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DL
{
    public class Conexion
    {
        //Metodo para obtener la cadena de conexion
        //Data Source=.;Initial Catalog=COteroProgramacionNCapas;User ID=sa;Password=*********** 
        //se debe guardar en Appconfig
        public static string ObtenerConecctionString()
        {
           return ConfigurationManager.ConnectionStrings["COteroProgramacionNCapas"].ToString();
        }
    }
}
