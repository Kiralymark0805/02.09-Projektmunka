using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    public partial class jatekvege : Form
    {
        int countdown = 5;
        public jatekvege()
        {
            InitializeComponent();
        }

        private void jatekvege_Load(object sender, EventArgs e)
        {
            wontimer.Start();
        }

        private void wontimer_Tick(object sender, EventArgs e)
        {
            countdown--;

            if (countdown == 0)
            {             
                this.Hide();
                playmenu newgame = new playmenu();
                newgame.ShowDialog();
                this.Close();
                wontimer.Stop();
            }
        }
    }
}
