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
    public partial class Forbid : Form
    {
        public Forbid()
        {
            InitializeComponent();
        }

        public void Forget()
        {
            Forget ft = new Forget();
            ft.Show();


        }



        public void volver()
        {

            Fly fl = new Fly();
            fl.Show();

        }

        private void Forbid_Load(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Forget();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }
    }
}
