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
    public partial class Forgive : Form
    {
        public Forgive()
        {
            InitializeComponent();
        }
        public void Freeze()
        {
            Freeze fr = new Freeze();
            fr.Show();


        }



        public void volver()
        {

            Forget fr = new Forget();
            fr.Show();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Freeze();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();


        }
    }
}
