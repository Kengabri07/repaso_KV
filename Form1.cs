using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repaso_KV
{
    public partial class Prieda : Form
    {
        Random rand = new Random(); //Crea un objeto que genere el número aleatorio
        int jugador = 0; //jugar
        int computadora = 0; // Computadora
        int intentos = 0; //Inicializar la variable

        public Prieda()
        {
            InitializeComponent();
        }
        private void btnpiedra_Click(object sender, EventArgs e)
        {
            jugador = 1;
            MessageBox.Show("has elegido piedra");
        }

        private void btnpapel_Click(object sender, EventArgs e)
        {
            jugador = 2; //papel
            MessageBox.Show("has elegido papel");
        }

        private void btntijeras_Click(object sender, EventArgs e)
        {
            jugador = 3; //tijeras
            MessageBox.Show("has elegido tijeras");
        }

        private void btnplay_Click(object sender, EventArgs e)

        // aqui comienza el juego

        {
            computadora = rand.Next(1, 4);


            if (jugador == 0)
            {
                MessageBox.Show("Debes elegir una opcion para iniciar el juego");
            }
            else
            {
                if (computadora == 1)
                {
                    MessageBox.Show("Eligio piedra");
                }
                else if (computadora == 2)
                {
                    MessageBox.Show("Eligio papel");
                }
                else if (computadora == 3)
                {
                    MessageBox.Show("Eligio tijera");
                }
            }

        }

        private void Prieda_Load(object sender, EventArgs e)
        {

        }
    }
