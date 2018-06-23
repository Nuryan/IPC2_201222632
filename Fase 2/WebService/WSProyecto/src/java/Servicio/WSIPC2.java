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
    public String hello(
            @WebParam(name = "name") String txt) {
        Usuario usu = new Usuario();
        Modulo mod = new Modulo();

        return usu.getIdPersona(txt) + "";
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
    public String prueba(
            @WebParam(name = "Dato1") String dato1,
            @WebParam(name = "Dato2") String dato2,
            @WebParam(name = "Dato3") int dato3) {
        Usuario usu = new Usuario();
        Organizacion orga = new Organizacion();
        Modulo mod = new Modulo();

        return mod.comprarModulo(dato1, dato2, dato3);
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

    @WebMethod(operationName = "getNumModulos")
    public int getNumModulo() {
        return new Modulo().getConteoModulo();
    }

    @WebMethod(operationName = "listarNombresModulos")
    public ArrayList<String> listarNombresModulos() {
        Modulo mod = new Modulo();
        return mod.getNombres();
    }

    @WebMethod(operationName = "listarDescripcionModulos")
    public ArrayList<String> listarDescripcionModulos() {
        Modulo mod = new Modulo();
        return mod.getDescripciones();
    }

    @WebMethod(operationName = "listarPrecioModulos")
    public ArrayList<Float> listarPrecioModulos() {
        Modulo mod = new Modulo();
        return mod.getPrecios();
    }

    @WebMethod(operationName = "comprarModulo")
    public String comprarModulo(
            @WebParam(name = "usuario") String usuario,
            @WebParam(name = "modulo") String modulo,
            @WebParam(name = "meses") int meses) {
        Modulo mod = new Modulo();

        return mod.comprarModulo(usuario, modulo, meses);
    }

    @WebMethod(operationName = "comprarSlots")
    public int comprarSlots(
            @WebParam(name = "usuario") String usuario,
            @WebParam(name = "meses") int meses) {
        Usuario mod = new Usuario();

        return mod.añadirSlotEmpleado(usuario, meses);
    }

    @WebMethod(operationName = "getSaldo")
    public float getSaldo(@WebParam(name = "usuario") String usuario) {
        Usuario usu = new Usuario();
        return usu.getSaldoActual(usuario);
    }
    
    @WebMethod(operationName = "getModulosAdquiridos")
    public ArrayList<String> getModulosAdquiridos(
            @WebParam(name = "usuario")String usuario){
        Modulo mod = new Modulo();
        
        return mod.listarModulosAdquiridos(usuario);
    }
    
    @WebMethod(operationName = "getDetallePersona")
    public ArrayList<String> getDetallePersona(
            @WebParam(name = "usuario")String usuario){
        Usuario usu = new Usuario();
        
        return usu.getDetallePesona(usuario);
    }
    
    @WebMethod(operationName = "getNombresClientes")
    public ArrayList<String> getNombresClientes(
            @WebParam(name = "usuario")String usuario){
        Cliente usu = new Cliente();
        
        return usu.getNombresClientesPorPersona(usuario);
    }
    
    @WebMethod(operationName = "getNitClientes")
    public ArrayList<String> getNitClientes(
            @WebParam(name = "usuario")String usuario){
        Cliente usu = new Cliente();
        
        return usu.getNitClientesPorPersona(usuario);
    }
    
    @WebMethod(operationName = "crearCliente")
    public int crearCliente(
            @WebParam(name = "nombres")String nombres,
            @WebParam(name = "nit")int nit,
            @WebParam(name = "usuario")String usuario){
        Cliente usu = new Cliente();
        
        return usu.crearCliente(nombres, nit, usuario);
    }
    
    @WebMethod(operationName = "eliminarCliente")
    public int eliminarCliente(
            @WebParam(name = "nit")String  nit,
            @WebParam(name = "usuario")String usuario){
        Cliente usu = new Cliente();
        
        return usu.borrarCliente(usuario, nit);
    }
    
    @WebMethod(operationName = "crearProveedor")
    public int crearProveedor(
            @WebParam(name = "nombres")String nombres,
            @WebParam(name = "telefono")int telefono,
            @WebParam(name = "organizacion")String organizacion,
            @WebParam(name = "usuario")String usuario){
        Proveedor usu = new Proveedor();
        
        return usu.crearProveedor(nombres,telefono ,organizacion, usuario);
    }
    
    @WebMethod(operationName = "eliminarProveedor")
    public int eliminarProveedor(
            @WebParam(name = "nombres")String nombres,
            @WebParam(name = "telefono")String telefono){
        Proveedor usu = new Proveedor();
        
        return usu.borrarProveedor(nombres,telefono);
    }
    
    @WebMethod(operationName = "getNombreProveedores")
    public ArrayList<String> getNombreProveedores(
            @WebParam(name = "usuario")String usuario){
        Proveedor usu = new Proveedor();
        
        return usu.getNombresProveedoresPorPersona(usuario);
    }
    
    @WebMethod(operationName = "getTelefonoProveedores")
    public ArrayList<String> getTelefonoProveedores(
            @WebParam(name = "usuario")String usuario){
        Proveedor usu = new Proveedor();
        
        return usu.getTelefonoProveedorPorPersona(usuario);
    }
    
    @WebMethod(operationName = "getOrganizacionProveedores")
    public ArrayList<String> getOrganizacionProveedores(
            @WebParam(name = "usuario")String usuario){
        Proveedor usu = new Proveedor();
        
        return usu.getOrganizacionProveedorPorPersona(usuario);
    }
}
