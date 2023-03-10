using menu.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace menu
{
    public partial class jatek : Form
    {
        
        Random Randomnumber = new Random();

        List<PictureBox> enemylist = new List<PictureBox>();
        List<PictureBox> keylist = new List<PictureBox>();
        List<Panel> panellist = new List<Panel>();

        bool Moveup, Movedown, Moveleft, Moveright;

        int playerspeed = 15;
        int enemyspeed = 2;

        int enemycount = 2;
       
        int keycount = 5;
        int pickedupkeys = 0;

        bool won = false;
        public jatek()
        {
            InitializeComponent();
        }

        private void movetimerevent(object sender, EventArgs e)
        {

            Playermovement();
            Enemymovement();
            Walls();
            Gameover();
        }

        private void jatek_Load(object sender, EventArgs e)
        {
            Makeenemies();
            MakeKeys();
            player.BackColor = Color.Transparent;
        }

        private void keydownpress(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                Moveleft = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                Moveright = true;
            }

            if (e.KeyCode == Keys.Up)
            {
                Moveup = true;
            }

            if (e.KeyCode == Keys.Down)
            {
                Movedown = true;
            }

            foreach (PictureBox key in keylist)
            {
                if (player.Bounds.IntersectsWith(key.Bounds))
                {
                    if (e.KeyCode == Keys.F)
                    { 

                        pickedupkeys++;
                        keytext.Text = "kulcsok száma: " + pickedupkeys.ToString();
                        house.Controls.Remove(key);

                    }
                    
                }
            }

            if (pickedupkeys == keycount)
            {
                PictureBox winplace = new PictureBox();
                winplace.Width = 50;
                winplace.Height = 40;
                winplace.Location = new Point(100, 0);
                winplace.BackgroundImage = Resources.door;

                house.Controls.Add(winplace);

                if (player.Bounds.IntersectsWith(winplace.Bounds))
                {

                    if (e.KeyCode == Keys.O)
                    {
                        won = true;
                        this.Hide();
                        wingame win = new wingame();
                        win.ShowDialog();
                        this.Close();

                        foreach (PictureBox enemy in enemylist)
                        {
                            enemylist.Clear();
                            house.Controls.Remove(enemy);
                            
                        }
                    }
                   
                }
            }

        }

        private void keyuppress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Moveleft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                Moveright = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                Moveup = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                Movedown = false;
            }
        }

        private void Walls()
        {
            panellist.Add(panel1);
            panellist.Add(panel2);
            panellist.Add(panel3);
            panellist.Add(panel4);
            panellist.Add(panel5);
            panellist.Add(panel6);
            panellist.Add(panel7);
            panellist.Add(panel8);
            panellist.Add(panel9);
            panellist.Add(panel10);
            panellist.Add(panel11);
            panellist.Add(panel12);
            panellist.Add(panel13);
            panellist.Add(panel14);
            panellist.Add(panel15);
            panellist.Add(panel16);
            panellist.Add(panel17);
            panellist.Add(panel18);
            panellist.Add(panel19);
            panellist.Add(panel20);
            panellist.Add(panel21);
        }

        private void Makeenemies()
        {
            while (enemylist.Count != enemycount)
            {

                PictureBox enemy = new PictureBox();
                enemy.Width = 50;
                enemy.Height = 50;
                enemy.Tag = "enemy";
                enemy.BackgroundImage = Resources.ghost;
                enemy.BackColor = Color.Transparent;

                int enemyx = Randomnumber.Next(this.house.Width - enemy.Width);
                int enemyy = Randomnumber.Next(this.house.Height - enemy.Height);

                enemy.Location = new Point(enemyx, enemyy);

                enemylist.Add(enemy);
                house.Controls.Add(enemy);

            }
        }

        private void MakeKeys()
        {
            while (keylist.Count != keycount)
            {


                PictureBox key = new PictureBox();
                key.Width = 30;
                key.Height = 30;
                key.Tag = "keys";
                key.BackgroundImage = Resources.kulcs;
                key.BackColor = Color.Transparent;

                int keyx = Randomnumber.Next(this.house.Width - key.Width);
                int keyy = Randomnumber.Next(this.house.Height - key.Height);

                key.Location = new Point(keyx, keyy);
                keylist.Add(key);
                house.Controls.Add(key);
            }
        }



        private void Playermovement()
        {
            player.Tag = "player";
            house.Controls.Add(player);

            PictureBox move = new PictureBox();
            move.Width = player.Width;
            move.Height = player.Height;
            move.Left = player.Left;
            move.Top = player.Top;

            bool canmove = true;

            if (Moveleft)
            {
                move.Left -= playerspeed;
            }

            if (Moveright)
            {
                move.Left += playerspeed;
            }

            if (Moveup)
            {
                move.Top -= playerspeed;
            }

            if (Movedown)
            {
                move.Top += playerspeed;
            }

            foreach (Panel wall in panellist)
            {

                if (move.Bounds.IntersectsWith(wall.Bounds))
                {

                    canmove = false;

                }
            }

            if (canmove)
            {

                player.Left = move.Left;
                player.Top = move.Top;

            }
        }

        private void Enemymovement()
        {
  
            foreach (Control enemies in house.Controls)
            {
                if ((string)enemies.Tag == "enemy")
                {
                    if (enemies.Left > player.Left)
                    {
                        enemies.Left -= enemyspeed;
                    }

                    if (enemies.Left < player.Left)
                    {
                        enemies.Left += enemyspeed;
                    }

                    if (enemies.Top > player.Top)
                    {
                        enemies.Top -= enemyspeed;
                    }

                    if (enemies.Top < player.Top)
                    {
                        enemies.Top += enemyspeed;
                    }
                }
            }
        }

        private void Gameover()
        {
            if (won != true)
            {
                foreach (PictureBox enemy in enemylist)
                {
                    if (player.Bounds.IntersectsWith(enemy.Bounds))
                    {
                        house.Controls.Remove(enemy);
                        enemylist.Clear();

                        this.Hide();
                        gameover menu = new gameover();
                        menu.ShowDialog();
                        this.Close();

                    }
                }
            }

            else
            {
                foreach (PictureBox enemy in enemylist)
                {

                    house.Controls.Remove(enemy);

                }
            }   
        }   
    }   
}
