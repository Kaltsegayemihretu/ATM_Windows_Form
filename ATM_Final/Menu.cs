using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Final
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WithdrawalWindow withdrawalWindow = new WithdrawalWindow();
            withdrawalWindow.Show();

            this.Hide();  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TransferWindow transferWindow = new TransferWindow();
            transferWindow.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DepositWindow depositWindow = new DepositWindow();
            depositWindow.Show();

            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.button1.Image = Properties.Resources.MenuButtons_Hover;
            this.Cursor = Cursors.Hand;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.Image = Properties.Resources.MenuButtons3;
            this.Cursor = Cursors.Arrow;
        }
    }
}
