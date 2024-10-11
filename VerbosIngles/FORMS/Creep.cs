using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerbosIngles.FORMS
{
    public partial class Creep : Form
    {
        public Creep()
        {
            InitializeComponent();
        }

        public void Catch()
        {

            Deal dl = new Deal();
            dl.Show();


        }


        public void volver()
        {
            Cling cl = new Cling();
            cl.Show();

        }


        private void iconButton2_Click(object sender, EventArgs e)
        {
            Catch();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            volver();
            this.Hide();
        }
    }
}
