
package Conexion;

import java.io.DataInputStream;
import java.io.IOException;
import java.net.Socket;
import java.util.logging.Level;
import javax.swing.*;
import static clientforms.Main.*;

public class ConexionCliente extends JFrame {
    
    private JTextArea mensajesChat;
    public Socket socket;
    
    
    public ConexionCliente() throws IOException{
       
        socket = new Socket(Server, Integer.parseInt(Puerto));    
        
    }
        
    public void desconectarSocket(){
        try {
            this.socket.close();
        } catch (IOException ex) {
            java.util.logging.Logger.getLogger(ConexionCliente.class.getName()).log(Level.SEVERE, null, ex);
        }
        finally{
            chat.hide();
            in.show();
        }
    }
    
    public void recibirMensajesServidor(){
        // Obtiene el flujo de entrada del socket
        DataInputStream entradaDatos = null;
        String mensaje;
        
        
        try {
            entradaDatos = new DataInputStream(socket.getInputStream());
        } catch (Exception e){
        }
        
        // Recibir mensajes
        boolean conectado = true;
        while (conectado) {
            try {
                mensaje = entradaDatos.readLine();         
                chat.agregarElemento(mensaje);
            } catch (IOException ex) {
                
                conectado = false;
            }
        }
        desconectarSocket();            
        in.setMensajeError("Desconectado del servidor");
    }
    

}