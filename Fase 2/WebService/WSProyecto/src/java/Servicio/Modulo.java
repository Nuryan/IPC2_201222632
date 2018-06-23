/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Servicio;

import conexion.Conexion;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.Calendar;

/**
 *
 * @author Nuryan
 */
public class Modulo {

    //De la tabla modulo adquirido
    private int idModuloAdquirido, idPersona, idModulo, recontratos;
    private java.util.Calendar fechaCompra; //autogenerado
    private java.util.Calendar fechaFinServicio; //fin del servicio

    //de la tabla modulo
    private int IDModulo;
    private double precio;
    private String nombre, descripcion;

    private Connection con = null;
    private String sql = "";
    private Statement sentencia = null;

    public int getConteoModulo() {
        con = Conexion.getConexion();

        int devolver = -2;

        try {
            sql = "select count(*) from modulo";

            ResultSet resul = null;
            sentencia = con.createStatement();

            resul = sentencia.executeQuery(sql);

            while (resul.next()) {
                devolver = resul.getInt(1);
            }

            con.close();
            resul.close();

            return devolver;
        } catch (Exception e) {
            return -1;
        }
    }

    public ArrayList<String> getNombres() {
        con = Conexion.getConexion();

        int devolver = -2;
        ArrayList<String> listado = new ArrayList<String>();
        try {
            sql = "select nombre from modulo";

            ResultSet resul = null;
            sentencia = con.createStatement();

            resul = sentencia.executeQuery(sql);

            while (resul.next()) {
                listado.add(resul.getString(1));
            }

            con.close();
            resul.close();

            return listado;
        } catch (Exception e) {
            listado.add(e.toString());
            return listado;
        }
    }

    public ArrayList<String> getDescripciones() {
        con = Conexion.getConexion();

        int devolver = -2;
        ArrayList<String> listado = new ArrayList<String>();
        try {
            sql = "select descripcion from modulo";

            ResultSet resul = null;
            sentencia = con.createStatement();

            resul = sentencia.executeQuery(sql);

            while (resul.next()) {
                listado.add(resul.getString(1));
            }

            con.close();
            resul.close();

            return listado;
        } catch (Exception e) {
            listado.add(e.toString());
            return listado;
        }
    }

    public ArrayList<Float> getPrecios() {
        con = Conexion.getConexion();

        int devolver = -2;
        ArrayList<Float> listado = new ArrayList<Float>();
        try {
            sql = "select precio from modulo";

            ResultSet resul = null;
            sentencia = con.createStatement();

            resul = sentencia.executeQuery(sql);

            while (resul.next()) {
                listado.add(resul.getFloat(1));
            }

            con.close();
            resul.close();

            return listado;
        } catch (Exception e) {
            listado.add(new Float(0.0));
            return listado;
        }
    }

    public int getIdModulo(String nombre) {
        con = Conexion.getConexion();

        int devolver = -2;

        try {
            sql = "select idModulo from modulo where nombre = '" + nombre + "'";

            ResultSet resul = null;
            sentencia = con.createStatement();

            resul = sentencia.executeQuery(sql);

            while (resul.next()) {
                devolver = resul.getInt(1);
            }

            return devolver;
        } catch (Exception e) {
            return -1;
        }
    }
//asdf

    public String comprarModulo(String usuario, String modulo, int meses) {
        try {
            Usuario usu = new Usuario();
            String fecha = calcularFecha(meses);
            int resultado = 0, resultado2 = 0;

            Connection con = Conexion.getConexion();

            sql = "INSERT INTO moduloAdquirido(idPersona, idModulo, fechaFinServicio) VALUES ("
                    + usu.getIdPersona(usuario) + "," + getIdModulo(modulo) + ",'" + fecha + "');";
            Statement sentencia = con.createStatement();
            resultado = sentencia.executeUpdate(sql);
            modificarSaldo(usuario, modulo, meses);
            //update persona set saldo = 789 where idPersona = 1
            sentencia.close();
            con.close();
            sql = "";

            if (resultado > 0) {
                return "1";
            } else {
                return "0";
            }
        } catch (Exception e) {
            return e.toString();
        }
    }
    
    

    public ArrayList<String> listarModulosAdquiridos(String usuario) {
        con = Conexion.getConexion();
        Usuario usu = new Usuario();
        int devolver = -2;
        ArrayList<String> listado = new ArrayList<String>();
        try {
            sql = "select modulo.nombre  from modulo inner join moduloAdquirido on modulo.idModulo = moduloAdquirido.idModulo where moduloAdquirido.idPersona = "+usu.getIdPersona(usuario);

            ResultSet resul = null;
            sentencia = con.createStatement();

            resul = sentencia.executeQuery(sql);

            while (resul.next()) {
                listado.add(resul.getString(1));
            }

            con.close();
            resul.close();

            return listado;
        } catch (Exception e) {
            listado.add(e.toString());
            return listado;
        }
    }

    public int modificarSaldo(String usuario, String modulo, int meses) {
        try {
            Usuario usu = new Usuario();
            float saldo = calcularTotalAPagar(modulo, meses);
            sql = "update persona set saldo = saldo + (" + saldo + ") where idPersona = " + usu.getIdPersona(usuario);
            Connection con = Conexion.getConexion();
            Statement sentencia = con.createStatement();

            sentencia = con.createStatement();

            int resul = sentencia.executeUpdate(sql);

            con.close();
            sentencia.close();
            return resul;
        } catch (Exception e) {
            return -2;
        }
    }

    public float calcularTotalAPagar(String modulo, int meses) {
        try {
            sql = "select precio from modulo where idModulo = " + getIdModulo(modulo);
            float devolver = 0;
            Connection con = Conexion.getConexion();
            Statement sentencia = con.createStatement();

            ResultSet resul = null;
            sentencia = con.createStatement();

            resul = sentencia.executeQuery(sql);

            while (resul.next()) {
                devolver = resul.getFloat(1);
            }
            con.close();
            resul.close();
            return devolver * meses;
        } catch (Exception e) {
            return -2;
        }
    }

    private String calcularFecha(int meses) {
        Calendar c = Calendar.getInstance();
        int dia = c.get(Calendar.DATE);
        int mes = c.get(Calendar.MONTH) + meses;
        int año = c.get(Calendar.YEAR);

        while (mes > 12) {
            año++;
            mes = mes - 12;
        }

        return año + "/" + mes + "/" + dia;
    }
}
