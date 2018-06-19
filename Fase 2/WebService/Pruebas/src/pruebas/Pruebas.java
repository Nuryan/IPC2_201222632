/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pruebas;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;

/**
 *
 * @author Nuryan
 */
public class Pruebas {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
         Connection con = null;
     String sql = "";
     Statement sentencia = null;
        String devolver ="";
        String banderin = "1";
        try{    
            con = Conexion.getConexion();
            banderin = "2";
            sql = "select nombres from persona where idPersona = 1";
            banderin = "3";
            ResultSet  resultado =  null;
            banderin = "4";
            sentencia = con.createStatement();
            banderin = "5";
            
            resultado = sentencia.executeQuery(sql);
            banderin = "6";
            while(resultado.next()){
                devolver = resultado.getString(1);
            }
            banderin = "7";
            
            resultado.close();
            banderin = "8";
            sentencia.close();
            banderin = "9";
            con.close();
            banderin = "10";
            System.out.println(devolver);
        }catch(Exception e){
             System.out.println(banderin + " " +e.toString() );
        }
    }
    
}
