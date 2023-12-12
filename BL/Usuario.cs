using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Usuario
    {
        //Metodo para insertar la informacion

        public static bool Add(ML.Usuario usuario)
        {
            bool resultado = false;

            try
            {
                // Abrir Conexion

                using (SqlConnection context = new SqlConnection(DL.Conexion.ObtenerConecctionString())) { 

                    var sentencia = " INSERT INTO Usuario(NombreUsuario, ApellidoPUsuario, ApellidoMUsuario, FechaNacUsuario) VALUES (@NombreUsuario, @ApellidoPaterno, @ApellidoMaterno, @FechaNacimiento)";

                SqlParameter[] parameters = new SqlParameter[4];

                //parameters[0] = new SqlParameter("@IdUsuario", SqlDbType.VarChar);
                //parameters[0].Value = usuario.IdUsuario;

                parameters[0] = new SqlParameter("@NombreUsuario", SqlDbType.VarChar);
                parameters[0].Value = usuario.Nombre;

                parameters[1] = new SqlParameter("@ApellidoPaterno", SqlDbType.VarChar);
                parameters[1].Value = usuario.ApellidoPaterno;

                parameters[2] = new SqlParameter("@ApellidoMaterno", SqlDbType.VarChar);
                parameters[2].Value = usuario.ApellidoMaterno;

                parameters[3] = new SqlParameter("@FechaNacimiento", SqlDbType.Date);
                parameters[3].Value = usuario.FechaNacimiento;


                // ejecutar la sentencia

                 SqlCommand command = new SqlCommand(sentencia, context);
                command.Parameters.AddRange(parameters);

                    //abrir conexion
                    command.Connection.Open();
                  

                int filasAfectadas = command.ExecuteNonQuery();
                //Validar si las filas fueron afectadas
                if(filasAfectadas > 0)
                    {
                        resultado = true;
                    }
                    else
                    {
                        resultado = false;
                    }
            }
                // Query, sentencia a ejecutar
                // Cerrar conexión
                // confirmacion, regresar el mensaje

            }catch (Exception ex) //SI FALLÓ ALGO
            {
                resultado = false;
            }
            return resultado;
        }

        public static bool Delete(int idUsuario)
        {
            bool resultadoDelete = false;
            try
            {
                //USING para librerias
                //USING para liberar memoria porque al terminar se destruye


                using (SqlConnection context = new SqlConnection(DL.Conexion.ObtenerConecctionString()))
                {
                    {
                        var sentencia = "DELETE FROM Usuario WHERE IdUsuario = @IdUsuario";

                        SqlParameter[] parametros = new SqlParameter[1];
                        parametros[0] = new SqlParameter("@IdUsuario", SqlDbType.Int);
                        parametros[0].Value = idUsuario;

                        SqlCommand cmd = new SqlCommand(sentencia, context);

                        //leer la informacion

                        cmd.Parameters.AddRange(parametros);

                        cmd.Connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            resultadoDelete = true;
                        }
                        else
                        {
                            resultadoDelete = false;
                        }
                    }
                }
                }catch (Exception ex) {

                resultadoDelete = false;
            }

            return resultadoDelete;


        }

        public static bool Update(ML.Usuario usuario)
        {
            bool resultadoUpdate = false;
            try
            {
                //USING para librerias
                //USING para liberar memoria porque al terminar se destruye


                using (SqlConnection context = new SqlConnection(DL.Conexion.ObtenerConecctionString()))
                {
                    {
                        var sentencia = "UPDATE Usuario SET [Nombre] = ";

                    SqlParameter[] parameters = new SqlParameter[4];

                    parameters[0] = new SqlParameter("@IdUsuario", SqlDbType.VarChar);
                    parameters[0].Value = usuario.IdUsuario;

                    parameters[0] = new SqlParameter("@NombreUsuario", SqlDbType.VarChar);
                    parameters[0].Value = usuario.Nombre;

                    parameters[1] = new SqlParameter("@ApellidoPaterno", SqlDbType.VarChar);
                    parameters[1].Value = usuario.ApellidoPaterno;

                    parameters[2] = new SqlParameter("@ApellidoMaterno", SqlDbType.VarChar);
                    parameters[2].Value = usuario.ApellidoMaterno;

                    parameters[3] = new SqlParameter("@FechaNacimiento", SqlDbType.Date);
                    parameters[3].Value = usuario.FechaNacimiento;


                    SqlCommand cmd = new SqlCommand(sentencia, context);
                    cmd.Parameters.AddRange(parameters);

                    cmd.Connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        resultadoUpdate = true;
                    }
                    else
                    {
                        resultadoUpdate = false;
                    }
                }

                } catch (Exception ex)
            {

                resultadoUpdate = false;
            }

            return resultadoUpdate;
        }

        public static ML.Usuario GetAll()
        {
            ML.Usuario user = new ML.Usuario;
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.ObtenerConecctionString()))
                {
                    string query = "SELECT IdUsuario, Nombre, ApellidoPaterno, ApellidoMaterno, FechaNacimiento FROM Usuario";

                    //CREAR TABLA

                    DataTable tablaUsuario = new DataTable();
                    SqlCommand command = new SqlCommand(query, context);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    adapter.Fill(tablaUsuario);
                    //pasar la info de un dataTable a un ml modelo (ML.Usuario)

                    if(tablaUsuario.Rows.Count > 0)
                    {

                        foreach(DataRow registro in tablaUsuario.Rows)
                        {
                            ML.Usuario usuario = new ML.Usuario();
                            usuario.IdUsuario  = int.Parse(registro[0].ToString());
                            usuario.Nombre = registro[1].ToString();    
                            usuario.ApellidoPaterno = registro[2].ToString();
                            usuario.ApellidoMaterno = registro[3].ToString();   
                            usuario.FechaNacimiento = Datetime.parse(registro[4]);
                        }
                    }
                    else
                    {

                    }
                }
            }catch (Exception ex)
            { 
            
            }
        }
    }
}
