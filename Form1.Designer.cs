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
            btnInicio = new Button();
            lblnicio = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnInicio
            // 
            btnInicio.Location = new Point(593, 347);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(94, 29);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "Animales";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // lblnicio
            // 
            lblnicio.AutoSize = true;
            lblnicio.Location = new Point(322, 27);
            lblnicio.Name = "lblnicio";
            lblnicio.Size = new Size(83, 20);
            lblnicio.TabIndex = 1;
            lblnicio.Text = "Bienvenido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 116);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 2;
            label1.Text = "Selecciona un tema";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._7;
            pictureBox1.Location = new Point(365, 147);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(lblnicio);
            Controls.Add(btnInicio);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInicio;
        private Label lblnicio;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
