/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package WS;

import java.sql.Connection;
import java.sql.DriverManager;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author Nuryan
 */
public class Conexion {

    public static Connection conectar() {
        try {
            Class.forName("com.mysql.jdbc.Driver");

            Connection conexion = DriverManager.getConnection("jdbc:mysql://localhost:3306/proyecto_ipc2", "Mancha", "dyehuty");
            return conexion;
        } catch (Exception ex) {
            return null;
        }
    }
    
}
