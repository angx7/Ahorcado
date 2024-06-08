using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcado
{
    public partial class Juego : Form
    {
        public Juego(String palabra)
        {
            InitializeComponent();
            //lblPalabra.Text = iniciarLetrasEncontradas(palabra.Length);
            jugador1("j1", "j2", 0, 0, 1);
        }



        public int jugador1(string j1, string j2, int score1, int score2, int op)
        {

            int puntuacion = score2, fallosPermitidos = 6, fallos = 0, encontrados, numeroAleatorio;
            char letra;
            string PalabraAdivinar = "", letrasEncontradas = "", Mensaje = "", tema = "";
            bool adivinado = false;

            // letrasEncontradas = iniciarLetrasEncontradas(PalabraAdivinar.Length);
            Random random = new Random();

            // Diccionario del juego
            string[] animales = { "perro", "gato", "caballo", "vaca", "oveja", "pollo", "pez", "mariposa", "abeja",
                "mono" };
            string[] frutas = { "manzana", "pera", "platano", "naranja", "uva", "sandia", "melon", "fresa", "mandarina",
                "aguacate" };
            string[] nombres = { "juan", "maria", "jose", "ana", "luis", "isabel", "pedro", "paula", "miguel", "daniela" };
            string[] sitiosWeb = { "google", "youtube", "facebook", "twitter", "amazon", "netflix", "instagram", "whatsapp",
                "mercadolibre" };
            string[] ciudadesMexico = { "cdmx", "guadalajara", "monterrey", "puebla", "leon", "tijuana", "juarez", "merida",
                "aguascalientes", "queretaro" };

            do
            {
                adivinado = false;
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



                letrasEncontradas = iniciarLetrasEncontradas(PalabraAdivinar.Length);

            } while (adivinado == true && puntuacion < 3);

            return puntuacion;
        }

        private static string iniciarLetrasEncontradas(int longitud)
        {
            string letras = "";
            for (int i = 0; i < longitud; i++)
            {
                letras = letras + 0;
            }
            return letras;
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

        private static String iniciarLetrasEncontradas(int longitud)
        {
            String letras = "";
            for (int i = 0; i < longitud; i++)
            {
                letras = letras + " _ ";
            }
            return letras;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
