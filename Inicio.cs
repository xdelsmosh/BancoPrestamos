using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoPrestamos
{
    public partial class Incio : Form
    {
        public Incio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void controlbotones()
        {
            if(Nombre.Text.Trim() !=String.Empty && Nombre.Text.All(char.IsLetter))
            {
                Solicitar.Enabled = true;
                errorProvider1.SetError(Nombre, "");
            }
            else
            {
                if (!(Nombre.Text.All(char.IsLetter)))
                {
                    errorProvider1.SetError(Nombre, "El nombre sólo debe contener letras");
                }
                else
                {
                    errorProvider1.SetError(Nombre, "Debe introducir su nombre");
                }
                Solicitar.Enabled = false;
                Nombre.Focus();

            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            controlbotones();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Incio_Load(object sender, EventArgs e)
        {
            Solicitar.Enabled = false;
        }

        private void Solicitar_Click(object sender, EventArgs e)
        {
            using (Prestamo Prestamoventana = new Prestamo(Nombre.Text))
                Prestamoventana.ShowDialog();   
        }
    }
}
