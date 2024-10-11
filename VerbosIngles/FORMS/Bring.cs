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
    public partial class Bring : Form
    {
        public Bring()
        {
            InitializeComponent();
        }

        public void bind()
        {

            Build bd = new Build();
            bd.Show();


        }


        public void volver()
        {

            Breed br = new Breed();
            br.Show();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            bind();
            this.Hide();

        }
    }
}
