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
            sql = "SELECT idPersona AS \"id\" FROM persona WHERE email = '" + usuario + "' AND contraseña = MD5('" + contraseña + "')";
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
            return "Error de db";
        }
    }

    @WebMethod(operationName = "prueba")
    public int prueba(@WebParam(name = "Dato1") String dato1,@WebParam(name = "Dato2") String dato2) {
        Usuario usu = new Usuario();
        Organizacion orga = new Organizacion();
        return orga.getParticipacionParticipanteEnOrganizacion(dato1, dato2);
    }

    @WebMethod(operationName = "crearUsuario")
    public String crearUsuario(
            @WebParam(name = "dpi") String dpi,
            @WebParam(name = "nombres") String nombres,
            @WebParam(name = "apellidos") String apellidos,
            @WebParam(name = "contraseña") String contraseña,
            @WebParam(name = "contraseñaRep") String contraseñaRep,
            @WebParam(name = "email") String email) {

        Usuario usu = new Usuario();
        return usu.crearUsuarioLogin(dpi, nombres, apellidos, contraseña, contraseñaRep, email);
    }

    @WebMethod(operationName = "getCargoUsuario")
    public int getCargoUsuario(@WebParam(name = "email") String email) {
        Usuario usu = new Usuario();
        return usu.getCargo(email);
    }

    @WebMethod(operationName = "crearOrganizacion")
    public String crearOrganizacion(
            @WebParam(name = "nombre") String nombre,
            @WebParam(name = "email") String email) {
        Organizacion orga = new Organizacion();
        return orga.crearOrganizacion(nombre, email);
    }

    @WebMethod(operationName = "crearEmpleado")
    public String crearEmpleado(
            @WebParam(name = "dpi") String dpi,
            @WebParam(name = "nombres") String nombres,
            @WebParam(name = "apellidos") String apellidos,
            @WebParam(name = "contraseña") String contraseña,
            @WebParam(name = "contraseñaRep") String contraseñaRep,
            @WebParam(name = "emailEmpleado") String emailEmpleado,
            @WebParam(name = "emailUsuario") String emailUsuario) {
        Usuario us = new Usuario();

        return us.crearEmpleado(dpi, nombres, apellidos, contraseña, contraseñaRep, emailEmpleado, emailUsuario);
    }

    @WebMethod(operationName = "añadirParticipanteAOrganizacion")
    public String añadirParticipanteAOrganizacion(
            @WebParam(name = "email") String email,
            @WebParam(name = "organizacion") String organizacion) {
        Organizacion org = new Organizacion();
        return org.añadirParticipante(email, organizacion);
    }

    @WebMethod(operationName = "listarEmpleados")
    public ArrayList<String> listarEmpleados(
            @WebParam(name = "email") String email) {
        Usuario org = new Usuario();
        return org.listarParticipantes(email);
    }

    @WebMethod(operationName = "listarOrganizaciones")
    public ArrayList<String> listarOrganizaciones(
            @WebParam(name = "email") String email) {
        Organizacion org = new Organizacion();
        return org.listarOrganizaciones(email);
    }
}
