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
        }
    }
}
