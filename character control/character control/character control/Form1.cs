﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace character_control
{
    public partial class Form1 : Form
    {

        Random Randomnumber = new Random();

        List<PictureBox> enemylist = new List<PictureBox>();
        List<PictureBox> keylist = new List<PictureBox>();
        List<Panel> panellist = new List<Panel>();

        bool Moveup, Movedown, Moveleft, Moveright;

        int playerspeed = 10;
        int enemyspeed = 1;

        int enemycount = 2;
        int keycount = 3;
        int pickedupkeys = 0;
        public Form1()
        {
            InitializeComponent();
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

            foreach (Panel wall in panellist)
            {
                if (player.Bounds.IntersectsWith(wall.Bounds))
                {
                    int playerX = player.Location.X;
                    int playerY = player.Location.Y;
                    int playerSW = player.Size.Width;
                    int playerSH = player.Size.Height;

                    int wallX = wall.Location.X;
                    int wallY = wall.Location.Y;
                    int wallSW = wall.Size.Width;
                    int wallSH = wall.Size.Height;

                    if (playerX > wallX - playerSW)
                    {
                        player.Left -= playerspeed;
                    }
                    if (playerX < wallX - playerSW)
                    {
                        player.Left += playerspeed;
                    }
                    if (playerY > wallY - playerSH)
                    {
                        player.Top -= playerspeed;
                    }
                    if (playerY < wallY - playerSH)
                    {
                        player.Top += playerspeed;
                    }
                }
            }
        }
        private void movetimerevent(object sender, EventArgs e)
        {

            Playermovement();
            Walls();
            Enemymovement();
            Gameover();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Makeenemies();
            MakeKeys(); 
        }

        private void keydownpress(object sender, KeyEventArgs e)
        {

                if (e.KeyCode == Keys.Left )
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
                        house.Controls.Remove(key);
                        pickedupkeys++;
                        keytext.Text = pickedupkeys.ToString();
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

        private void Playermovement()
        {

            if (Moveleft == true && player.Left > 0)
            {
                player.Left -= playerspeed;
            }
            if (Moveright == true && player.Left < 1305)
            {
                player.Left += playerspeed;
            }
            if (Moveup == true && player.Top > 0)
            {
                player.Top -= playerspeed;
            }
            if (Movedown == true && player.Top < 683)
            {
                player.Top += playerspeed;
            }
        }

        private void Makeenemies()
        {
            while (enemylist.Count != enemycount)
            {

                PictureBox enemy = new PictureBox();
                enemy.Width = 20;
                enemy.Height = 20;
                enemy.BackColor = Color.Red;
                enemy.Tag = "enemy";


                foreach (Panel wall in panellist)
                {
                    int wallX = wall.Location.X;
                    int wallY = wall.Location.Y;
                    int wallSW = wall.Size.Width;
                    int wallSH = wall.Size.Height;                          

                    int enemyx = Randomnumber.Next((this.house.Width - enemy.Width));
                    int enemyy = Randomnumber.Next(this.house.Height - enemy.Height);

                    enemy.Location = new Point(enemyx, enemyy);

                    enemylist.Add(enemy); 
                    house.Controls.Add(enemy); 
                }
            }

        }

        private void MakeKeys()
        {
            while (keylist.Count != keycount)
            {

                PictureBox key = new PictureBox();
                key.Width = 20;
                key.Height = 20;
                key.BackColor = Color.Green;
                key.Tag = "keys";

                int keyx = Randomnumber.Next(this.house.Width - key.Width);
                int keyy = Randomnumber.Next(this.house.Height - key.Height);

                key.Location = new Point(keyx, keyy);

                keylist.Add(key);
                house.Controls.Add(key);
               
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
            foreach (PictureBox enemy in enemylist)
            {
                if (player.Bounds.IntersectsWith(enemy.Bounds))
                {
                    house.Controls.Remove(enemy);
                }
            }
        }
    }
}
