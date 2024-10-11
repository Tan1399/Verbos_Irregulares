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
    public partial class Tear : Form
    {
        public Tear()
        {
            InitializeComponent();
        }

        public void Throw()
        {
            Throw th = new Throw();
            th.Show();


        }



        public void volver()
        {

            Take tk = new Take();
            tk.Show();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Throw();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }
    }
}
