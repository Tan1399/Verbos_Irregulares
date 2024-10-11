using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerbosIngles.FORMS
{
    public partial class Keep : Form
    {
        public Keep()
        {
            InitializeComponent();
        }

        public void MostrarVerbo(Form verboFomr)
        {
            verboFomr.Show();  // Muestra el formulario pasado como parámetro
            this.Close();       // Oculta el formulario actual (Dig)
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            MostrarVerbo(new Hold());

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            MostrarVerbo(new Kneel());

        }
    }
}
