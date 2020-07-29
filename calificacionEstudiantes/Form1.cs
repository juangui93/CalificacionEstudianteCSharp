using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calificacionEstudiantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (txtNota1.Text == "" 
                || txtNota2.Text == "" || 
                txtNota3.Text == "" || txtNota4.Text == "")
            {
                MessageBox.Show("Debes diligenciar todos los campos",
                    "Error del sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                double nota1, nota2, nota3, nota4, suma = 0, promedio = 0;

                nota1 = Double.Parse(txtNota1.Text);
                nota2 = Double.Parse(txtNota2.Text);
                nota3 = Double.Parse(txtNota3.Text);
                nota4 = Double.Parse(txtNota4.Text);

                suma = (nota1 + nota2 + nota3 + nota4);

                promedio = suma / 4;

                lblPromedio.Text = Convert.ToString(promedio);
                label6.Visible = true;
                lblPromedio.Visible = true;
            }
           
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNota1.Text = String.Empty;
            txtNota2.Text = String.Empty;
            txtNota3.Text = String.Empty;
            txtNota4.Text = String.Empty;
            label6.Visible = false;
            lblPromedio.Visible = false;
            txtNota1.Focus(); 
        }
    }
}
