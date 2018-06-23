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

/**
 *
 * @author Nuryan
 */
public class Proveedor {
    public int crearProveedor(String nombres, int telefono, String organizacion, String usuario) {
        int resultado = 0;
        Usuario usu = new Usuario();
        Connection con = Conexion.getConexion();

        String sql = "insert into proveedor(nombre, telefono, organizacion, idPersona) values ('"+
                nombres+"', "+telefono+", '"+organizacion+"',"+usu.getIdPersona(usuario)+")";

        Statement sentencia;
        try {

            sentencia = con.createStatement();
            resultado = sentencia.executeUpdate(sql);

            sentencia.close();
            con.close();
            sql = "";

            if (resultado > 0) {
                return 1;
            } else {
                return 0;
            }
        } catch (Exception e) {
            return -2;
        }
    }

    public ArrayList<String> getNombresProveedoresPorPersona(String usuario) {

        ArrayList<String> devovler = new ArrayList<String>();
        try {
            Usuario usu = new Usuario();
            String sql = "select proveedor.nombre from proveedor inner join persona on proveedor.idPersona = persona.idPersona where proveedor.idPersona =" + usu.getIdPersona(usuario);
            Connection con = Conexion.getConexion();
            ResultSet resul = null;
            Statement sentencia = con.createStatement();

            resul = sentencia.executeQuery(sql);

            while (resul.next()) {
                devovler.add(resul.getString(1));
            }

            con.close();
            resul.close();

            return devovler;
        } catch (Exception e) {
            devovler.add(e.toString());
            return devovler;
        }
    }

    public ArrayList<String> getTelefonoProveedorPorPersona(String usuario) {

        ArrayList<String> devovler = new ArrayList<String>();
        try {
            Usuario usu = new Usuario();
            String sql = "select proveedor.telefono from proveedor inner join persona on proveedor.idPersona = persona.idPersona where proveedor.idPersona =" + usu.getIdPersona(usuario);
            Connection con = Conexion.getConexion();
            ResultSet resul = null;
            Statement sentencia = con.createStatement();

            resul = sentencia.executeQuery(sql);

            while (resul.next()) {
                devovler.add(resul.getString(1));
            }

            con.close();
            resul.close();

            return devovler;
        } catch (Exception e) {
            devovler.add(e.toString());
            return devovler;
        }
    }
    
    public ArrayList<String> getOrganizacionProveedorPorPersona(String usuario) {

        ArrayList<String> devovler = new ArrayList<String>();
        try {
            Usuario usu = new Usuario();
            String sql = "select proveedor.organizacion from proveedor inner join persona on proveedor.idPersona = persona.idPersona where proveedor.idPersona =" + usu.getIdPersona(usuario);
            Connection con = Conexion.getConexion();
            ResultSet resul = null;
            Statement sentencia = con.createStatement();

            resul = sentencia.executeQuery(sql);

            while (resul.next()) {
                devovler.add(resul.getString(1));
            }

            con.close();
            resul.close();

            return devovler;
        } catch (Exception e) {
            devovler.add(e.toString());
            return devovler;
        }
    }

    public int borrarProveedor(String usuario, String telefono) {
        int resultado = 0;
        Usuario usu = new Usuario();
        Connection con = Conexion.getConexion();

        String sql = "delete from proveedor where telefono="+telefono+" and idPersona ="+usu.getIdPersona(usuario);

        Statement sentencia;
        try {

            sentencia = con.createStatement();
            resultado = sentencia.executeUpdate(sql);

            sentencia.close();
            con.close();
            sql = "";

            if (resultado > 0) {
                return 1;
            } else {
                return 0;
            }
        } catch (Exception e) {
            return -2;
        }
    }
}
