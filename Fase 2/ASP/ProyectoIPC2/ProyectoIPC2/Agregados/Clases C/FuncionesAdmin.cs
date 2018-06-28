using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Proyecto_IPC2_v.gato.Agregados.Clases_C
{
    public class FuncionesAdmin
    {
        public static SqlConnection conectar()
        {
            SqlConnection con = new SqlConnection("Data source=DESKTOP-5MGVVA6; Initial Catalog=proyecto1IPC2; User Id=Nuevo; Password=asdf");
            con.Open();
            return con;
        }

        public static int crearLicencia(String nombre, String descripcion)
        {
            try
            {
                int resultado = 0;
                SqlConnection conexion = conectar();
                SqlCommand comando = new SqlCommand(string.Format("insert into Licencia (nombre, descripcion) values('{0}', '{1}')",  nombre, descripcion), conexion);

                resultado = comando.ExecuteNonQuery();

                conexion.Close();

                return resultado;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public static String[] getDatosDeLicencia(String nombreLicencia)
        {
            String[] devolver = new String[2];
            SqlConnection conexion = conectar();

            SqlCommand comando = new SqlCommand(string.Format("select nombre, descripcion from Licencia where nombre ='{0}'", nombreLicencia), conexion);

            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                devolver[0] = lector.GetString(0);
                devolver[1] = lector.GetString(1);
            }

            conexion.Close();

            return devolver;
        }

        public static int eliminarLicencia(String nombre)
        {
            int resultado = 0;

            SqlConnection conexion = conectar();

            SqlCommand comando = new SqlCommand(string.Format("delete from Licencia where nombre = '{0}'", nombre), conexion);

            resultado = comando.ExecuteNonQuery();

            conexion.Close();

            return resultado;
        }

        public static int modificarDatosDeLicencia(String nombre, String descripcion, String nombreActual)
        {
            try
            {
                int resultado = 0;

                SqlConnection conexion = conectar();

                SqlCommand comando = new SqlCommand(string.Format("update Licencia set nombre='{0}', descripcion= '{1}' where nombre ='{2}'", 
                    nombre, descripcion, nombreActual), conexion);

                resultado = comando.ExecuteNonQuery();

                conexion.Close();

                return resultado;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public static int añadirEmpresa(
            String nombre,
            String urlPropia,
            String urlFacebook,
            String urlTwitter)
        {
            try
            {
                int resultado = 0;
                SqlConnection conexion = conectar();
                SqlCommand comando = new SqlCommand(string.Format("insert into Empresa(nombre, urlEmpresa, linkFacebook, linkTwitter) values('{0}','{1}','{2}','{3}')", nombre, urlPropia, urlFacebook, urlTwitter), conexion);

                resultado = comando.ExecuteNonQuery();

                conexion.Close();

                return resultado;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public static int eliminarEmpresa(String nombre)
        {
            int resultado = 0;

            SqlConnection conexion = conectar();

            SqlCommand comando = new SqlCommand(string.Format("delete from Empresa where nombre = '{0}'", nombre), conexion);

            resultado = comando.ExecuteNonQuery();

            conexion.Close();

            return resultado;
        }

        public static String[] getInfoEmpresa(String nombre)
        {
            String[] devolver = new String[4];
            SqlConnection conexion = conectar();

            SqlCommand comando = new SqlCommand(string.Format("select * from empresa where nombre = '{0}'", nombre), conexion);

            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                devolver[0] = lector.GetString(1);
                devolver[1] = lector.GetString(2);
                devolver[2] = lector.GetString(3);
                devolver[3] = lector.GetString(4);
            }

            conexion.Close();

            return devolver;
        }

        public static int modificarEmpresa(
            String nombre,
            String urlPropia,
            String urlFacebook,
            String urlTwitter,
            String nombreActual)
        {
            try
            {
                int resultado = 0;

                SqlConnection conexion = conectar();

                SqlCommand comando = new SqlCommand(string.Format("update Empresa set nombre = '{0}', urlEmpresa = '{1}', linkFacebook='{2}', linkTwitter='{3}' where nombre = '{4}'",
                    nombre, urlPropia, urlFacebook, urlTwitter, nombreActual), conexion);

                resultado = comando.ExecuteNonQuery();

                conexion.Close();

                return resultado;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public static int añadirPlataforma(String nombre)
        {
            try
            {
                int resultado = 0;
                SqlConnection conexion = conectar();
                SqlCommand comando = new SqlCommand(string.Format("insert into plataforma(nombre) values('{0}')", nombre), conexion);

                resultado = comando.ExecuteNonQuery();

                conexion.Close();

                return resultado;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public static int modificarPlataforma(String nombreNuevo, String nombreActual)
        {
            try
            {
                int resultado = 0;

                SqlConnection conexion = conectar();

                SqlCommand comando = new SqlCommand(string.Format("update plataforma set nombre = '{0}' where nombre = '{1}'", nombreNuevo, nombreActual), conexion);

                resultado = comando.ExecuteNonQuery();

                conexion.Close();

                return resultado;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public static int eliminarPlataforma(String nombre)
        {
            int resultado = 0;

            SqlConnection conexion = conectar();

            SqlCommand comando = new SqlCommand(string.Format("delete from plataforma where nombre = '{0}'", nombre), conexion);

            resultado = comando.ExecuteNonQuery();

            conexion.Close();

            return resultado;
        }

        public static int eliminiarProfesion(String nombre)
        {
            int resultado = 0;

            SqlConnection conexion = conectar();

            SqlCommand comando = new SqlCommand(string.Format("delete from Profesion where nombre = '{0}'", nombre), conexion);

            resultado = comando.ExecuteNonQuery();

            conexion.Close();

            return resultado;
        }

        public static int crearProfesion(String nombre)
        {
            try
            {
                int resultado = 0;
                SqlConnection conexion = conectar();
                SqlCommand comando = new SqlCommand(string.Format("insert into profesion(nombre) values('{0}')", nombre), conexion);

                resultado = comando.ExecuteNonQuery();

                conexion.Close();

                return resultado;
            }
            catch (Exception e)
            {
                return 0;
            }

        }

        public static int modificarProfesion(String nombreNuevo, String nombreActual)
        {
            try
            {
                int resultado = 0;

                SqlConnection conexion = conectar();

                SqlCommand comando = new SqlCommand(string.Format("update profesion set nombre = '{0}' where nombre = '{1}'", nombreNuevo, nombreActual), conexion);

                resultado = comando.ExecuteNonQuery();

                conexion.Close();

                return resultado;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public static int crearCategoria(String nombre, String descripcion)
        {
            try
            {
                int resultado = 0;
                SqlConnection conexion = conectar();
                SqlCommand comando = new SqlCommand(string.Format("insert into Categoria(nombre, descripcion) values('{0}', '{1}')", nombre,descripcion), conexion);

                resultado = comando.ExecuteNonQuery();

                conexion.Close();

                return resultado;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public static int modificarCategoria(String nombreNuevo, String descripcion, String nombreActual)
        {
            try
            {
                int resultado = 0;

                SqlConnection conexion = conectar();

                SqlCommand comando = new SqlCommand(string.Format("update Categoria set nombre = '{0}', descripcion='{1}' where nombre = '{2}'", nombreNuevo, descripcion, nombreActual), conexion);

                resultado = comando.ExecuteNonQuery();

                conexion.Close();

                return resultado;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public static int eliminiarCategoria(String nombre)
        {
            int resultado = 0;

            SqlConnection conexion = conectar();

            SqlCommand comando = new SqlCommand(string.Format("delete from Categoria where nombre = '{0}'", nombre), conexion);

            resultado = comando.ExecuteNonQuery();

            conexion.Close();

            return resultado;
        }

        public static String[] getInfoCategoria(String nombre)
        {
            String[] devolver = new String[2];
            SqlConnection conexion = conectar();

            SqlCommand comando = new SqlCommand(string.Format("select * from Categoria where nombre = '{0}'", nombre), conexion);

            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                devolver[0] = lector.GetString(1);
                devolver[1] = lector.GetString(2);
            }

            conexion.Close();

            return devolver;
        }

        public static int añadirSoftware(
            String nombre,
            String descripcion,
            String direccionURL,
            String direccionFB,
            String direccionTwitter,
            int cantidadUsuarios,
            int idLicencia,
            int trial,
            int soporte,
            String fecha,
            int idEmpresa,
            int idPago,
            double monto)
        {
            try
            {
                int resultado = 0;
                SqlConnection conexion = conectar();
                SqlCommand comando = new SqlCommand(string.Format("insert into Software(nombre, descripcion, direccionURL, urlFB, urlTwitter, cantidadUsuarios, idLicencia, tieneTrial, tieneSoporte, fechaCreacion, idEmpresa, idPago, monto)" +
                    "values('{0}', '{1}', '{2}', '{3}', '{4}', {5}, {6}, {7}, {8}, '{9}', {10}, {11}, {12})",
                    nombre, descripcion, direccionURL, direccionFB, direccionTwitter, cantidadUsuarios, idLicencia, trial, soporte, fecha, idEmpresa, idPago, monto), conexion);

                resultado = comando.ExecuteNonQuery();

                conexion.Close();

                return resultado;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public static int getIDLicencia(String nombre)
        {
            int tipoUsuario = -1;

            SqlConnection conexion = conectar();

            SqlCommand comando = new SqlCommand(string.Format("select idLicencia from licencia where nombre ='{0}'", nombre), conexion);

            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                tipoUsuario = lector.GetInt32(0);
            }

            conexion.Close();

            return tipoUsuario;
        }
        public static int getIDEmpresa(String nombre)
        {
            int tipoUsuario = -1;

            SqlConnection conexion = conectar();

            SqlCommand comando = new SqlCommand(string.Format("select idEmpresa from empresa where nombre ='{0}'", nombre), conexion);

            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                tipoUsuario = lector.GetInt32(0);
            }

            conexion.Close();

            return tipoUsuario;
        }

        public static int getIDPago(String nombre)
        {
            int tipoUsuario = -1;

            SqlConnection conexion = conectar();

            SqlCommand comando = new SqlCommand(string.Format("select idPago from Pago where nombre ='{0}'", nombre), conexion);

            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                tipoUsuario = lector.GetInt32(0);
            }

            conexion.Close();

            return tipoUsuario;
        }

        public static Object[] getInfoSoftware(String nombre)
        {
            Object[] devolver = new Object[13];
            SqlConnection conexion = conectar();

            SqlCommand comando = new SqlCommand(string.Format("select Software.nombre, Software.descripcion, Software.direccionURL,"+
                " Software.urlFB, Software.urlTwitter, Software.cantidadUsuarios,"+
                " Licencia.nombre, Software.tieneTrial, Software.tieneSoporte, Software.fechaCreacion, Empresa.nombre, Pago.nombre, Software.monto"+
                " from Software"+
                " inner join Licencia on Software.idLicencia = Licencia.idLicencia"+
                " inner join Empresa on Software.idEmpresa = Empresa.idEmpresa"+
                " inner join Pago on Software.idPago = Pago.idPago"+
                " where Software.nombre = '{0}'", nombre), conexion);

            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                devolver[0] = lector.GetString(0);
                devolver[1] = lector.GetString(1);
                devolver[2] = lector.GetString(2);
                devolver[3] = lector.GetString(3);
                devolver[4] = lector.GetString(4);
                devolver[5] = lector.GetInt32(5);
                devolver[6] = lector.GetString(6);
                devolver[7] = lector.GetInt32(7);
                devolver[8] = lector.GetInt32(8);
                devolver[9] = lector.GetDateTime(9);
                devolver[10] = lector.GetString(10);
                devolver[11] = lector.GetString(11);
                devolver[12] = lector.GetDouble(12);
            }

            conexion.Close();

            return devolver;
        }

        public static int modificarSoftware(
            String nombre,
            String descripcion,
            String direccionURL,
            String direccionFB,
            String direccionTwitter,
            int cantidadUsuarios,
            int idLicencia,
            int trial,
            int soporte,
            String fecha,
            int idEmpresa,
            int idPago,
            double monto,
            String nombreActual)
        {
            try
            {
                int resultado = 0;

                SqlConnection conexion = conectar();

                SqlCommand comando = new SqlCommand(string.Format("update Software set nombre = '{0}', descripcion = '{1}', direccionURL = '{2}',"+
                    " urlFB = '{3}', urlTwitter = '{4}', cantidadUsuarios = {5}, tieneTrial = {6}, tieneSoporte = {7}, fechaCreacion = '{8}',"+
                    " idEmpresa = {9}, idPago = {10}, idLicencia = {11}, monto = {12} where nombre = '{13}'", nombre, descripcion, direccionURL,
                    direccionFB, direccionTwitter, cantidadUsuarios, trial, soporte, fecha, idEmpresa, idPago, idLicencia, monto, nombreActual), conexion);

                resultado = comando.ExecuteNonQuery();

                conexion.Close();

                return resultado;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public static int eliminarSoftware(String nombre)
        {
            int resultado = 0;

            SqlConnection conexion = conectar();

            SqlCommand comando = new SqlCommand(string.Format("delete from Software where nombre = '{0}'", nombre), conexion);

            resultado = comando.ExecuteNonQuery();

            conexion.Close();

            return resultado;
        }

        public static int añadirCategoriaASoftware(int idSoftware, int idCategoria)
        {
            try
            {
                int resultado = 0;
                SqlConnection conexion = conectar();
                SqlCommand comando = new SqlCommand(string.Format("insert into CategoriaDelSoftware(idSoftware, idCategoria) values('{0}','{1}')", idSoftware, idCategoria), conexion);

                resultado = comando.ExecuteNonQuery();

                conexion.Close();

                return resultado;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public static int getIDSoftware(String nombre)
        {
            int tipoUsuario = -1;

            SqlConnection conexion = conectar();

            SqlCommand comando = new SqlCommand(string.Format("select idSoftware from Software where nombre = '{0}'", nombre), conexion);

            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                tipoUsuario = lector.GetInt32(0);
            }

            conexion.Close();

            return tipoUsuario;
        }

        public static int getIDCategoria(String nombre)
        {
            int tipoUsuario = -1;

            SqlConnection conexion = conectar();

            SqlCommand comando = new SqlCommand(string.Format("select idCategoria from Categoria where nombre='{0}'", nombre), conexion);

            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                tipoUsuario = lector.GetInt32(0);
            }

            conexion.Close();

            return tipoUsuario;
        }

        public static int eliminarCategoriaDeSoftware(int idSoftware, int idCategoria)
        {
            int resultado = 0;

            SqlConnection conexion = conectar();

            SqlCommand comando = new SqlCommand(string.Format("delete from CategoriaDelSoftware where idSoftware = {0} and idCategoria = {1}", idSoftware, idCategoria), conexion);

            resultado = comando.ExecuteNonQuery();

            conexion.Close();

            return resultado;
        }





        public static int crearMetrica(String nombre, String descripcion, int idSoftware)
        {
            try
            {
                int resultado = 0;
                SqlConnection conexion = conectar();
                SqlCommand comando = new SqlCommand(string.Format("insert into Metrica (nombre, descripcion, idSoftware) values('{0}', '{1}', {2})", nombre, descripcion, idSoftware), conexion);

                resultado = comando.ExecuteNonQuery();

                conexion.Close();

                return resultado;
            }
            catch (Exception e)
            {
                return 0;
            }

        }

        public static int getIDMetrica(String nombre, int idSoftware)
        {
            int tipoUsuario = -1;

            SqlConnection conexion = conectar();

            SqlCommand comando = new SqlCommand(string.Format("select Metrica.idMetrica from Metrica where nombre='{0}' and idSoftware ={1}", nombre, idSoftware), conexion);

            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                tipoUsuario = lector.GetInt32(0);
            }

            conexion.Close();

            return tipoUsuario;
        }

        public static String[] getInfoMetrica(int idMetrica, int idSoftware)
        {
            String[] devolver = new String[2];
            SqlConnection conexion = conectar();

            SqlCommand comando = new SqlCommand(string.Format("select Metrica.nombre, Metrica.descripcion from Metrica where idMetrica={0} and idSoftware ={1}",idMetrica, idSoftware ), conexion);

            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                devolver[0] = lector.GetString(0);
                devolver[1] = lector.GetString(1);
            }

            conexion.Close();

            return devolver;
        }

        public static int modificarMetrica(String nombre, String descripcion, int idMetrica, int idSoftware)
        {
            try
            {
                int resultado = 0;

                SqlConnection conexion = conectar();

                SqlCommand comando = new SqlCommand(string.Format("update Metrica set nombre = '{0}', descripcion='{1}'"+ 
                    " where idMetrica = {2} and idSoftware = {3}", nombre, descripcion, idMetrica, idSoftware), conexion);

                resultado = comando.ExecuteNonQuery();

                conexion.Close();

                return resultado;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public static int eliminarMetrica(int idMetrica, int idSoftware)
        {
            int resultado = 0;

            SqlConnection conexion = conectar();

            SqlCommand comando = new SqlCommand(string.Format("delete from Metrica where idMetrica = {0} and idSoftware = {1}", idMetrica, idSoftware), conexion);

            resultado = comando.ExecuteNonQuery();

            conexion.Close();

            return resultado;
        }

       

    }
}