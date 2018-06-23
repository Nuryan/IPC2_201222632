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
public class Cliente {

    public int crearCliente(String nombres, int nit, String usuario) {
        int resultado = 0;
        Usuario usu = new Usuario();
        Connection con = Conexion.getConexion();

        String sql = "insert into cliente (nit, nombre, idPersona) values(" + nit + ", '" + nombres + "'," + usu.getIdPersona(usuario) + ")";

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

    public ArrayList<String> getNombresClientesPorPersona(String usuario) {

        ArrayList<String> devovler = new ArrayList<String>();
        try {
            Usuario usu = new Usuario();
            String sql = "select cliente.nombre from cliente inner join persona on cliente.idPersona = persona.idPersona where cliente.idPersona =" + usu.getIdPersona(usuario);
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

    public ArrayList<String> getNitClientesPorPersona(String usuario) {

        ArrayList<String> devovler = new ArrayList<String>();
        try {
            Usuario usu = new Usuario();
            String sql = "select cliente.nit from cliente inner join persona on cliente.idPersona = persona.idPersona where cliente.idPersona =" + usu.getIdPersona(usuario);
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

    public int borrarCliente(String usuario, String nit) {
        int resultado = 0;
        Usuario usu = new Usuario();
        Connection con = Conexion.getConexion();

        String sql = "delete from cliente where nit ="+nit+" and idPersona ="+usu.getIdPersona(usuario);

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
