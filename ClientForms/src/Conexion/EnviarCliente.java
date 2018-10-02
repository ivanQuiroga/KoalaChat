
package Conexion;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.Socket;
import javax.swing.JOptionPane;
import javax.swing.JTextField;

/**
 * Esta clase gestiona el envio de datos entre el cliente y el servidor.
 * 
 * @author Ivan Salas Corrales <http://programando-o-intentandolo.blogspot.com.es/>
 */
public class EnviarCliente implements ActionListener {
    
    public static Socket socket; 
    private JTextField tfMensaje;
    private String usuario;
    private DataOutputStream salidaDatos;
    
    public EnviarCliente(Socket socket, JTextField tfMensaje, String usuario) {
        this.socket = socket;
        this.tfMensaje = tfMensaje;
        this.usuario = usuario;
        try {
            
            this.salidaDatos = new DataOutputStream(socket.getOutputStream());
        } catch (IOException ex) {
            JOptionPane.showMessageDialog(null,"Error al crear el stream de salida : " + ex.getMessage());
        } catch (NullPointerException ex) {
            JOptionPane.showMessageDialog(null,"El socket no se creo correctamente. ");
        }
    }

    @Override
    public void actionPerformed(ActionEvent e) {
       enviarDatos();
    }
    
    public void enviarDatos(){
        try {
            byte [ ] outStream = (usuario + ": " + tfMensaje.getText()+  "$*!" ).getBytes();
            salidaDatos.write(outStream,0,outStream.length);
            salidaDatos.flush();
            tfMensaje.setText("");
        } catch (IOException ex) {
            JOptionPane.showMessageDialog(null,"Error al intentar enviar un mensaje: " + ex.getMessage());
        }
    }
    
    public void enviarNombre(){
        try {
            byte [ ] outStream = (usuario+ "$*$" ).getBytes();
            salidaDatos.write(outStream,0,outStream.length);
            salidaDatos.flush();
            tfMensaje.setText("");
        } catch (IOException ex) {
            JOptionPane.showMessageDialog(null,"Error al intentar enviar un mensaje: " + ex.getMessage());
        }
    }

}