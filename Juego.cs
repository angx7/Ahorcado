using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ahorcado
{
    public partial class Juego : Form
    {
        private static bool[] letrasIngresadas = new bool[26];
        string Jugador1 = "", Jugador2 = "", PalabraAdivinar = "", letrasEncontradas = "", errores = "";
        int op, score1 = 0, score2 = 0, fallosPermitidos = 6, fallos = 0, encontrados;
        bool turno = true;



        public Juego(string j1, string j2, int palabra)
        {
            InitializeComponent();
            Jugador1 = j1;
            Jugador2 = j2;
            op = palabra;
            PalabraAdivinar = GenerarPalabra(op);
            lblJugadorTurno.Text = "Turno de " + Jugador1;
            Array.Fill(letrasIngresadas, false);

        }

        private string GenerarPalabra(int op)
        {
            int numeroAleatorio;
            string PalabraAdivinar = "", tema = "";
            Random random = new Random();

            // Diccionario del juego
            string[] animales = { "perro", "gato", "caballo", "vaca", "oveja", "pollo", "pez", "mariposa", "abeja", "mono" };
            string[] frutas = { "manzana", "pera", "platano", "naranja", "uva", "sandia", "melon", "fresa", "mandarina", "aguacate" };
            string[] nombres = { "juan", "maria", "jose", "ana", "luis", "isabel", "pedro", "paula", "miguel", "daniela" };
            string[] sitiosWeb = { "google", "youtube", "facebook", "twitter", "amazon", "netflix", "instagram", "whatsapp", "mercadolibre" };
            string[] ciudadesMexico = { "cdmx", "guadalajara", "monterrey", "puebla", "leon", "tijuana", "juarez", "merida", "aguascalientes", "queretaro" };


            switch (op)
            {
                case 1:
                    numeroAleatorio = random.Next(10);
                    PalabraAdivinar = ciudadesMexico[numeroAleatorio];
                    tema = "Ciudades de México";
                    break;
                case 2:
                    numeroAleatorio = random.Next(10);
                    PalabraAdivinar = animales[numeroAleatorio];
                    tema = "Animales";
                    break;
                case 3:
                    numeroAleatorio = random.Next(10);
                    PalabraAdivinar = frutas[numeroAleatorio];
                    tema = "Frutas";
                    break;
                case 4:
                    numeroAleatorio = random.Next(10);
                    PalabraAdivinar = nombres[numeroAleatorio];
                    tema = "Nombres de personas";
                    break;
                case 5:
                    numeroAleatorio = random.Next(10);
                    PalabraAdivinar = sitiosWeb[numeroAleatorio];
                    tema = "Sitios Web";
                    break;
            }
            // Aparece la palabra a adivinar de forma oculta
            letrasEncontradas = iniciarLetrasEncontradas(PalabraAdivinar.Length);

            lblTema.Text = tema;

            lblPalabraN.Text = letrasEncontradas;

            return PalabraAdivinar;
        }

        private void Ganador(int score1, int score2, string j1, string j2)
        {
            if (score1 > score2)
            {
                MessageBox.Show("El jugador " + j1 + " ha ganado");
            }
            else if (score2 > score1)
            {
                MessageBox.Show("El jugador " + j2 + " ha ganado");
            }
            else
            {
                MessageBox.Show("La partida ha acabado en empate");
            }
        }


        public int Jugador(string j1, string j2, int score1, int score2, char letra)
        {

            int puntuacion = score1;

            bool adivinado = false;
            lblJugadorTurno.Text = "Turno de " + j1 + "\nPuntuación " + puntuacion;

            if (fallos < fallosPermitidos && adivinado == false)
            {
                if (letra == ' ')
                    adivinado = false;

                if (letrasIngresadas[letra - 'a'])
                {
                    MessageBox.Show("Ya has ingresado esa letra.\nIntenta con otra\n");
                    return puntuacion;
                }
                else
                {
                    letrasIngresadas[letra - 'a'] = true; // Marca la letra como ingresada
                }

                encontrados = actualizarFallos(PalabraAdivinar, letra);
                // intento de verificacion de letras

                MessageBox.Show("La palabra contiene " + encontrados + " '" + letra + "' en la palabra buscada");


                if (encontrados == 0)
                {
                    fallos++;
                    errores += letra + " ";
                    lblErrores.Text = "Errores " + errores;
                    //MessageBox.Show("Te restan " + (6 - fallos) + " intentos\n");
                    switch (6 - fallos)
                    {
                        case 5:
                            pbAhorcado.Image = Properties.Resources._2;
                            break;
                        case 4:
                            pbAhorcado.Image = Properties.Resources._3;
                            break;
                        case 3:
                            pbAhorcado.Image = Properties.Resources._4;
                            break;
                        case 2:
                            pbAhorcado.Image = Properties.Resources._5;
                            break;
                        case 1:
                            pbAhorcado.Image = Properties.Resources._6;
                            break;
                        case 0:
                            pbAhorcado.Image = Properties.Resources._7;
                            if (turno)
                            {
                                score1 = Jugador(Jugador1, Jugador2, score1, score2, letra);
                            }
                            else
                            {
                                score2 = Jugador(Jugador2, Jugador1, score2, score1, letra);
                            }
                            break;
                        default:
                            pbAhorcado.Image = Properties.Resources._1;
                            break;
                    }
                }
                letrasEncontradas = actualizarLetrasEncontradas(PalabraAdivinar, letra, letrasEncontradas.Replace(" ", ""));
                lblPalabra.Text = letrasEncontradas;
                txtLetra.Text = "";

                if (PalabraAdivinar.Equals(letrasEncontradas))
                {
                    Array.Fill(letrasIngresadas, false);
                    MessageBox.Show("Felicidades " + j1 + " has adivinado la palabra\n\n\nLa palabra oculta era: " + PalabraAdivinar);
                    fallos = 0;
                    errores = "";
                    pbAhorcado.Image = Properties.Resources._1;
                    adivinado = true;
                    PalabraAdivinar = GenerarPalabra(op);
                    lblErrores.Text = "Errores ";
                    puntuacion++;
                    lblJugadorTurno.Text = "Turno de " + j1 + "\nPuntuación " + puntuacion;
                    lblPalabra.Text = "";
                }
            }
            else
            {
                turno = !turno;
                Array.Fill(letrasIngresadas, false);
                MessageBox.Show("Fin de tu turno\n\n\nLa palabra oculta era: " + PalabraAdivinar);
                MessageBox.Show("\n\t Puntuaciones \n\n\t" + Jugador1 + "\t\t" + (turno ? score1 : puntuacion) + "\n\t" + Jugador2 + "\t\t" + (turno ? puntuacion : score2));
                lblErrores.Text = "Errores ";
                lblJugadorTurno.Text = "Turno de " + (turno ? Jugador1 : Jugador2) + "\nPuntuación " + score2;
                pbAhorcado.Image = Properties.Resources._1;
                fallos = 0;
                errores = "";
                PalabraAdivinar = GenerarPalabra(op);
                lblPalabra.Text = "";
            }

            return puntuacion;
        }

        private static int actualizarFallos(string PalabraAdivinar, char letra)
        {
            int encontrado = 0;
            for (int i = 0; i < PalabraAdivinar.Length; i++)
            {
                if (PalabraAdivinar[i] == letra)
                {
                    encontrado++;
                }
            }
            return encontrado;
        }

        private static string actualizarLetrasEncontradas(string PalabraAdivinar, char letra, string letrasEncontradas)
        {
            string actualizacionLetras = "";
            for (int i = 0; i < PalabraAdivinar.Length; i++)
            {
                if (letra == PalabraAdivinar[i])
                {
                    actualizacionLetras += letra;
                }
                else
                {
                    actualizacionLetras += letrasEncontradas[i];
                }
            }
            return actualizacionLetras;
        }

        private static string iniciarLetrasEncontradas(int longitud)
        {
            string letras = "";
            for (int i = 0; i < longitud; i++)
            {
                letras = letras + " _ ";
            }
            return letras;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estas seguro de querrer salir y terminar la partida?", "Terminar el juego", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Ganador(score1, score2, Jugador1, Jugador2);
                this.Close();
            }

        }

       
        private void button2_Click(object sender, EventArgs e)
        {

            if (txtLetra.Text == "")
            {
                MessageBox.Show("Por favor, ingrese una letra");
                return;
            }

            string texto = txtLetra.Text;
            char letra = texto[0];


            if (turno)
            {
                score1 = Jugador(Jugador1, Jugador2, score1, score2, letra);
            }
            else
            {
                score2 = Jugador(Jugador2, Jugador1, score2, score1, letra);
            }

        }

        private void txtLetra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back || e.KeyChar == 'ñ')
            {
                e.Handled = true;
            }
        }
    }
}
