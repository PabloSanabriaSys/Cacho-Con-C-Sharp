namespace CACHO01
{
    partial class frmReglas
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.pbxNormal = new System.Windows.Forms.PictureBox();
            this.btnIzq = new System.Windows.Forms.Button();
            this.btnDer = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbxMano = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMano)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Cascadia Mono", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(22, 16);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(873, 85);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "REGLAS DEL JUEGO CACHO";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.BackColor = System.Drawing.Color.Transparent;
            this.lblTexto.Font = new System.Drawing.Font("Cascadia Mono", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.Color.White;
            this.lblTexto.Location = new System.Drawing.Point(31, 241);
            this.lblTexto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(0, 35);
            this.lblTexto.TabIndex = 8;
            this.lblTexto.Click += new System.EventHandler(this.label1_Click);
            // 
            // pbxNormal
            // 
            this.pbxNormal.Image = global::CACHO01.Properties.Resources.Captura_de_pantalla_20221201_183216;
            this.pbxNormal.Location = new System.Drawing.Point(109, 92);
            this.pbxNormal.Name = "pbxNormal";
            this.pbxNormal.Size = new System.Drawing.Size(519, 623);
            this.pbxNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxNormal.TabIndex = 12;
            this.pbxNormal.TabStop = false;
            this.pbxNormal.Visible = false;
            // 
            // btnIzq
            // 
            this.btnIzq.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzq.BackColor = System.Drawing.Color.Transparent;
            this.btnIzq.BackgroundImage = global::CACHO01.Properties.Resources.btnIzquierda;
            this.btnIzq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIzq.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnIzq.FlatAppearance.BorderSize = 0;
            this.btnIzq.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIzq.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIzq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzq.Location = new System.Drawing.Point(11, 701);
            this.btnIzq.Margin = new System.Windows.Forms.Padding(2);
            this.btnIzq.Name = "btnIzq";
            this.btnIzq.Size = new System.Drawing.Size(169, 127);
            this.btnIzq.TabIndex = 10;
            this.btnIzq.UseVisualStyleBackColor = false;
            this.btnIzq.Click += new System.EventHandler(this.btnIzq_Click);
            // 
            // btnDer
            // 
            this.btnDer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDer.BackColor = System.Drawing.Color.Transparent;
            this.btnDer.BackgroundImage = global::CACHO01.Properties.Resources.btnDerecha;
            this.btnDer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDer.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDer.FlatAppearance.BorderSize = 0;
            this.btnDer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDer.Location = new System.Drawing.Point(225, 701);
            this.btnDer.Margin = new System.Windows.Forms.Padding(2);
            this.btnDer.Name = "btnDer";
            this.btnDer.Size = new System.Drawing.Size(182, 127);
            this.btnDer.TabIndex = 9;
            this.btnDer.UseVisualStyleBackColor = false;
            this.btnDer.Click += new System.EventHandler(this.btnDer_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = global::CACHO01.Properties.Resources.btnSalir;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(1222, 687);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(193, 141);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CACHO01.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(1180, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pbxMano
            // 
            this.pbxMano.Image = global::CACHO01.Properties.Resources.Captura_de_pantalla_20221201_183139;
            this.pbxMano.Location = new System.Drawing.Point(666, 72);
            this.pbxMano.Name = "pbxMano";
            this.pbxMano.Size = new System.Drawing.Size(542, 654);
            this.pbxMano.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMano.TabIndex = 13;
            this.pbxMano.TabStop = false;
            this.pbxMano.Visible = false;
            this.pbxMano.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // frmReglas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1426, 839);
            this.Controls.Add(this.btnIzq);
            this.Controls.Add(this.btnDer);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbxNormal);
            this.Controls.Add(this.pbxMano);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmReglas";
            this.Text = "frmReglas";
            this.Load += new System.EventHandler(this.frmReglas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMano)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Button btnDer;
        private System.Windows.Forms.Button btnIzq;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbxNormal;
        private System.Windows.Forms.PictureBox pbxMano;
    }
}