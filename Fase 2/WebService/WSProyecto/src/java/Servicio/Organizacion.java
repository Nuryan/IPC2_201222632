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
public class Organizacion {

    private Connection con = null;
    private String sql = "";
    private Statement sentencia = null;

    public String crearOrganizacion(String nombre, String email) {
        int resultadoCreacion = 0;
        int resultadoAsignacionResponsable = 0;

        con = Conexion.getConexion();

        if (existeOrganizacion(nombre) == 1) {
            return "La organizacion ya existe";
        }
        sql = "insert into organizacion(nombre) values ('" + nombre + "')";

        try {

            sentencia = con.createStatement();
            resultadoCreacion = sentencia.executeUpdate(sql);

            if (resultadoCreacion > 0) {
                int idUsuario = new Usuario().getIdPersona(email);
                int idOrganizacion = getIdOrganizacion(nombre);

                sql = "insert into participanteOrganizacion(idPersona, idOrganizacion, administrador) values(" + idUsuario + "," + idOrganizacion + ",1)";
                sentencia = con.createStatement();
                resultadoAsignacionResponsable = sentencia.executeUpdate(sql);

                sentencia.close();
                con.close();
                sql = "";

                if (resultadoCreacion > 0 && resultadoAsignacionResponsable > 0) {
                    return "Organizacion creada";
                } else {
                    return "No se ha podido crear la organizacion";
                }
            } else {
                return "no se ha podido crear la organizacion";
            }
        } catch (Exception e) {
            return e.toString();
        }
    }

    public int getPlazasOcupadas(String nombre) {
        int plazasOcupadas = 0;

        con = Conexion.getConexion();
        try {
            sql = "select count(*) from participanteOrganizacion where participanteOrganizacion.idOrganizacion = " + getIdOrganizacion(nombre);

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

    public int getPlazasTotales(String nombre) {
        int plazasTotales = 0;

        con = Conexion.getConexion();
        try {
            sql = "select numParticipantes from organizacion where idOrganizacion = " + getIdOrganizacion(nombre);

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

    public int getPlazasDisponibles(String nombre) {
        if (getPlazasTotales(nombre) - getPlazasOcupadas(nombre) > 0) {
            return 1;
        } else {
            return 0;
        }
    }

    public int getIdOrganizacion(String nombre) {
        con = Conexion.getConexion();

        int devolver = -2;

        try {
            sql = "select idOrganizacion from organizacion where nombre = '" + nombre + "'";

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

    public int existeOrganizacion(String nombre) {
        con = Conexion.getConexion();
        String nombres = "";
        try {
            sql = "select idOrganizacion from organizacion where nombre = '" + nombre + "'";

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

    public String añadirParticipante(String email, String nombre) {
        if (getParticipacionParticipanteEnOrganizacion(email, nombre) == 0) {
            int resultado = 0;
            con = Conexion.getConexion();
            Usuario us = new Usuario();
            sql = "insert into participanteOrganizacion(idPersona, idOrganizacion, administrador) values (" + us.getIdPersona(email) + "," + getIdOrganizacion(nombre) + ",0)";

            try {

                sentencia = con.createStatement();
                resultado = sentencia.executeUpdate(sql);

                sentencia.close();
                con.close();
                sql = "";
                if (resultado > 0) {
                    return "Participante Agregado";
                } else {
                    return "no se ha podido añadir al participante";
                }
            } catch (Exception e) {
                return "No se ha podido añadir al participante";
            }
        } else {
            return "El Participante ya pertenece a la organizacion";
        }
    }

    public int getParticipacionParticipanteEnOrganizacion(String email, String nombre) {
        Usuario us = new Usuario();
        int plazasTotales = 0;

        con = Conexion.getConexion();
        try {
            sql = "select count(*) from participanteOrganizacion where idPersona =" + us.getIdPersona(email) + " and idOrganizacion = " + getIdOrganizacion(nombre);

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

    public ArrayList<String> listarOrganizaciones(String emailEncargado) {
        Usuario us = new Usuario();
        con = Conexion.getConexion();
        ArrayList<String> listado = new ArrayList<String>();

        try {
            sql = "SELECT organizacion.nombre\n"
                    + "FROM organizacion\n"
                    + "INNER JOIN participanteOrganizacion ON organizacion.idorganizacion = participanteOrganizacion.idOrganizacion\n"
                    + "WHERE Participanteorganizacion.administrador = 1 AND participanteorganizacion.idPersona = " + us.getIdPersona(emailEncargado);

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

            devolver.add("No se encontro ninguna organizacion");

            return devolver;
        }
    }

    public int añadirModulosDefault(String email, String nombre) {
        int resultado = 0;
        int idUsuario = new Usuario().getIdPersona(email);
        int idOrganizacion = getIdOrganizacion(nombre);
        con = Conexion.getConexion();

        sql = "insert into moduloAdquirido (idPersona, idOrganizacion, idModulo) values ('')";

        try {

            sentencia = con.createStatement();
            resultado = sentencia.executeUpdate(sql);

            sentencia.close();
            con.close();
            sql = "";

            return resultado;
        } catch (Exception e) {
            return -2;
        }
    }

}
