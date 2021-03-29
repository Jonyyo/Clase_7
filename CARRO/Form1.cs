using CARRO.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARRO
{
    public partial class Form1 : Form
    {
        ClsAutomotor carrito;
        private string ruta = "";
        

        public Form1()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.Visible = false;
        }
        

        private void buttoninicio_Click(object sender, EventArgs e)
        {
            carrito = new ClsAutomotor("Shelby Mustang", 130);
            carrito.color = "Blanco";

            
           
            buttonEncender.Visible = true;
            buttoninicio.Visible = false;

            MessageBox.Show($"El carro {carrito.marca} llega a {carrito.vel_max} KPH");
        }

        private void buttonEncender_Click(object sender, EventArgs e)
        {
            labelEstado.Text = $"El carro {carrito.marca} : {carrito.encender()}";
           
            
            if (carrito.encendido == true)
            {
                btnCargar.Visible = true;
                btnReproducir.Visible = true;
                axWindowsMediaPlayer1.Visible = true;
                buttonAltoTotal.Visible = true;
                buttonAcelerar.Visible = true;
                labelCambio.Visible = true;
                labelEstadoVelocidad.Visible = true;
                
            }
            else
            {
                btnCargar.Visible = false;
                btnReproducir.Visible = false;
                axWindowsMediaPlayer1.Visible = false;
                buttonAltoTotal.Visible = false;
                buttonAcelerar.Visible = false;
                labelCambio.Visible = false;
                labelEstadoVelocidad.Visible = false;
            }
        }

        private void buttonAcelerar_Click(object sender, EventArgs e)
        {
            if (carrito == null)
            {
                MessageBox.Show("Crea el carro primero");
            }
            else
            {
                labelEstadoVelocidad.Text = carrito.Acelerar();
            }
            labelCambio.Text = carrito.Sugcambio();

            if (carrito.cambio() == true)
            {
                buttonCambio.Visible = true;
                buttonAcelerar.Visible = false;
                
            }
            if (carrito.ApaEncen() == true)
            {
                buttonEncender.Visible = true;
            }
            else
            {
                buttonEncender.Visible = false;
            }
        }

        private void buttonAltoTotal_Click(object sender, EventArgs e)
        {
            labelEstadoVelocidad.Text = carrito.DeterMarcha();
            labelCambio.Text = carrito.Sugcambio();
            if (carrito.ApaEncen() == true)
            {
                buttonEncender.Visible = true;
            }
            else
            {
                buttonEncender.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonAcelerar.Visible = true;
            buttonCambio.Visible = false;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                ruta = openFileDialog1.FileName;
                lblRuta.Text = ruta;
            }

        }

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = ruta;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
