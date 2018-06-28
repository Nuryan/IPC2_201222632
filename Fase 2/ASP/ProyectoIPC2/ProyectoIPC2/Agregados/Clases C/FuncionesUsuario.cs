using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Proyecto_IPC2_v.gato.Agregados.Clases_C
{
    public class FuncionesUsuario
    {
        public static SqlConnection conectar()
        {
            SqlConnection con = new SqlConnection("Data source=DESKTOP-5MGVVA6; Initial Catalog=proyecto1IPC2; User Id=Nuevo; Password=asdf");
            con.Open();
            return con;
        }

        public static int iniciarSesion(string usuario, string contraseña)
        {
            int devolver = -1;

            SqlConnection conexion = conectar();

            SqlCommand comando = new SqlCommand(String.Format("select * from Usuario where correElectronico = '{0}' and PWDCOMPARE('{1}', contraseña) = 1",
                usuario, contraseña), conexion);
            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                devolver = 1;
            }

            conexion.Close();
            return devolver;
        }
        
        public static int crearUsuario(String primerNombre, String segundoNombre, String primerApellido, String segundoApellido, String fechaNacimiento,
            String correoElectronico, String contraseña, String nombreProfesion, String nombreTipoUsuario, String nombrePreguntaContraseña, String respuestaSecreta)
        {
            try
            {
                int profesion = getIdProfesion(nombreProfesion);
                int tipoUsuario = getTipoUsuarioCreacion(nombreTipoUsuario);
                int idPreguntaContraseña = getIdPreguntaSecreta(nombrePreguntaContraseña);
                int resultado = 0;
                SqlConnection conexion = conectar();
                SqlCommand comando = new SqlCommand(string.Format("insert into Usuario(primerNombre, segundoNombre, primerApellido, segundoApellido,fechaNacimiento," +
               "correElectronico, contraseña, profesion, idTipoUsuario, idPreguntasContraseña, respuestaSecreta) values('{0}','{1}','{2}','{3}','{4}'," +
               "'{5}',PWDENCRYPT('{6}'),{7},{8}, {9}, '{10}' )", primerNombre, segundoNombre, primerApellido, segundoApellido, fechaNacimiento,
               correoElectronico, contraseña, profesion, tipoUsuario, idPreguntaContraseña, respuestaSecreta), conexion);

                resultado = comando.ExecuteNonQuery();

                conexion.Close();

                return resultado;
            }
            catch (Exception e)
            {
                return 0;
            }


        }

        public static int getIdProfesion(String nombre)
        {
            int tipoUsuario = -1;

            SqlConnection conexion = conectar();

            SqlCommand comando = new SqlCommand(string.Format("select idProfesion from Profesion where nombre='{0}'", nombre), conexion);

            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                tipoUsuario = lector.GetInt32(0);
            }

            conexion.Close();

            return tipoUsuario;
        }

        public static int getIdPreguntaSecreta(String nombre)
        {
            int tipoUsuario = -1;

            SqlConnection conexion = conectar();

            SqlCommand comando = new SqlCommand(string.Format("select idPreguntasContraseña from PreguntasContraseña where pregunta='{0}'", nombre), conexion);

            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                tipoUsuario = lector.GetInt32(0);
            }

            conexion.Close();

            return tipoUsuario;
        }

        public static int getTipoUsuarioCreacion(String nombre)
        {
            int tipoUsuario = -1;

            SqlConnection conexion = conectar();

            SqlCommand comando = new SqlCommand(string.Format("select idTipoUsuario from TipoUsuario where nombre='{0}'", nombre), conexion);

            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                tipoUsuario = lector.GetInt32(0);
            }

            conexion.Close();

            return tipoUsuario;
        }

        public static int getTipoUsuario(String correo)
        {
            int tipoUsuario=-1;

            SqlConnection conexion = conectar();

            SqlCommand comando = new SqlCommand(string.Format("select idTipoUsuario from usuario where correElectronico='{0}'",correo), conexion);

            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                tipoUsuario = lector.GetInt32(0);
            }

            conexion.Close();

            return tipoUsuario;
        }

        public static int setNumSesion(String correo, int numSesion)
        {
            int resultado = 0;

            SqlConnection conexion = conectar();

            SqlCommand comando = new SqlCommand(string.Format("update Usuario set numSesion = {0} where correElectronico = '{1}'", numSesion, correo), conexion);

            resultado = comando.ExecuteNonQuery();

            conexion.Close();

            return resultado;
        }

        public static int comprobarSesion(String correo, int numSesion)
        {
            int devolver = 0;

            SqlConnection conexion = conectar();

            SqlCommand comando = new SqlCommand(string.Format("select * from Usuario where numSesion = {0} and correElectronico = '{1}'", numSesion, correo), conexion);

            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                conexion.Close();
                return 1;
            }

            

            return devolver;
        }


        public static ArrayList getDatosUsuario(String correo)
        {
            /*
            0>>primer nombre
            1>>segundo nombre
            2>>primer apellido
            3>>segundo Apellido
            4>>fecha nacimiento
            5>>correo Electrnoi
            6>>tipo usuario
            7>>id pregunta secreta
            8>>respuesta secreta
            9>>profesion
            */
            ArrayList devolver = new ArrayList();
            int i = 0;
            SqlConnection conexion = conectar();

            SqlCommand comando = new SqlCommand(string.Format("select primerNombre, segundoNombre, primerApellido, segundoApellido,fechaNacimiento,"+
                " correElectronico,idTipoUsuario, idPreguntasContraseña, respuestaSecreta, profesion from Usuario where correElectronico = '{0}'"
                , correo), conexion);

            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                devolver.Add(lector.GetString(0));
                devolver.Add(lector.GetString(1));
                devolver.Add(lector.GetString(2));
                devolver.Add(lector.GetString(3));
                devolver.Add(lector.GetDateTime(4));
                devolver.Add(lector.GetString(5));
                devolver.Add(lector.GetInt32(6));
                devolver.Add(lector.GetInt32(7));
                devolver.Add(lector.GetString(8));
                devolver.Add(lector.GetInt32(9));
            }

            conexion.Close();

            return devolver;
        }

        public static int modificarDatos(String primernombre,
            String segundoNombre,
            String primerApellido,
            String segundoApellido,
            String fecha,
            String correo,
            String nombreTipoUsuario,
            String nombrePreguntaContraseña,
            String respuesta,
            String nombreProfesion,
            String correoActual)
        {
         try
            {
                int profesion = getIdProfesion(nombreProfesion);
                int idTipoUsuario= getTipoUsuarioCreacion(nombreTipoUsuario);
                int idPreguntas= getIdPreguntaSecreta(nombrePreguntaContraseña);
                int resultado = 0;

                SqlConnection conexion = conectar();

                SqlCommand comando = new SqlCommand(string.Format("update Usuario set primerNombre = '{0}', segundoNombre = '{1}', primerApellido = '{2}',"+
                    "segundoApellido = '{3}', fechaNacimiento = '{4}', correElectronico = '{5}', idTipoUsuario = {6}, idPreguntasContraseña = {7}, "+
                   "respuestaSecreta = '{8}', profesion = {9} where correElectronico = '{10}'",primernombre, segundoNombre, primerApellido, segundoApellido,
                   fecha, correo, idTipoUsuario, idPreguntas, respuesta, profesion, correoActual), conexion);

                resultado = comando.ExecuteNonQuery();

                conexion.Close();

                return resultado;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public static int eliminarUsuario(String correoElectronio)
        {
            int resultado = 0;

            SqlConnection conexion = conectar();

            SqlCommand comando = new SqlCommand(string.Format("delete  from usuario where correElectronico= '{0}';", correoElectronio), conexion);

            resultado = comando.ExecuteNonQuery();

            conexion.Close();

            return resultado;
        }

        public static int cambiarContraseña(String contraseña, String correo)
        {
            int resultado = 0;

            SqlConnection conexion = conectar();

            SqlCommand comando = new SqlCommand(string.Format("update usuario set contraseña = PWDENCRYPT('{0}') where correElectronico = '{1}'", contraseña, correo), conexion);

            resultado = comando.ExecuteNonQuery();

            conexion.Close();

            return resultado;
        }
    }
}