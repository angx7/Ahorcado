namespace Ahorcado
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnAnimales = new Button();
            lblnicio = new Label();
            label1 = new Label();
            lblName = new Label();
            txtJ1 = new TextBox();
            txtJ2 = new TextBox();
            btnFrutas = new Button();
            btnNombres = new Button();
            btnCiudades = new Button();
            btnSitiosWeb = new Button();
            SuspendLayout();
            // 
            // btnAnimales
            // 
            btnAnimales.Font = new Font("Verdana", 10.2F);
            btnAnimales.Location = new Point(79, 247);
            btnAnimales.Name = "btnAnimales";
            btnAnimales.Size = new Size(125, 29);
            btnAnimales.TabIndex = 0;
            btnAnimales.Text = "Animales";
            btnAnimales.UseVisualStyleBackColor = true;
            btnAnimales.Click += btnAnimales_Click;
            // 
            // lblnicio
            // 
            lblnicio.AutoSize = true;
            lblnicio.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            lblnicio.Location = new Point(160, 33);
            lblnicio.Name = "lblnicio";
            lblnicio.Size = new Size(115, 20);
            lblnicio.TabIndex = 1;
            lblnicio.Text = "Bienvenido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            label1.Location = new Point(118, 196);
            label1.Name = "label1";
            label1.Size = new Size(194, 20);
            label1.TabIndex = 2;
            label1.Text = "Selecciona un tema";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            lblName.Location = new Point(43, 78);
            lblName.Name = "lblName";
            lblName.Size = new Size(361, 20);
            lblName.TabIndex = 3;
            lblName.Text = "Ingrese el nombre de los jugadores: ";
            // 
            // txtJ1
            // 
            txtJ1.Font = new Font("Verdana", 10.2F);
            txtJ1.Location = new Point(79, 136);
            txtJ1.Name = "txtJ1";
            txtJ1.PlaceholderText = "Jugador 1";
            txtJ1.Size = new Size(125, 28);
            txtJ1.TabIndex = 4;
            // 
            // txtJ2
            // 
            txtJ2.Font = new Font("Verdana", 10.2F);
            txtJ2.Location = new Point(227, 136);
            txtJ2.Name = "txtJ2";
            txtJ2.PlaceholderText = "Jugador 2";
            txtJ2.Size = new Size(125, 28);
            txtJ2.TabIndex = 5;
            // 
            // btnFrutas
            // 
            btnFrutas.Font = new Font("Verdana", 10.2F);
            btnFrutas.Location = new Point(224, 247);
            btnFrutas.Name = "btnFrutas";
            btnFrutas.Size = new Size(128, 29);
            btnFrutas.TabIndex = 6;
            btnFrutas.Text = "Frutas";
            btnFrutas.UseVisualStyleBackColor = true;
            btnFrutas.Click += btnFrutas_Click;
            // 
            // btnNombres
            // 
            btnNombres.Font = new Font("Verdana", 10.2F);
            btnNombres.Location = new Point(79, 301);
            btnNombres.Name = "btnNombres";
            btnNombres.Size = new Size(125, 29);
            btnNombres.TabIndex = 7;
            btnNombres.Text = "Nombres";
            btnNombres.UseVisualStyleBackColor = true;
            btnNombres.Click += btnNombres_Click;
            // 
            // btnCiudades
            // 
            btnCiudades.Font = new Font("Verdana", 10.2F);
            btnCiudades.Location = new Point(129, 353);
            btnCiudades.Name = "btnCiudades";
            btnCiudades.Size = new Size(183, 51);
            btnCiudades.TabIndex = 8;
            btnCiudades.Text = "Ciudades de México";
            btnCiudades.UseVisualStyleBackColor = true;
            btnCiudades.Click += btnCiudades_Click;
            // 
            // btnSitiosWeb
            // 
            btnSitiosWeb.Font = new Font("Verdana", 10.2F);
            btnSitiosWeb.Location = new Point(224, 301);
            btnSitiosWeb.Name = "btnSitiosWeb";
            btnSitiosWeb.Size = new Size(128, 29);
            btnSitiosWeb.TabIndex = 8;
            btnSitiosWeb.Text = "Sitios Web";
            btnSitiosWeb.UseVisualStyleBackColor = true;
            btnSitiosWeb.Click += btnSitiosWeb_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 436);
            Controls.Add(btnSitiosWeb);
            Controls.Add(btnCiudades);
            Controls.Add(btnNombres);
            Controls.Add(btnFrutas);
            Controls.Add(txtJ2);
            Controls.Add(txtJ1);
            Controls.Add(lblName);
            Controls.Add(label1);
            Controls.Add(lblnicio);
            Controls.Add(btnAnimales);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ahorcado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAnimales;
        private Label lblnicio;
        private Label label1;
        private Label lblName;
        private TextBox txtJ1;
        private TextBox txtJ2;
        private Button btnFrutas;
        private Button btnNombres;
        private Button btnCiudades;
        private Button btnSitiosWeb;
    }
}
