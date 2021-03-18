using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace joc_masinute
{
    public partial class Form1 : Form
    {
        int speed = 3;
        Label[] drum = new Label[9];
        int ver=73, orz=-19;
        int q1, q2, q3;
        int ok = 0;
        int scor = 0;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= 7; i++)
            { drum[i].Top += 2;
                if (drum[i].Top >= this.Height)
                    drum[i].Top =-drum[i].Height;

                    }
            scor = scor + speed;
            label4.Text = Convert.ToString(scor);
            if (masina.Bounds.IntersectsWith(inamic1.Bounds)|| masina.Bounds.IntersectsWith(inamic2.Bounds)||masina.Bounds.IntersectsWith(inamic3.Bounds))
                { masina1.Stop();
                masina2.Stop();
                masina3.Stop();
                timer1.Stop();
                dreapta.Stop();
                stanga.Stop();
                label5.Visible = true;
                label6.Text = Convert.ToString(scor) + " puncte";
                label6.Visible = true;

                }
            
            }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(masina.Location.X>0)
                 masina.Left -= (speed + 1) / 2;
        }

        private void dreapta_Tick(object sender, EventArgs e)
        {
            if (masina.Location.X <230)
                masina.Left += (speed+1)/2;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
             dreapta.Start(); 
            else if (e.KeyCode == Keys.Left)
                stanga.Start();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            dreapta.Stop();
            stanga.Stop();
        }

        private void masina1_Tick(object sender, EventArgs e)
        {
          inamic1.Top += speed;
          
            
            // masina2.Start();
            if (inamic1.Top >= this.Height)
            {
                inamic1.Top = -inamic1.Height;
                int q = random.Next(20, 260);
                inamic1.Left = q; 
            }
            

        }

        private void masina2_Tick(object sender, EventArgs e)
        {
            inamic2.Visible = true;
            inamic2.Top += speed;
            if (inamic2.Top >= this.Height)
            {
                inamic2.Top = -inamic2.Height;
                int q = random.Next(20, 260);
                inamic2.Left = q;
            }
            
        }

        private void masina3_Tick(object sender, EventArgs e)
        {
            inamic3.Visible = true;
            inamic3.Top += speed;
            if (inamic3.Top >= this.Height)
            {
                inamic3.Top = -inamic3.Height;
                int q = random.Next(20, 260);
                inamic3.Left = q;
                ok++;

            }
            if (ok == 2)
            { viteza(speed, e); scor = scor + speed; ok =0; }
            
        }
        private void viteza(object sender, EventArgs e)
        {
            speed++;
            
            label1.Text = Convert.ToString(speed);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            inamic2.Top = -150;
            inamic3.Top = -300;
            label1.Text = Convert.ToString(3);
            for (int i = 0; i <=7; i++)
            {
                drum[i] = new Label();
                drum[i].BackColor = Color.White;
                
                drum[i].Size = new Size(11, 116);
                if (i == 0) drum[i].Location = new Point(ver, orz);
                else
                {
                    if (i <= 3)
                        orz = orz + 140;
                    else
                    {
                        if (i == 4) { orz = -19; ver = 189; }

                        else
                            orz = orz + 140;
                    }
                }
                drum[i].Location = new Point(ver, orz);
                label4.Text = Convert.ToString(scor);
                this.Controls.Add(drum[i]);
            }
        }
    }
}
