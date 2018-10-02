
package clientforms;

import Conexion.EnviarCliente;

public class Main {
    
    public static IniciarSesion in;
    public static String Nombre,Puerto,Server;
    public static ChatCliente chat;
    public static EnviarCliente c;
    
    public static void main(String[] args) {
        Nombre="Koala";
        Server="127.0.0.1";
        Puerto="5000";
        
        in = new IniciarSesion();
        in.show();
        
        
    }
    
    
}
