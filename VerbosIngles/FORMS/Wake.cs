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
    public partial class Wake : Form
    {
        public Wake()
        {
            InitializeComponent();
        }


        public void Wear()
        {
            Wear wr = new Wear();
            wr.Show();


        }



        public void volver()
        {

            Throw th = new Throw();
            th.Show();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Wear();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }

        private void Wake_Load(object sender, EventArgs e)
        {

        }
    }
}
