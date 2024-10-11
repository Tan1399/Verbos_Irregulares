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
    public partial class Freeze : Form
    {
        public Freeze()
        {
            InitializeComponent();
        }

        public void Give()
        {
            Give Gv = new Give();
            Gv.Show();


        }



        public void volver()
        {

            Forgive Fv = new Forgive();
            Fv.Show();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Give();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }

        private void Freeze_Load(object sender, EventArgs e)
        {

        }
    }
}
