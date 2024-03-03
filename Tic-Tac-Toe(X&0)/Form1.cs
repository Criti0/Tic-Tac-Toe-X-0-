using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_X_0_
{
    public partial class Form1 : Form
    {
        char aux = 'x';
        short k = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void b11_Click(object sender, EventArgs e)
        {

        }

        private void ResetGame()
        {
            b11.Enabled = true; b11.Text = "";
            b12.Enabled = true; b12.Text = "";
            b13.Enabled = true; b13.Text = "";
            b21.Enabled = true; b21.Text = "";
            b22.Enabled = true; b22.Text = "";
            b23.Enabled = true; b23.Text = "";
            b31.Enabled = true; b31.Text = "";
            b32.Enabled = true; b32.Text = "";
            b33.Enabled = true; b33.Text = "";
            tableLayoutPanel1.Enabled = true;
            aux = 'x';
            k = 0;
        }
        private void button_Click(object sender, EventArgs e)
        {
            DialogResult ans;
            Button bt = sender as Button;
            bt.Enabled = true;
            bt.BackColor = Color.Orange;
            if(aux=='x')
            {
                bt.Text= "X";
                if((b11.Text == b12.Text && b12.Text == b13.Text && b12.Text !="") ||
                   (b21.Text == b22.Text && b22.Text == b23.Text && b22.Text != "") ||
                   (b31.Text == b32.Text && b32.Text == b33.Text && b32.Text != "") ||
                   (b11.Text == b21.Text && b21.Text == b31.Text && b21.Text != "") ||
                   (b12.Text == b22.Text && b22.Text == b32.Text && b22.Text != "")  ||
                   (b13.Text == b23.Text && b23.Text == b33.Text && b23.Text != "") ||
                   (b11.Text == b22.Text && b22.Text == b33.Text && b22.Text != "") ||
                   (b13.Text == b22.Text && b22.Text == b31.Text && b22.Text != ""))
                {
                    ans = MessageBox.Show("Castigator este: " + aux.ToString().ToUpper());
                    if (ans == DialogResult.OK)
                    {   

                        Application.Exit();
                    }
                    tableLayoutPanel1.Enabled = false;

                }
                else if (k == 8)
                {

                    ans = MessageBox.Show("Castigator este: " + aux.ToString().ToUpper());
                    if (ans == DialogResult.OK)
                    {

                        Application.Exit();
                    }
                }
                aux = 'o';
            }
            else if(aux=='o')
            {
                
                bt.Text= "O";
                if ((b11.Text == b12.Text && b12.Text == b13.Text && b12.Text != "") ||
                   (b21.Text == b22.Text && b22.Text == b23.Text && b22.Text != "") ||
                   (b31.Text == b32.Text && b32.Text == b33.Text && b32.Text != "") ||
                   (b11.Text == b21.Text && b21.Text == b31.Text && b21.Text != "") ||
                   (b12.Text == b22.Text && b22.Text == b32.Text && b22.Text != "") ||
                   (b13.Text == b23.Text && b23.Text == b33.Text && b23.Text != "") ||
                   (b11.Text == b22.Text && b22.Text == b33.Text && b22.Text != "") ||
                   (b13.Text == b22.Text && b22.Text == b31.Text && b22.Text != ""))
                {
                    ans = MessageBox.Show("Castigator este: " + aux.ToString().ToUpper() );
                    if (ans == DialogResult.OK)
                    {

                        Application.Exit();
                    }
                    tableLayoutPanel1.Enabled = false;
                }
                else if(k==8)
                {
                    ans = MessageBox.Show("Castigator este: " + aux.ToString().ToUpper() );
                    if (ans == DialogResult.OK)
                    {

                        Application.Exit();
                    }
                }
                aux = 'x';
            }
            k++;
        }

    }
}
