using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBasicExercise4
{
    public partial class GastosEnvio : Form
    {
        public GastosEnvio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            Double resultado = 0;
            Boolean valid = true;
            if(correoNormalRadioButton.Checked == true)
            {
                resultado += 2;
            }
            else if(PaqueteriaNormalRadioButton.Checked == true)
            {
                resultado += 3;
            }
            else if(PaqueteriaUrgenteRadioButton.Checked == true)
            {
                resultado += 5;
            }
            else
            {
                valid = false;
                MessageBox.Show("Tiene que selecciona un modo de envío. Por favor, revise el formulario.");
            }

            if(telefonoCheckBox.Checked == true)
            {
                resultado += 0.85;
            }
            if(EmailCheckBox.Checked == true)
            {
                resultado += 0.25;
            }
            if(faxCheckBox.Checked == true)
            {
                resultado += 0.65;
            }
            if (valid)
            {
                resultadoLabel.Text = resultado + " €";
                costeLabel.Visible = true;
                resultadoLabel.Visible = true;
            }

        }
    }
}
