namespace ServidorForms
{
    partial class Form_Servidor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Servidor));
            this.menuGeneral = new System.Windows.Forms.MenuStrip();
            this.holaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarChatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lstMensajes = new System.Windows.Forms.ListBox();
            this.txtMensaje = new System.Windows.Forms.RichTextBox();
            this.grpServer = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.menuGeneral.SuspendLayout();
            this.grpServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuGeneral
            // 
            this.menuGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.menuGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.holaToolStripMenuItem,
            this.ayudaToolStripMenuItem1});
            this.menuGeneral.Location = new System.Drawing.Point(0, 0);
            this.menuGeneral.Name = "menuGeneral";
            this.menuGeneral.Size = new System.Drawing.Size(589, 24);
            this.menuGeneral.TabIndex = 5;
            this.menuGeneral.Text = "menuStrip1";
            // 
            // holaToolStripMenuItem
            // 
            this.holaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.limpiarChatToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem1});
            this.holaToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.holaToolStripMenuItem.Name = "holaToolStripMenuItem";
            this.holaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.holaToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.salirToolStripMenuItem.Text = "Detener servidor";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.detenerServidorToolStripMenuItem_Click);
            // 
            // limpiarChatToolStripMenuItem
            // 
            this.limpiarChatToolStripMenuItem.Name = "limpiarChatToolStripMenuItem";
            this.limpiarChatToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.limpiarChatToolStripMenuItem.Text = "Limpiar chat";
            this.limpiarChatToolStripMenuItem.Click += new System.EventHandler(this.limpiarChatToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.ForeColor = System.Drawing.Color.Gainsboro;
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem1.Text = "Ayuda";
            // 
            // lstMensajes
            // 
            this.lstMensajes.FormattingEnabled = true;
            this.lstMensajes.Location = new System.Drawing.Point(22, 48);
            this.lstMensajes.Name = "lstMensajes";
            this.lstMensajes.Size = new System.Drawing.Size(363, 225);
            this.lstMensajes.TabIndex = 6;
            this.lstMensajes.SelectedIndexChanged += new System.EventHandler(this.lstMensajes_SelectedIndexChanged);
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(22, 303);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(363, 25);
            this.txtMensaje.TabIndex = 7;
            this.txtMensaje.Text = "";
            this.txtMensaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMensaje_KeyPress);
            // 
            // grpServer
            // 
            this.grpServer.Controls.Add(this.label2);
            this.grpServer.Controls.Add(this.label1);
            this.grpServer.Controls.Add(this.txtPort);
            this.grpServer.Controls.Add(this.txtIP);
            this.grpServer.Location = new System.Drawing.Point(405, 48);
            this.grpServer.Name = "grpServer";
            this.grpServer.Size = new System.Drawing.Size(172, 225);
            this.grpServer.TabIndex = 8;
            this.grpServer.TabStop = false;
            this.grpServer.Text = "Servidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(18, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Puerto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP:";
            // 
            // txtPort
            // 
            this.txtPort.Enabled = false;
            this.txtPort.Location = new System.Drawing.Point(18, 96);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(139, 20);
            this.txtPort.TabIndex = 1;
            // 
            // txtIP
            // 
            this.txtIP.Enabled = false;
            this.txtIP.Location = new System.Drawing.Point(19, 47);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(139, 20);
            this.txtIP.TabIndex = 0;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnviar.Location = new System.Drawing.Point(436, 303);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(117, 25);
            this.btnEnviar.TabIndex = 10;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnIniciarServer_Click);
            // 
            // Form_Servidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(589, 361);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.grpServer);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.lstMensajes);
            this.Controls.Add(this.menuGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Servidor";
            this.Text = "KoalaChat - Servidor";
            this.menuGeneral.ResumeLayout(false);
            this.menuGeneral.PerformLayout();
            this.grpServer.ResumeLayout(false);
            this.grpServer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuGeneral;
        private System.Windows.Forms.ToolStripMenuItem holaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ListBox lstMensajes;
        private System.Windows.Forms.RichTextBox txtMensaje;
        private System.Windows.Forms.GroupBox grpServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ToolStripMenuItem limpiarChatToolStripMenuItem;
    }
}