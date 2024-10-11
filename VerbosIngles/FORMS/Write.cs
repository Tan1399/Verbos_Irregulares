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
    public partial class Write : Form
    {
        public Write()
        {
            InitializeComponent();
        }

        public void Inicio()
        {
            Form1 f1 = new Form1();
            f1.Show();


        }



        public void volver()
        {

            Wear wr = new Wear();
           wr.Show();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Inicio();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }
    }
}
