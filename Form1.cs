namespace Ahorcado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {

            string[] animales = { "perro", "gato", "caballo", "vaca", "oveja", "pollo", "pez", "mariposa", "abeja", "mono" };
            string[] frutas = { "manzana", "pera", "platano", "naranja", "uva", "sandia", "melon", "fresa", "mandarina", "aguacate" };
            string[] nombres = { "juan", "maria", "jose", "ana", "luis", "isabel", "pedro", "paula", "miguel", "daniela" };
            string[] sitiosWeb = { "google", "youtube", "facebook", "twitter", "amazon", "netflix", "instagram", "whatsapp", "mercadolibre" };
            string[] ciudadesMexico = { "cdmx", "guadalajara", "monterrey", "puebla", "leon", "tijuana", "juarez", "merida", "aguascalientes", "queretaro" };

            Random generadorAleatorio = new Random();
            int indiceAleatorio = generadorAleatorio.Next(animales.Length);
            string palabraAleatoria = animales[indiceAleatorio];

            lblnicio.Text = palabraAleatoria;

            this.Hide();
            Juego form2 = new Juego(palabraAleatoria);
            form2.Show();
        }
    }
}
