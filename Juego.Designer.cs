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
            lblPalabra = new Label();
            button1 = new Button();
            lblTema = new Label();
            SuspendLayout();
            // 
            // lblPalabra
            // 
            lblPalabra.AutoSize = true;
            lblPalabra.Location = new Point(166, 101);
            lblPalabra.Name = "lblPalabra";
            lblPalabra.Size = new Size(50, 20);
            lblPalabra.TabIndex = 0;
            lblPalabra.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(469, 265);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblTema
            // 
            lblTema.AutoSize = true;
            lblTema.Location = new Point(218, 180);
            lblTema.Name = "lblTema";
            lblTema.Size = new Size(50, 20);
            lblTema.TabIndex = 2;
            lblTema.Text = "label1";
            // 
            // Juego
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTema);
            Controls.Add(button1);
            Controls.Add(lblPalabra);
            Name = "Juego";
            Text = "Juego";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPalabra;
        private Button button1;
        private Label lblTema;
    }
}