﻿using System;
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
    public partial class Buy : Form
    {
        public Buy()
        {
            InitializeComponent();
        }

        public void Catch()
        {

            Catch ct = new Catch();
            ct.Show();


        }


        public void volver()
        {

            Burn br = new Burn();
            // br.Hide();
            br.Show();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Catch();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }
    }
}
