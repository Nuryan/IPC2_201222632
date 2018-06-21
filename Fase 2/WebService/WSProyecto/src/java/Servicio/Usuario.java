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
import java.sql.ResultSet;
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
    private int cargo;

    private Connection con = null;
    private String sql = "";
    private Statement sentencia = null;

    public Usuario(int idPersona, BigInteger dpi, String nombres, String apellidos, String organizacion, Date nacimiento, String residencia, int idCargo, String email, int cargo) {
        this.idPersona = idPersona;
        this.dpi = dpi;
        this.nombres = nombres;
        this.apellidos = apellidos;
        this.organizacion = organizacion;
        this.nacimiento = nacimiento;
        this.residencia = residencia;
        this.idCargo = idCargo;
        this.email = email;
        this.cargo = cargo;
    }

    public Usuario() {
    }

    public String crearUsuarioLogin(String dpi, String nombres, String apellidos, String contraseña, String contraseñaRep, String email) {
        int resultado = 0;

        con = Conexion.getConexion();
        if (!contraseña.equals(contraseñaRep)) {
            return "Contraseñas no iguales";
        }

        if (existeUsuario(email) == 1) {
            return "El Usuario ya existe";
        }
        sql = "insert into persona(dpi, nombres, apellidos, email, contraseña) values (" + dpi + ",'" + nombres + "','" + apellidos + "','" + email + "', md5('" + contraseña + "'))";

        try {

            sentencia = con.createStatement();
            resultado = sentencia.executeUpdate(sql);

            sentencia.close();
            con.close();
            sql = "";
            return "Usuario Creado";
        } catch (Exception e) {
            return e.toString();
        }
    }

    public int existeUsuario(String email) {
        con = Conexion.getConexion();
        String nombres = "";
        try {
            sql = "select nombres from persona where email = '" + email + "'";

            ResultSet resul = null;
            sentencia = con.createStatement();

            resul = sentencia.executeQuery(sql);
            while (resul.next()) {
                nombres = resul.getString(1);
            }

            if (nombres.length() > 0) {
                return 1;
            } else {
                return 0;
            }
        } catch (Exception e) {
            return -2;
        }
    }

    public int getCargo(String email) {
        con = Conexion.getConexion();

        int devolver = -2;

        try {
            sql = "select idcargo from persona where email = '" + email + "'";

            ResultSet resul = null;
            sentencia  = con.createStatement();
            
            resul = sentencia.executeQuery(sql);
            
            while(resul.next()){
                devolver = resul.getInt(1);
            }
            
            return devolver;
        } catch (Exception e) {
            return -1;
        }
    }

}
