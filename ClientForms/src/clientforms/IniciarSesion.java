package clientforms;
import Conexion.ConexionCliente;
import static clientforms.Main.*;
import java.awt.Color;
import java.awt.Image;
import java.awt.Toolkit;
import java.awt.event.KeyEvent;
import java.util.Random;

public class IniciarSesion extends javax.swing.JFrame {
    
    public IniciarSesion() {
        initComponents();
        
        this.setTitle("KoalaChat - Cliente");
        cambiarDatos();
        lblError.setVisible(false);
    }
    
    @Override
    public Image getIconImage() {
        Image retValue = Toolkit.getDefaultToolkit().
                getImage(ClassLoader.getSystemResource("img/KoalaChat.png"));
        return retValue;
    }
    
    public void cambiarDatos(){
        
        txtNombre.setText(Nombre);
        txtServer.setText(Server);
        txtPuerto.setText(Puerto);
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        jLabel1 = new javax.swing.JLabel();
        txtServer = new javax.swing.JTextField();
        txtNombre = new javax.swing.JTextField();
        btnConectarse = new javax.swing.JButton();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        txtPuerto = new javax.swing.JTextField();
        jLabel4 = new javax.swing.JLabel();
        lblError = new javax.swing.JLabel();
        jMenuBar1 = new javax.swing.JMenuBar();
        jMenu1 = new javax.swing.JMenu();
        mnuSalir = new javax.swing.JMenuItem();
        jMenu2 = new javax.swing.JMenu();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        setIconImage(getIconImage());
        setResizable(false);

        jPanel1.setBackground(new java.awt.Color(255, 255, 255));
        jPanel1.addMouseMotionListener(new java.awt.event.MouseMotionAdapter() {
            public void mouseMoved(java.awt.event.MouseEvent evt) {
                jPanel1MouseMoved(evt);
            }
        });

        jLabel1.setIcon(new javax.swing.ImageIcon(getClass().getResource("/img/KoalaChat_logo_2.png"))); // NOI18N
        jLabel1.setToolTipText("");

        txtServer.setText("127.0.0.1");
        txtServer.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                txtServerActionPerformed(evt);
            }
        });
        txtServer.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                txtServerKeyPressed(evt);
            }
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtServerKeyTyped(evt);
            }
        });

        txtNombre.setText("Koala");
        txtNombre.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                txtNombreKeyPressed(evt);
            }
        });

        btnConectarse.setBackground(new java.awt.Color(0, 102, 102));
        btnConectarse.setForeground(new java.awt.Color(255, 255, 255));
        btnConectarse.setText("Conectarse");
        btnConectarse.addMouseMotionListener(new java.awt.event.MouseMotionAdapter() {
            public void mouseMoved(java.awt.event.MouseEvent evt) {
                btnConectarseMouseMoved(evt);
            }
        });
        btnConectarse.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnConectarseActionPerformed(evt);
            }
        });
        btnConectarse.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                btnConectarseKeyPressed(evt);
            }
        });

        jLabel2.setForeground(new java.awt.Color(0, 102, 102));
        jLabel2.setText("Servidor:");

        jLabel3.setForeground(new java.awt.Color(0, 102, 102));
        jLabel3.setText("Nombre:");

        txtPuerto.setText("6969");
        txtPuerto.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                txtPuertoActionPerformed(evt);
            }
        });
        txtPuerto.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                txtPuertoKeyPressed(evt);
            }
        });

        jLabel4.setForeground(new java.awt.Color(0, 102, 102));
        jLabel4.setText("Puerto:");

        lblError.setBackground(new java.awt.Color(153, 0, 0));
        lblError.setForeground(new java.awt.Color(153, 0, 0));
        lblError.setText("Error en el servidor");

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addGap(82, 82, 82)
                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jLabel2)
                            .addComponent(jLabel1, javax.swing.GroupLayout.PREFERRED_SIZE, 187, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                                .addComponent(txtServer)
                                .addComponent(txtNombre)
                                .addGroup(jPanel1Layout.createSequentialGroup()
                                    .addComponent(jLabel4)
                                    .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                    .addComponent(lblError))
                                .addComponent(jLabel3)
                                .addComponent(txtPuerto, javax.swing.GroupLayout.PREFERRED_SIZE, 187, javax.swing.GroupLayout.PREFERRED_SIZE))))
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addGap(121, 121, 121)
                        .addComponent(btnConectarse)))
                .addContainerGap(63, Short.MAX_VALUE))
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addGap(19, 19, 19)
                .addComponent(jLabel1, javax.swing.GroupLayout.PREFERRED_SIZE, 197, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(49, 49, 49)
                .addComponent(jLabel2)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(txtServer, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(jLabel4)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(txtPuerto, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(jLabel3)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(txtNombre, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(lblError)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(btnConectarse)
                .addGap(18, 18, 18))
        );

        jMenuBar1.setBackground(new java.awt.Color(0, 102, 102));
        jMenuBar1.setForeground(new java.awt.Color(255, 255, 255));

        jMenu1.setForeground(new java.awt.Color(255, 255, 255));
        jMenu1.setText("Archivo");

        mnuSalir.setBackground(new java.awt.Color(255, 255, 255));
        mnuSalir.setText("Salir");
        mnuSalir.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                mnuSalirActionPerformed(evt);
            }
        });
        jMenu1.add(mnuSalir);

        jMenuBar1.add(jMenu1);

        jMenu2.setForeground(new java.awt.Color(255, 255, 255));
        jMenu2.setText("Ayuda");
        jMenuBar1.add(jMenu2);

        setJMenuBar(jMenuBar1);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );

        pack();
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents

    public void setMensajeError(String s){
        lblError.setText(s);
        lblError.setVisible(true);
    }
    
    private void mnuSalirActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_mnuSalirActionPerformed
     System.exit(WIDTH);
    }//GEN-LAST:event_mnuSalirActionPerformed

    
     
    private void btnConectarseActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnConectarseActionPerformed
               
       Nombre=txtNombre.getText();       
       Server=txtServer.getText();       
       Puerto=txtPuerto.getText();
       
       if(Nombre.equals("Koala") || Nombre.equals("koala"))
           Nombre="Koala"+Integer.toString((int)(new Random().nextDouble() * 1000));

       try{           
            ConexionCliente c = new ConexionCliente();
            chat= new ChatCliente(c);
            chat.show();
            in.hide();
            lblError.setVisible(false);
       }
       catch(Exception e){
           setMensajeError("Error en el servidor.");
       }
    }//GEN-LAST:event_btnConectarseActionPerformed

    private void txtServerActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_txtServerActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_txtServerActionPerformed

    private void txtPuertoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_txtPuertoActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_txtPuertoActionPerformed

    private void btnConectarseMouseMoved(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_btnConectarseMouseMoved
        btnConectarse.setBackground(new Color(64,64,64));
    }//GEN-LAST:event_btnConectarseMouseMoved

    private void jPanel1MouseMoved(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jPanel1MouseMoved
        btnConectarse.setBackground(new java.awt.Color(0,102,102));
                
    }//GEN-LAST:event_jPanel1MouseMoved

    private void txtServerKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtServerKeyTyped
        btnConectarseActionPerformed(null);
    }//GEN-LAST:event_txtServerKeyTyped

    private void txtServerKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtServerKeyPressed
        if(evt.getKeyCode() == KeyEvent.VK_ENTER){
             btnConectarseActionPerformed(null);
        }
    }//GEN-LAST:event_txtServerKeyPressed

    private void txtPuertoKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtPuertoKeyPressed
        if(evt.getKeyCode() == KeyEvent.VK_ENTER){
             btnConectarseActionPerformed(null);
        }
    }//GEN-LAST:event_txtPuertoKeyPressed

    private void txtNombreKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtNombreKeyPressed
        if(evt.getKeyCode() == KeyEvent.VK_ENTER){
             btnConectarseActionPerformed(null);
        }
    }//GEN-LAST:event_txtNombreKeyPressed

    private void btnConectarseKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_btnConectarseKeyPressed
        if(evt.getKeyCode() == KeyEvent.VK_ENTER){
             btnConectarseActionPerformed(null);
        }
    }//GEN-LAST:event_btnConectarseKeyPressed

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(IniciarSesion.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(IniciarSesion.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(IniciarSesion.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(IniciarSesion.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new IniciarSesion().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnConectarse;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JMenu jMenu1;
    private javax.swing.JMenu jMenu2;
    private javax.swing.JMenuBar jMenuBar1;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JLabel lblError;
    private javax.swing.JMenuItem mnuSalir;
    private javax.swing.JTextField txtNombre;
    private javax.swing.JTextField txtPuerto;
    private javax.swing.JTextField txtServer;
    // End of variables declaration//GEN-END:variables
}
