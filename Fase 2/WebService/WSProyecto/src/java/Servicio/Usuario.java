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
import java.util.ArrayList;
import javax.jws.WebMethod;
import javax.jws.WebParam;

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
        Modulo mod = new Modulo();
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

            mod.comprarModulo(email, "Clientes", 100);
            mod.comprarModulo(email, "Proveedores", 100);
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

    public int getIdPersona(String email) {
        con = Conexion.getConexion();

        int devolver = -2;

        try {
            sql = "select idPersona from persona where email = '" + email + "'";

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

    public String crearEmpleado(String dpi, String nombres, String apellidos, String contraseña, String contraseñaRep, String emailEmpleado, String emailUsuario) {
        if (getPlazasDisponibles(emailUsuario) > 0) {
            if (crearUsuarioLogin(dpi, nombres, apellidos, contraseña, contraseñaRep, emailEmpleado).equals("Usuario Creado")) {

                if (alterarCargo(emailEmpleado) > 0) {
                    if (añadirEmpleado(emailUsuario, emailEmpleado) > 0) {
//                        reducirPlazasEmpleado(emailUsuario);
                        return "Usuario Creado";
                    } else {
                        return "Usuario Noo Creado";
                    }
                } else {
                    return "Usuario NO Creado";
                }

            } else {
                return "Usuario no Creado";
            }
        } else {
            return "Numero de empleado maximo alcanzado";
        }
    }

    public int añadirEmpleado(String emailUsuario, String emailEmpleado) {
        int resultado = 0;

        con = Conexion.getConexion();

        sql = "insert into empleado(idUsuario, idEmpleado) values(" + getIdPersona(emailUsuario) + "," + getIdPersona(emailEmpleado) + ")";

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
            return -1;
        }
    }

    public int añadirSlotEmpleado(String usuario, int nuevosSlots) {
        try {
            Connection con = Conexion.getConexion();

            Statement sentencia = con.createStatement();
            int saldo = 50 * nuevosSlots;
            sql = "update persona set numEmpleados = numEmpleados + (" + nuevosSlots + ") where idPersona = " + getIdPersona(usuario) + ";"
                    + "update persona set saldo = saldo + (" + saldo + ") where idPersona = " + getIdPersona(usuario);

            int resultado = sentencia.executeUpdate(sql);

            con.close();
            sentencia.close();

            return 1;
        } catch (Exception e) {
            return -2;
        }
    }

    public float getSaldoActual(String usuario) {
        try {
            float devolver = 0;

            Connection con = Conexion.getConexion();

            Statement sentencia = con.createStatement();

            sql = "select saldo from persona where idPersona = " + getIdPersona(usuario);

            ResultSet resultado = sentencia.executeQuery(sql);

            while (resultado.next()) {
                devolver = resultado.getFloat(1);
            }

            sentencia.close();
            con.close();

            return devolver;
        } catch (Exception e) {
            return -2;
        }
    }

    public int alterarCargo(String email) {
        //lo pone como empleado, que es el rango 3
        int resultado = 0;

        con = Conexion.getConexion();

        sql = "update persona set idCargo = 3 where idPersona = " + getIdPersona(email);

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
            return -1;
        }
    }

    public int reducirPlazasEmpleado(String email) {
        //evita que el empleado pueda crear mas empleados
        int resultado = 0;

        con = Conexion.getConexion();

        sql = "update persona set numEmpleados = numEmpleados-1 where idPersona = " + getIdPersona(email);

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
            return -1;
        }
    }

    public int getPlazasOcupadas(String email) {
        int plazasOcupadas = 0;

        con = Conexion.getConexion();
        try {
            sql = "select count(*) from empleado where idUsuario = " + getIdPersona(email);

            ResultSet resul = null;
            sentencia = con.createStatement();

            resul = sentencia.executeQuery(sql);

            while (resul.next()) {
                plazasOcupadas = resul.getInt(1);
            }
            return plazasOcupadas;
        } catch (Exception e) {
            return -1;
        }
    }

    public int getPlazasTotales(String email) {
        int plazasTotales = 0;

        con = Conexion.getConexion();
        try {
            sql = "select numEmpleados from persona where idPersona = " + getIdPersona(email);

            ResultSet resul = null;
            sentencia = con.createStatement();

            resul = sentencia.executeQuery(sql);

            while (resul.next()) {
                plazasTotales = resul.getInt(1);
            }
            return plazasTotales;
        } catch (Exception e) {
            return -1;
        }
    }

    public int getPlazasDisponibles(String email) {
        if (getPlazasTotales(email) - getPlazasOcupadas(email) > 0) {
            return 1;
        } else {
            return 0;
        }
    }

    public ArrayList<String> listarParticipantes(String emailEncargado) {
        con = Conexion.getConexion();
        ArrayList<String> listado = new ArrayList<String>();

        try {
            sql = "select persona.email from empleado inner join persona on persona.idPersona = empleado.idEmpleado where empleado.idUsuario = " + getIdPersona(emailEncargado);

            ResultSet resul = null;
            sentencia = con.createStatement();

            resul = sentencia.executeQuery(sql);

            while (resul.next()) {
                listado.add(resul.getString(1));
            }
            sentencia.close();
            con.close();
            sql = "";
            return listado;
        } catch (Exception e) {
            ArrayList<String> devolver = new ArrayList<String>();

            devolver.add("No se encontro ningun empleado");

            return devolver;
        }
    }

    public ArrayList<String> getDetallePesona(String usuario) {
        ArrayList<String> devolver = new ArrayList<String>();
        try {
            Connection con = Conexion.getConexion();
            sql = "select nombres, apellidos, email, numEmpleados, saldo from persona where idPersona = " + getIdPersona(usuario);

            ResultSet resul = null;
            Statement sentencia = con.createStatement();

            resul = sentencia.executeQuery(sql);

            while (resul.next()) {
                devolver.add(resul.getString(1));
                devolver.add(resul.getString(2));
                devolver.add(resul.getString(3));
                devolver.add(resul.getString(4));
                devolver.add(resul.getString(5));
            }
            sentencia.close();
            con.close();
            sql = "";
            
            return devolver;
        } catch (Exception e) {
            devolver.add(e.toString());
            return devolver;
        }
    }

}
