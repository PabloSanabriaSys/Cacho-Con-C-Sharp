using System.Runtime.CompilerServices;

namespace CACHO01
{
    partial class frmRegistroJugadores
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
            this.txtNombreJugador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIngreseNombre = new System.Windows.Forms.Label();
            this.lblNumeroJugadores = new System.Windows.Forms.Label();
            this.cbxNumeroDeJugadores = new System.Windows.Forms.ComboBox();
            this.gpbRegristro = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnNumJugadores = new System.Windows.Forms.Button();
            this.lblQuintoLugar = new System.Windows.Forms.Label();
            this.lblSegundoLugar = new System.Windows.Forms.Label();
            this.lblTercerLugar = new System.Windows.Forms.Label();
            this.lblCuartoLugar = new System.Windows.Forms.Label();
            this.lblPrimerLugar = new System.Windows.Forms.Label();
            this.lblQname = new System.Windows.Forms.Label();
            this.lblCname = new System.Windows.Forms.Label();
            this.lblTname = new System.Windows.Forms.Label();
            this.lblSname = new System.Windows.Forms.Label();
            this.lblPname = new System.Windows.Forms.Label();
            this.gpbRegristro.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreJugador
            // 
            this.txtNombreJugador.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreJugador.Location = new System.Drawing.Point(493, 34);
            this.txtNombreJugador.Name = "txtNombreJugador";
            this.txtNombreJugador.Size = new System.Drawing.Size(339, 32);
            this.txtNombreJugador.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(835, 85);
            this.label1.TabIndex = 13;
            this.label1.Text = "REGISTRO DE JUGADORES";
            // 
            // lblIngreseNombre
            // 
            this.lblIngreseNombre.AutoSize = true;
            this.lblIngreseNombre.Font = new System.Drawing.Font("Cascadia Mono", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreseNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIngreseNombre.Location = new System.Drawing.Point(6, 31);
            this.lblIngreseNombre.Name = "lblIngreseNombre";
            this.lblIngreseNombre.Size = new System.Drawing.Size(495, 35);
            this.lblIngreseNombre.TabIndex = 12;
            this.lblIngreseNombre.Text = "INGRESE EL NOMBRE DEL JUGADOR:";
            // 
            // lblNumeroJugadores
            // 
            this.lblNumeroJugadores.AutoSize = true;
            this.lblNumeroJugadores.Font = new System.Drawing.Font("Cascadia Mono", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroJugadores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNumeroJugadores.Location = new System.Drawing.Point(54, 160);
            this.lblNumeroJugadores.Name = "lblNumeroJugadores";
            this.lblNumeroJugadores.Size = new System.Drawing.Size(559, 35);
            this.lblNumeroJugadores.TabIndex = 19;
            this.lblNumeroJugadores.Text = "SELECCIONE EL NUMERO DE JUGADORES:";
            // 
            // cbxNumeroDeJugadores
            // 
            this.cbxNumeroDeJugadores.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNumeroDeJugadores.FormattingEnabled = true;
            this.cbxNumeroDeJugadores.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.cbxNumeroDeJugadores.Location = new System.Drawing.Point(619, 163);
            this.cbxNumeroDeJugadores.Name = "cbxNumeroDeJugadores";
            this.cbxNumeroDeJugadores.Size = new System.Drawing.Size(50, 40);
            this.cbxNumeroDeJugadores.TabIndex = 20;
            // 
            // gpbRegristro
            // 
            this.gpbRegristro.Controls.Add(this.lblPname);
            this.gpbRegristro.Controls.Add(this.lblQname);
            this.gpbRegristro.Controls.Add(this.lblCname);
            this.gpbRegristro.Controls.Add(this.lblTname);
            this.gpbRegristro.Controls.Add(this.lblSname);
            this.gpbRegristro.Controls.Add(this.lblQuintoLugar);
            this.gpbRegristro.Controls.Add(this.btnRegistrar);
            this.gpbRegristro.Controls.Add(this.lblSegundoLugar);
            this.gpbRegristro.Controls.Add(this.txtNombreJugador);
            this.gpbRegristro.Controls.Add(this.lblTercerLugar);
            this.gpbRegristro.Controls.Add(this.lblIngreseNombre);
            this.gpbRegristro.Controls.Add(this.lblCuartoLugar);
            this.gpbRegristro.Controls.Add(this.lblPrimerLugar);
            this.gpbRegristro.Location = new System.Drawing.Point(167, 241);
            this.gpbRegristro.Name = "gpbRegristro";
            this.gpbRegristro.Size = new System.Drawing.Size(1063, 432);
            this.gpbRegristro.TabIndex = 22;
            this.gpbRegristro.TabStop = false;
            this.gpbRegristro.Visible = false;
            this.gpbRegristro.Enter += new System.EventHandler(this.gpbRegristro_Enter);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackgroundImage = global::CACHO01.Properties.Resources.btnTiqueo;
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Location = new System.Drawing.Point(852, 31);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(72, 47);
            this.btnRegistrar.TabIndex = 17;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImage = global::CACHO01.Properties.Resources.btnSalir;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Location = new System.Drawing.Point(12, 668);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(160, 135);
            this.btnVolver.TabIndex = 23;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackgroundImage = global::CACHO01.Properties.Resources.btnIniciarJuego1;
            this.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSiguiente.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Location = new System.Drawing.Point(1236, 657);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(178, 146);
            this.btnSiguiente.TabIndex = 19;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Visible = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnNumJugadores
            // 
            this.btnNumJugadores.BackColor = System.Drawing.Color.Transparent;
            this.btnNumJugadores.BackgroundImage = global::CACHO01.Properties.Resources.btnTiqueo;
            this.btnNumJugadores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNumJugadores.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnNumJugadores.FlatAppearance.BorderSize = 0;
            this.btnNumJugadores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNumJugadores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNumJugadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumJugadores.Location = new System.Drawing.Point(691, 161);
            this.btnNumJugadores.Name = "btnNumJugadores";
            this.btnNumJugadores.Size = new System.Drawing.Size(65, 47);
            this.btnNumJugadores.TabIndex = 21;
            this.btnNumJugadores.UseVisualStyleBackColor = false;
            this.btnNumJugadores.Click += new System.EventHandler(this.btnNumJugadores_Click);
            // 
            // lblQuintoLugar
            // 
            this.lblQuintoLugar.AutoSize = true;
            this.lblQuintoLugar.Font = new System.Drawing.Font("Cascadia Mono", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuintoLugar.ForeColor = System.Drawing.Color.White;
            this.lblQuintoLugar.Location = new System.Drawing.Point(94, 349);
            this.lblQuintoLugar.Name = "lblQuintoLugar";
            this.lblQuintoLugar.Size = new System.Drawing.Size(272, 39);
            this.lblQuintoLugar.TabIndex = 50;
            this.lblQuintoLugar.Text = "QUINTO JUGADOR:";
            this.lblQuintoLugar.Visible = false;
            // 
            // lblSegundoLugar
            // 
            this.lblSegundoLugar.AutoSize = true;
            this.lblSegundoLugar.Font = new System.Drawing.Font("Cascadia Mono", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoLugar.ForeColor = System.Drawing.Color.White;
            this.lblSegundoLugar.Location = new System.Drawing.Point(94, 164);
            this.lblSegundoLugar.Name = "lblSegundoLugar";
            this.lblSegundoLugar.Size = new System.Drawing.Size(289, 39);
            this.lblSegundoLugar.TabIndex = 49;
            this.lblSegundoLugar.Text = "SEGUNDO JUGADOR:";
            this.lblSegundoLugar.Visible = false;
            // 
            // lblTercerLugar
            // 
            this.lblTercerLugar.AutoSize = true;
            this.lblTercerLugar.Font = new System.Drawing.Font("Cascadia Mono", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTercerLugar.ForeColor = System.Drawing.Color.White;
            this.lblTercerLugar.Location = new System.Drawing.Point(94, 229);
            this.lblTercerLugar.Name = "lblTercerLugar";
            this.lblTercerLugar.Size = new System.Drawing.Size(272, 39);
            this.lblTercerLugar.TabIndex = 48;
            this.lblTercerLugar.Text = "TERCER JUGADOR:";
            this.lblTercerLugar.Visible = false;
            // 
            // lblCuartoLugar
            // 
            this.lblCuartoLugar.AutoSize = true;
            this.lblCuartoLugar.Font = new System.Drawing.Font("Cascadia Mono", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuartoLugar.ForeColor = System.Drawing.Color.White;
            this.lblCuartoLugar.Location = new System.Drawing.Point(94, 292);
            this.lblCuartoLugar.Name = "lblCuartoLugar";
            this.lblCuartoLugar.Size = new System.Drawing.Size(272, 39);
            this.lblCuartoLugar.TabIndex = 47;
            this.lblCuartoLugar.Text = "CUARTO JUGADOR:";
            this.lblCuartoLugar.Visible = false;
            // 
            // lblPrimerLugar
            // 
            this.lblPrimerLugar.AutoSize = true;
            this.lblPrimerLugar.Font = new System.Drawing.Font("Cascadia Mono", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerLugar.ForeColor = System.Drawing.Color.White;
            this.lblPrimerLugar.Location = new System.Drawing.Point(94, 107);
            this.lblPrimerLugar.Name = "lblPrimerLugar";
            this.lblPrimerLugar.Size = new System.Drawing.Size(272, 39);
            this.lblPrimerLugar.TabIndex = 46;
            this.lblPrimerLugar.Text = "PRIMER JUGADOR:";
            this.lblPrimerLugar.Visible = false;
            this.lblPrimerLugar.Click += new System.EventHandler(this.lblPrimerLugar_Click);
            // 
            // lblQname
            // 
            this.lblQname.AutoSize = true;
            this.lblQname.Font = new System.Drawing.Font("Cascadia Mono", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQname.ForeColor = System.Drawing.Color.White;
            this.lblQname.Location = new System.Drawing.Point(400, 349);
            this.lblQname.Name = "lblQname";
            this.lblQname.Size = new System.Drawing.Size(0, 39);
            this.lblQname.TabIndex = 57;
            // 
            // lblCname
            // 
            this.lblCname.AutoSize = true;
            this.lblCname.Font = new System.Drawing.Font("Cascadia Mono", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCname.ForeColor = System.Drawing.Color.White;
            this.lblCname.Location = new System.Drawing.Point(400, 292);
            this.lblCname.Name = "lblCname";
            this.lblCname.Size = new System.Drawing.Size(0, 39);
            this.lblCname.TabIndex = 56;
            // 
            // lblTname
            // 
            this.lblTname.AutoSize = true;
            this.lblTname.Font = new System.Drawing.Font("Cascadia Mono", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTname.ForeColor = System.Drawing.Color.White;
            this.lblTname.Location = new System.Drawing.Point(400, 229);
            this.lblTname.Name = "lblTname";
            this.lblTname.Size = new System.Drawing.Size(0, 39);
            this.lblTname.TabIndex = 55;
            // 
            // lblSname
            // 
            this.lblSname.AutoSize = true;
            this.lblSname.Font = new System.Drawing.Font("Cascadia Mono", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSname.ForeColor = System.Drawing.Color.White;
            this.lblSname.Location = new System.Drawing.Point(400, 164);
            this.lblSname.Name = "lblSname";
            this.lblSname.Size = new System.Drawing.Size(0, 39);
            this.lblSname.TabIndex = 54;
            // 
            // lblPname
            // 
            this.lblPname.AutoSize = true;
            this.lblPname.Font = new System.Drawing.Font("Cascadia Mono", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPname.ForeColor = System.Drawing.Color.White;
            this.lblPname.Location = new System.Drawing.Point(400, 107);
            this.lblPname.Name = "lblPname";
            this.lblPname.Size = new System.Drawing.Size(0, 39);
            this.lblPname.TabIndex = 49;
            // 
            // frmRegistroJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1426, 815);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.gpbRegristro);
            this.Controls.Add(this.btnNumJugadores);
            this.Controls.Add(this.cbxNumeroDeJugadores);
            this.Controls.Add(this.lblNumeroJugadores);
            this.Controls.Add(this.label1);
            this.Name = "frmRegistroJugadores";
            this.Text = "REGISTRO";
            this.Load += new System.EventHandler(this.frmRegistroJugadores_Load);
            this.gpbRegristro.ResumeLayout(false);
            this.gpbRegristro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtNombreJugador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIngreseNombre;
        private System.Windows.Forms.Label lblNumeroJugadores;
        private System.Windows.Forms.ComboBox cbxNumeroDeJugadores;
        private System.Windows.Forms.Button btnNumJugadores;
        private System.Windows.Forms.GroupBox gpbRegristro;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblQuintoLugar;
        private System.Windows.Forms.Label lblSegundoLugar;
        private System.Windows.Forms.Label lblTercerLugar;
        private System.Windows.Forms.Label lblCuartoLugar;
        private System.Windows.Forms.Label lblPrimerLugar;
        private System.Windows.Forms.Label lblQname;
        private System.Windows.Forms.Label lblCname;
        private System.Windows.Forms.Label lblTname;
        private System.Windows.Forms.Label lblSname;
        private System.Windows.Forms.Label lblPname;
    }
}