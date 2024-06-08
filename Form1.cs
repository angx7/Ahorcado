namespace Ahorcado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCiudades_Click(object sender, EventArgs e)
        {
            if (txtJ1.Text == "" || txtJ2.Text == "")
            {
                MessageBox.Show("Por favor, ingrese los nombres de los jugadores");
                return;
            }


            this.Hide();
            Juego form2 = new Juego(txtJ1.Text, txtJ2.Text, 1);
            form2.Show();
        }

        private void btnAnimales_Click(object sender, EventArgs e)
        {
            if (txtJ1.Text == "" || txtJ2.Text == "")
            {
                MessageBox.Show("Por favor, ingrese los nombres de los jugadores");
                return;
            }

            this.Hide();
            Juego form2 = new Juego(txtJ1.Text, txtJ2.Text, 2);
            form2.Show();
        }

        private void btnFrutas_Click(object sender, EventArgs e)
        {
            if (txtJ1.Text == "" || txtJ2.Text == "")
            {
                MessageBox.Show("Por favor, ingrese los nombres de los jugadores");
                return;
            }


            this.Hide();
            Juego form2 = new Juego(txtJ1.Text, txtJ2.Text, 3);
            form2.Show();
        }

        private void btnNombres_Click(object sender, EventArgs e)
        {
            if (txtJ1.Text == "" || txtJ2.Text == "")
            {
                MessageBox.Show("Por favor, ingrese los nombres de los jugadores");
                return;
            }


            this.Hide();
            Juego form2 = new Juego(txtJ1.Text, txtJ2.Text, 4);
            form2.Show();
        }

        private void btnSitiosWeb_Click(object sender, EventArgs e)
        {
            if (txtJ1.Text == "" || txtJ2.Text == "")
            {
                MessageBox.Show("Por favor, ingrese los nombres de los jugadores");
                return;
            }


            this.Hide();
            Juego form2 = new Juego(txtJ1.Text, txtJ2.Text, 5);
            form2.Show();
        }

    }
}
