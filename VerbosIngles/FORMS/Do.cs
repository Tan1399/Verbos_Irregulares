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
    public partial class Do : Form
    {
        public Do()
        {
            InitializeComponent();


        }

        public void Draw()
        {
            Draw dw = new Draw();
            dw.Show();


        }



        public void volver()
        {

            Choose d = new Choose();
            d.Show();

        }

        private void Do_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            volver();
            this.Hide();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

            
            Draw();
            this.Hide();
        }
    }
}
