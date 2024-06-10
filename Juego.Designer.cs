namespace Ahorcado
{
    partial class Juego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Juego));
            lblPalabra = new Label();
            button1 = new Button();
            lblTema = new Label();
            lblJugadorTurno = new Label();
            button2 = new Button();
            pbAhorcado = new PictureBox();
            txtLetra = new TextBox();
            lblErrores = new Label();
            lblPalabraN = new Label();
            ((System.ComponentModel.ISupportInitialize)pbAhorcado).BeginInit();
            SuspendLayout();
            // 
            // lblPalabra
            // 
            lblPalabra.AutoSize = true;
            lblPalabra.Font = new Font("Verdana", 10.2F);
            lblPalabra.Location = new Point(49, 312);
            lblPalabra.Name = "lblPalabra";
            lblPalabra.Size = new Size(0, 20);
            lblPalabra.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Verdana", 10.2F);
            button1.Location = new Point(433, 400);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblTema
            // 
            lblTema.AutoSize = true;
            lblTema.Font = new Font("Verdana", 10.2F);
            lblTema.Location = new Point(306, 30);
            lblTema.Name = "lblTema";
            lblTema.Size = new Size(54, 20);
            lblTema.TabIndex = 2;
            lblTema.Text = "Tema";
            // 
            // lblJugadorTurno
            // 
            lblJugadorTurno.AutoSize = true;
            lblJugadorTurno.Font = new Font("Verdana", 10.2F);
            lblJugadorTurno.Location = new Point(306, 72);
            lblJugadorTurno.Name = "lblJugadorTurno";
            lblJugadorTurno.Size = new Size(97, 20);
            lblJugadorTurno.TabIndex = 3;
            lblJugadorTurno.Text = "Turno de: ";
            // 
            // button2
            // 
            button2.Font = new Font("Verdana", 10.2F);
            button2.Location = new Point(306, 190);
            button2.Name = "button2";
            button2.Size = new Size(160, 29);
            button2.TabIndex = 4;
            button2.Text = "Insertar Letra";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pbAhorcado
            // 
            pbAhorcado.Image = Properties.Resources._1;
            pbAhorcado.Location = new Point(49, 30);
            pbAhorcado.Name = "pbAhorcado";
            pbAhorcado.Size = new Size(149, 189);
            pbAhorcado.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAhorcado.TabIndex = 5;
            pbAhorcado.TabStop = false;
            // 
            // txtLetra
            // 
            txtLetra.CharacterCasing = CharacterCasing.Lower;
            txtLetra.Font = new Font("Verdana", 10.2F);
            txtLetra.Location = new Point(306, 139);
            txtLetra.MaxLength = 1;
            txtLetra.Name = "txtLetra";
            txtLetra.Size = new Size(69, 28);
            txtLetra.TabIndex = 6;
            txtLetra.KeyPress += txtLetra_KeyPress;
            // 
            // lblErrores
            // 
            lblErrores.AutoSize = true;
            lblErrores.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblErrores.Location = new Point(29, 366);
            lblErrores.Name = "lblErrores";
            lblErrores.Size = new Size(78, 20);
            lblErrores.TabIndex = 7;
            lblErrores.Text = "Errores";
            // 
            // lblPalabraN
            // 
            lblPalabraN.AutoSize = true;
            lblPalabraN.Font = new Font("Verdana", 10.2F);
            lblPalabraN.Location = new Point(49, 262);
            lblPalabraN.Name = "lblPalabraN";
            lblPalabraN.Size = new Size(78, 20);
            lblPalabraN.TabIndex = 8;
            lblPalabraN.Text = "Palabra ";
            // 
            // Juego
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 441);
            Controls.Add(lblPalabraN);
            Controls.Add(lblErrores);
            Controls.Add(txtLetra);
            Controls.Add(pbAhorcado);
            Controls.Add(button2);
            Controls.Add(lblJugadorTurno);
            Controls.Add(lblTema);
            Controls.Add(button1);
            Controls.Add(lblPalabra);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Juego";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Juego";
            ((System.ComponentModel.ISupportInitialize)pbAhorcado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPalabra;
        private Button button1;
        private Label lblTema;
        private Label lblJugadorTurno;
        private Button button2;
        private PictureBox pbAhorcado;
        private TextBox txtLetra;
        private Label lblErrores;
        private Label lblPalabraN;
    }
}