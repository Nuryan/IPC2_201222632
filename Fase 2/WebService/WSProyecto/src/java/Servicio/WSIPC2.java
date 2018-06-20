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
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author Nuryan
 */
@WebService(serviceName = "WSIPC2")
public class WSIPC2 {

    private Connection con = null;
    private String sql = "";
    private Statement sentencia = null;

    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "hello")
    public String hello(@WebParam(name = "name") String txt) {
        try {
            String devolver = "";
            con = Conexion.getConexion();
            sql = "select nombres as gua from persona where idPersona = 1";
            ResultSet resultado = null;
            sentencia = con.createStatement();

            resultado = sentencia.executeQuery(sql);
            while (resultado.next()) {
                devolver = resultado.getString("gua");
            }
            resultado.close();
            sentencia.close();
            con.close();
            return devolver;
        } catch (Exception e) {
            return e.toString();
        }
    }

    @WebMethod(operationName = "login")
    public String login(@WebParam(name = "usuario") String usuario, @WebParam(name = "contraseña") String contraseña) {
        try {

            String devolver = "No Encontrado";
            con = Conexion.getConexion();
            sql = "SELECT idPersona AS \"id\" FROM persona WHERE email = '"+usuario+"' AND contraseña = MD5('"+contraseña+"')";
            ResultSet resultado = null;
            sentencia = con.createStatement();

            resultado = sentencia.executeQuery(sql);
            while (resultado.next()) {
                devolver = resultado.getString(1);
            }
            resultado.close();
            sentencia.close();
            con.close();
            return devolver;
        } catch (Exception e) {
            return "No Encontrado";
        }
    }
    
    
    
}
