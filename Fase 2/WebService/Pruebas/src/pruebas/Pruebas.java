/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pruebas;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.Calendar;

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
       
        Calendar c = Calendar.getInstance();
        int mes = c.get(Calendar.MONTH)+8;
        int año = c.get(Calendar.YEAR);
        
        while(mes>12){
            año++;
            mes = mes -12;
        }
        
        System.out.println(año+"/"+mes);
    }
    
}
