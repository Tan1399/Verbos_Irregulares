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
    public partial class Hit : Form
    {
        public Hit()
        {
            InitializeComponent();
        }

        public void Hurt()
        {
            Hurt hurt = new Hurt();
            hurt.Show();


        }



        public void volver()
        {

            Cut ct = new Cut();
            ct.Show();

        }

        private void Hit_Load(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Hurt();
            this.Hide();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }
    }
}
