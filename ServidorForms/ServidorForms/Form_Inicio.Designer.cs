namespace ServidorForms
{
    partial class Form_Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Inicio));
            this.menuGeneral = new System.Windows.Forms.MenuStrip();
            this.holaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grpServer = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnIniciarServer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblExcepcion = new System.Windows.Forms.Label();
            this.menuGeneral.SuspendLayout();
            this.grpServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.menuGeneral.Size = new System.Drawing.Size(321, 24);
            this.menuGeneral.TabIndex = 4;
            this.menuGeneral.Text = "menuStrip1";
            // 
            // holaToolStripMenuItem
            // 
            this.holaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.holaToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.holaToolStripMenuItem.Name = "holaToolStripMenuItem";
            this.holaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.holaToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.ForeColor = System.Drawing.Color.Gainsboro;
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem1.Text = "Ayuda";
            // 
            // grpServer
            // 
            this.grpServer.Controls.Add(this.lblExcepcion);
            this.grpServer.Controls.Add(this.label2);
            this.grpServer.Controls.Add(this.label1);
            this.grpServer.Controls.Add(this.txtPort);
            this.grpServer.Controls.Add(this.txtIP);
            this.grpServer.Location = new System.Drawing.Point(47, 253);
            this.grpServer.Name = "grpServer";
            this.grpServer.Size = new System.Drawing.Size(230, 146);
            this.grpServer.TabIndex = 5;
            this.grpServer.TabStop = false;
            this.grpServer.Text = "Servidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(32, 80);
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
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(32, 96);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(173, 20);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "5000";
            this.txtPort.Click += new System.EventHandler(this.txtPort_Click);
            this.txtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPort_KeyPress);
            // 
            // txtIP
            // 
            this.txtIP.Enabled = false;
            this.txtIP.Location = new System.Drawing.Point(33, 47);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(173, 20);
            this.txtIP.TabIndex = 0;
            // 
            // btnIniciarServer
            // 
            this.btnIniciarServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnIniciarServer.FlatAppearance.BorderSize = 0;
            this.btnIniciarServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarServer.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarServer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIniciarServer.Location = new System.Drawing.Point(97, 430);
            this.btnIniciarServer.Name = "btnIniciarServer";
            this.btnIniciarServer.Size = new System.Drawing.Size(145, 25);
            this.btnIniciarServer.TabIndex = 7;
            this.btnIniciarServer.Text = "Iniciar Servidor";
            this.btnIniciarServer.UseVisualStyleBackColor = false;
            this.btnIniciarServer.Click += new System.EventHandler(this.btnIniciarServidor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ServidorForms.Properties.Resources.KoalaChat_logo_21;
            this.pictureBox1.Location = new System.Drawing.Point(83, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 175);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblExcepcion
            // 
            this.lblExcepcion.AutoSize = true;
            this.lblExcepcion.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblExcepcion.Location = new System.Drawing.Point(85, 119);
            this.lblExcepcion.Name = "lblExcepcion";
            this.lblExcepcion.Size = new System.Drawing.Size(47, 13);
            this.lblExcepcion.TabIndex = 4;
            this.lblExcepcion.Text = "Mensaje";
            // 
            // Form_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(321, 489);
            this.Controls.Add(this.btnIniciarServer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpServer);
            this.Controls.Add(this.menuGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuGeneral;
            this.Name = "Form_Inicio";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Koala Chat";
            this.menuGeneral.ResumeLayout(false);
            this.menuGeneral.PerformLayout();
            this.grpServer.ResumeLayout(false);
            this.grpServer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuGeneral;
        private System.Windows.Forms.ToolStripMenuItem holaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
        private System.Windows.Forms.GroupBox grpServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIniciarServer;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label lblExcepcion;
    }
}

