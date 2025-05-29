using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeManager.Form_management;

namespace CafeManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        } 


        private void tsMenu_Click(object sender, EventArgs e)
        {
            Menu formMenu = new Menu();
                formMenu.Show();
            this.Hide();
        }

        private void tsExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsHome_Click(object sender, EventArgs e)
        {
            
        }

        private void tsTable_Click(object sender, EventArgs e)
        {
            Table formTable = new Table();
            formTable.Show();
            this.Hide();
        }
    }
}
