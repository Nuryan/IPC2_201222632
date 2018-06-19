/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pruebas;

import java.sql.Connection;
import java.sql.DriverManager;

/**
 *
 * @author Nuryan
 */
public class Conexion {
    public static Connection getConexion() {
        Connection con = null;
       
        String url = "jdbc:postgresql://127.0.0.1:5432/ipc2";
        String password = "asdf1234";
        
        try{
            Class.forName("org.postgresql.Driver");
            
            con = DriverManager.getConnection(url, "ipc", password);
        
            return con;
        }catch(Exception e){
            
        }
        return null;
    }
    
    public static Connection getConexion(String usuario, String pass, String db) {
        Connection con = null;
        try {
            Class.forName("org.postgresql.Driver");
            con = DriverManager.getConnection("jdbc:postgresql://localhost/" + db + "?user=" + usuario + "&password=" + pass);
        } catch (Exception e) {

        }
        return con;
    }
}
