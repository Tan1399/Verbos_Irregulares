using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VerbosIngles.FORMS;

namespace VerbosIngles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Seleccion();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;
        }


        public void salir()
        {
            Application.Exit();

          
        }

        public void Seleccion()
        {


            comboBox1.Items.Add("Irregular: Base = Past simple = Past participle");
            comboBox1.Items.Add("Irregular: Base ≠ Past simple ≠ Past participle");
            comboBox1.Items.Add("Irregular: Base = Past simple ≠ Past participle");
            comboBox1.Items.Add("Irregular: Base = Past partciple ≠ Past simple");
            comboBox1.Items.Add("Irregular: Base ≠ Past partciple = Past simple");
            comboBox1.Items.Add("Irregular: Specials");
        }

        public void tres_distintos()
        {

            Arise ar = new Arise();

            ar.Show();

        }

        public void todos_iguales()
        {


            bet bt = new bet();

            bt.Show();

        }

        public void dos_iguales_1distinto() {
            Beat bt = new Beat();
            bt.Show();
 
            
        }

        public void b_y_pasiguales() {

            Become bc = new Become();
            bc.Show();
        
        
        }


        public void dos_distintos_1igual() {

            Bent bt = new Bent();
            bt.Show();
        
        
        
        }

        public void speciales() {


            Can c = new Can();
            c.Show();
        
        }








        private void iconButton2_Click(object sender, EventArgs e)
        {
            salir();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }



        private void iconButton1_Click(object sender, EventArgs e)


        {

            string selectedDepartment = comboBox1.SelectedItem?.ToString();


            switch (selectedDepartment)
            {
                case "Irregular: Base = Past simple = Past participle":
                    {

                        todos_iguales();

                        this.Hide();



                        break;

                    }

                case "Irregular: Base ≠ Past simple ≠ Past participle":
                    {

                        tres_distintos();
                        this.Hide();


                        break;



                    }
                case "Irregular: Base = Past simple ≠ Past participle":
                    {

                        dos_iguales_1distinto();
                        this.Hide();
                        break;



                    }

                case "Irregular: Base = Past partciple ≠ Past simple": {

                        b_y_pasiguales();
                        this.Hide();
                        break;



                    }

                case "Irregular: Base ≠ Past partciple = Past simple":
                    {
                        dos_distintos_1igual();
                        this.Hide();
                        break;
                    }


                case "Irregular: Specials":
                    {
                        speciales();
                        this.Hide();
                        break;
                    }










            }
        }
    }
}
