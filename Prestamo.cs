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
    public partial class Prestamo : Form
    {
        string nombre_cliente;
        String[] sexodisponibles = { "Hombre","Mujer","Prefiero no decirlo"};
        int[] cuotas = { 12, 24, 36, 48 };
        Dictionary<int, double> interes_b;
      public Prestamo(String nombre )
        {
            InitializeComponent();
            nombre_cliente = nombre;    
            interes_b= new Dictionary<int, double>();
            int i;
            double interes;
            for (i = 0, interes= 3.0; i<cuotas.Length;i++,interes+=0.5)
            {
                interes_b[cuotas[i]] = interes;
            }

        }



        double calcularInteres()
        {
            int cuotas_pedidas = (int)cuotabox.SelectedItem;
            String sexoselecionado=sexo.SelectedItem.ToString().ToLower();
            double interes = interes_b[cuotas_pedidas];
            return interes;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Prestamo_Load(object sender, EventArgs e)
        {
            Saludo.Text += nombre_cliente;
            pcuotas();
            sexos();
        }
        void pcuotas()
        {
            for (int i = 0; i < cuotas.Length; i++) 
            {
                cuotabox.Items.Add(cuotas[i]); 
            }
        }


        void sexos()
        {
            for (int i = 0; i < sexodisponibles.Length; i++)
            {
                sexo.Items.Add(sexodisponibles[i]);
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void confirmar_Click(object sender, EventArgs e)
        {
            switch(validaciones())
            {
               case 0:
                    {
                        errorProvider1.SetError(Datos, "");
                        errorProvider1.SetError(Detalles, "");
                        double interes_mensual = calcularInteres();
                        double dineropedido = double.Parse(dinero.Text);
                        int cuotaspedidas = (int)cuotabox.SelectedItem;
                        double interes_total = dineropedido * (interes_mensual / 100) * cuotaspedidas;
                        double monto_a_pagar = dineropedido + interes_total;
                        String mensaje = " Su prestamo por " + dineropedido + " en " + cuotaspedidas + " se concederá con el interes del " + interes_mensual + "% mensual \nEl monto final asciende a " + monto_a_pagar;
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(mensaje, "calculo de interes",buttons);
                        break;
                    
                    
                    }


                case 1:
                    errorProvider1.SetError(Datos, "Debe completar todos los datos");
                    errorProvider1.SetError(Detalles, "");
                    break;


               case 2:
                    errorProvider1.SetError(Datos, "");
                    errorProvider1.SetError(Detalles, "Debe completar todos los datos");
                    break;

             case 3:
               
                    errorProvider1.SetError(Datos, "Debe completar todos los datos");
                    errorProvider1.SetError(Detalles, "");
                    break;
            }
        }



        int validaciones()
        {
            if (sexo.SelectedIndex <= -1) 
            {
                return 1;
            }
            else
            {
                if (!(dinero.Text.All(Char.IsDigit))|| !(rut.Text.All(Char.IsDigit)) || (dinero.Text == "")  || (cuotabox.SelectedIndex <= -1))
                {

                    return 2;
                }
                if (rut.Text=="")
                {
                    return 3;
                }
                else
                {
                    return 0;
                }


            }



        }


        private void volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rut_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dinero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


 