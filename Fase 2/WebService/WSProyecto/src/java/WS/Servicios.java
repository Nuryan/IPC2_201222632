/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package WS;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author Nuryan
 */
@WebService(serviceName = "Servicios")
public class Servicios {

    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "hello")
    public String hello(@WebParam(name = "name") String txt) {
        return "Hello " + txt + " !";
    }

    @WebMethod(operationName = "iniciarSesion")
    public boolean iniciarSesion(@WebParam(name = "Apodo") String apodo,
            @WebParam(name = "pass") String pass,
             @WebParam(name = "codigo") String codigo) {
        try {
            Connection conexion = Conexion.conectar();

            Statement stmt = conexion.createStatement();

            String query = "SELECT * FROM producto;";
            ResultSet rs = stmt.executeQuery(query);

            while (rs.next()) {
                String marca = rs.getString("MARCA");
                System.out.println(marca);
                String descripcion = rs.getString("DESCRIPCION");
                System.out.println(descripcion);
            }

            return true;
        } catch (Exception e) {
            return false;
        }

    }
}
