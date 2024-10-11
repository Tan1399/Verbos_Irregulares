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
    public partial class Read : Form
    {
        public Read()
        {
            InitializeComponent();
        }

        public void Set() {


            Set st = new Set();
            st.Show();

        
        
        }


        public void volver()
        {

            Put pt = new Put();
            pt.Show();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Set();
            this.Close();


        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Close();

        }
    }
}
