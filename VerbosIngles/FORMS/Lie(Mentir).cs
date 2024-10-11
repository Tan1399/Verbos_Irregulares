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
    public partial class Lie_Mentir_ : Form
    {
        public Lie_Mentir_()
        {
            InitializeComponent();
        }

        public void MostrarVerbo(Form verboFomr)
        {
            verboFomr.Show();  // Muestra el formulario pasado como parámetro
            this.Close();       // Oculta el formulario actual (Dig)
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            MostrarVerbo(new Light());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            MostrarVerbo(new Lend());
        }
        
    }
}
