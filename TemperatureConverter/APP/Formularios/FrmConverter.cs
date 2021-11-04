using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP.Formularios
{
    public partial class FrmConverter : Form
    {
        public FrmConverter()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Convertir()
        {

            if(txtingresa.Text!= " "&& txtingresa.Text!="-")
            {
                double dato = Convert.ToDouble(txtingresa.Text);
                int tipo1 = cmbEleccionIngresa.SelectedIndex;
                int tipo2 = cmbEleccionIngresa2.SelectedIndex;

                //0.  Celsius
                //1. Fahrenheit
                //2.Kelvin

                switch (tipo1)
                {

                    case 0:
                        if (tipo2 == 0)
                        {
                            cmbEleccionIngresa.SelectedIndex = 1;
                            break;
                        }

                        if (tipo2 == 1)
                        {
                            txtSalida.Text = (dato*1.8+32).ToString();
                            break;
                        }

                        if (tipo2 == 2)
                        {
                            txtSalida.Text = (dato + 273.15).ToString();
                            break;
                        }
                        break;

                    case 1:
                        if (tipo2 == 0)
                        {
                            txtSalida.Text = ((dato-32)/1.8).ToString();
                            break;
                        }

                        if (tipo2 == 1)
                        {
                            cmbEleccionIngresa.SelectedIndex = 2;
                            break;
                        }

                        if (tipo2 == 2)
                        {
                            txtSalida.Text = (((dato-32)/1.8)+273.15).ToString();
                            break;
                        }

                        break;

                    case 2:
                        if (tipo2 == 0)
                        {
                            txtSalida.Text = (dato-273.15).ToString();
                            break;
                        }

                        if (tipo2 == 1)
                        {
                            txtSalida.Text = ((dato-273.15)*1.8+32).ToString();
                            break;
                        }

                        if (tipo2 == 2)
                        {
                            cmbEleccionIngresa.SelectedIndex = 0;
                            break;
                        }
                        break;
                }

            }
           




        }

        private void cmbEleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Convertir();
        }

        private void cmbConverter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Convertir();
        }

       

        private void txtingresa_TextChanged(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Add();
            int c = dataGridView1.Rows.Count - 1;

            dataGridView1[0, c].Value = txtingresa.Text;
            dataGridView1[1, c].Value = cmbEleccionIngresa.Text;
            dataGridView1[2, c].Value = txtSalida.Text;
            dataGridView1[3, c].Value = cmbEleccionIngresa2.Text;


        }
    }
}
