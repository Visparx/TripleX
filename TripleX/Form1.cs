using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TripleX
{
    public partial class Form1 : Form
    {
        bool xTurn = true;
        bool gameStarted = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button senderB = (Button)sender;
            if (xTurn)
            {
                senderB.Text = "X";
            }
            else
            {
                senderB.Text = "O";
            }
            xTurn = !xTurn;
            senderB.Enabled = false;
            gameStarted = true;

            CheckWin(senderB);
        }

        void CheckWin( Button pressedButton)
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text && button2.Enabled == false)
            {
                MessageBox.Show("Победили " + pressedButton.Text +" !");
                Application.Restart();
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text && button5.Enabled == false)
            {
                MessageBox.Show("Победили " + pressedButton.Text + " !");
                Application.Restart();
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text && button8.Enabled == false)
            {
                MessageBox.Show("Победили " + pressedButton.Text + " !");
                Application.Restart();
            }


            if (button1.Text == button4.Text && button4.Text == button7.Text && button4.Enabled == false)
            {
                MessageBox.Show("Победили " + pressedButton.Text + " !");
                Application.Restart();
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text && button5.Enabled == false)
            {
                MessageBox.Show("Победили " + pressedButton.Text + " !");
                Application.Restart();
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text && button6.Enabled == false)
            {
                MessageBox.Show("Победили " + pressedButton.Text + " !");
                Application.Restart();
            }

            if (button1.Text == button5.Text && button5.Text == button9.Text && button5.Enabled == false)
            {
                MessageBox.Show("Победили " + pressedButton.Text + " !");
                Application.Restart();
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text && button5.Enabled == false)
            {
                MessageBox.Show("Победили " + pressedButton.Text + " !");
                Application.Restart();
            }
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gameStarted ==false)
            {
                xTurn = true;
            } else
            {
                MessageBox.Show("Нельзя менять сторону во время игры!");
            }
        }

        private void oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gameStarted == false)
            {
                xTurn = false;
            }
            else
            {
                MessageBox.Show("Нельзя менять сторону во время игры!");
            }
        }

        private void creatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Создатель: Дмитрий Елизарьев ");
        }
    }
}
