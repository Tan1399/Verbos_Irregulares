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
    public partial class Forget : Form
    {
        public Forget()
        {
            InitializeComponent();
        }
        public void Forgive()
        {
            Forgive fv = new Forgive();
            fv.Show();


        }



        public void volver()
        {

            Forbid fb = new Forbid();
            fb.Show();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Forgive();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }

        private void Forget_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
