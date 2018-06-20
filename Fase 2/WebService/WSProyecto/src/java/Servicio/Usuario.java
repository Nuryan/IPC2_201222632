/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Servicio;

import conexion.Conexion;
import java.math.BigInteger;
import java.sql.Connection;
import java.sql.Date;
import java.sql.Statement;

/**
 *
 * @author Nuryan
 */
public class Usuario {

    private int idPersona;
    private java.math.BigInteger dpi;
    private String nombres;
    private String apellidos;
    private String organizacion;
    private java.sql.Date nacimiento;
    private String residencia;
    private int idCargo;
    private String email;

    private Connection con = null;
    private String sql = "";
    private Statement sentencia = null;

    public Usuario(int idPersona, BigInteger dpi, String nombres, String apellidos, String organizacion, Date nacimiento, String residencia, int idCargo, String email) {
        this.idPersona = idPersona;
        this.dpi = dpi;
        this.nombres = nombres;
        this.apellidos = apellidos;
        this.organizacion = organizacion;
        this.nacimiento = nacimiento;
        this.residencia = residencia;
        this.idCargo = idCargo;
        this.email = email;
    }

    public int crearUsuarioLogin(String dpi, String nombres, String apellidos, String contraseña, String contraseñaRep, String email) {
        int resultado = -1;
        if(){
            
        }
        
        con = Conexion.getConexion();

        sql= "insert into persona(dpi, nombre, apellidos, email, contraseña) values ()";
        
        return resultado;
    }

    public int existeUsuario(String email){
        con = Conexion.getConexion();
        int resultado = -1;
        
        try{
            
        }catch(Exception e){
            return -2;
        }
    }
    
    /**
     * @return the idPersona
     */
    public int getIdPersona() {
        return idPersona;
    }

    /**
     * @param idPersona the idPersona to set
     */
    public void setIdPersona(int idPersona) {
        this.idPersona = idPersona;
    }

    /**
     * @return the dpi
     */
    public java.math.BigInteger getDpi() {
        return dpi;
    }

    /**
     * @param dpi the dpi to set
     */
    public void setDpi(java.math.BigInteger dpi) {
        this.dpi = dpi;
    }

    /**
     * @return the nombres
     */
    public String getNombres() {
        return nombres;
    }

    /**
     * @param nombres the nombres to set
     */
    public void setNombres(String nombres) {
        this.nombres = nombres;
    }

    /**
     * @return the apellidos
     */
    public String getApellidos() {
        return apellidos;
    }

    /**
     * @param apellidos the apellidos to set
     */
    public void setApellidos(String apellidos) {
        this.apellidos = apellidos;
    }

    /**
     * @return the organizacion
     */
    public String getOrganizacion() {
        return organizacion;
    }

    /**
     * @param organizacion the organizacion to set
     */
    public void setOrganizacion(String organizacion) {
        this.organizacion = organizacion;
    }

    /**
     * @return the nacimiento
     */
    public java.sql.Date getNacimiento() {
        return nacimiento;
    }

    /**
     * @param nacimiento the nacimiento to set
     */
    public void setNacimiento(java.sql.Date nacimiento) {
        this.nacimiento = nacimiento;
    }

    /**
     * @return the residencia
     */
    public String getResidencia() {
        return residencia;
    }

    /**
     * @param residencia the residencia to set
     */
    public void setResidencia(String residencia) {
        this.residencia = residencia;
    }

    /**
     * @return the idCargo
     */
    public int getIdCargo() {
        return idCargo;
    }

    /**
     * @param idCargo the idCargo to set
     */
    public void setIdCargo(int idCargo) {
        this.idCargo = idCargo;
    }

    /**
     * @return the email
     */
    public String getEmail() {
        return email;
    }

    /**
     * @param email the email to set
     */
    public void setEmail(String email) {
        this.email = email;
    }

}
