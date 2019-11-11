using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LivingRoom : Form
    {
        public LivingRoom()
        {
            InitializeComponent();
            Hide();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            /*Functions:
             * Smart Tv
             * Stereo System
             * Heated Furniture (Sofa)
             * 
             */

            comboBox1.Items.Add("track1");
            comboBox1.Items.Add("track2");
            comboBox1.Items.Add("track3");
            comboBox1.Items.Add("track4");

        }
     
        private void Form2_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            MainMenu form1 = new MainMenu();
            form1.Show();
            form1.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
        }

        public int C = 0;// channel for tv
        public int O = 0;//on or off for tv
        private void button1_Click(object sender, EventArgs e)
        {
            C = 1;
            channel.Text = "1";
            O = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            C = 2;
            channel.Text = "2";
            O = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            C = 3;
            channel.Text = "3";
            O = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            C = 4;
            channel.Text = "4";
            O = 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            C = 5;
            channel.Text = "5";
            O = 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            C = 6;
            channel.Text = "6";
            O = 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            C = 7;
            channel.Text = "7";
            O = 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            C = 8;
            channel.Text = "8";
            O = 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            C = 9;
            channel.Text = "9";
            O = 1;
        }

        private void onoff_Click(object sender, EventArgs e)
        {
            if (O == 0)//if turned off
            {
                if(C==0)//if we haven't chosen a channel (1st use)
                {
                    C = 1;
                    O = 1;
                    channel.Text = "1";
                }
                else//else when we turn on tv the channel is the previous selected
                {
                    O = 1;
                    channel.Text = C.ToString();
                }
            }
            else if(O==1)//if turned on
            {
                O = 0;
                channel.Text = "-";
                webBrowser1.Navigate("about:blank");
            }
        }

        private void button11_Click(object sender, EventArgs e)//facebook
        {
            this.webBrowser1.Navigate("http://www.facebook.com");
            O = 1;
        }

        private void button10_Click(object sender, EventArgs e)//netflix
        {
            this.webBrowser1.Navigate("http://www.netflix.com");
            O = 1;
        }

        private void button12_Click(object sender, EventArgs e)//youtube
        {
            this.webBrowser1.Navigate("http://www.youtube.com");
            O = 1;
        }

        private void button13_Click(object sender, EventArgs e)//vimeo
        {
            this.webBrowser1.Navigate("http://www.vimeo.com");
            O = 1;
        }
        int f1 = 0;//tv function window is closed
        int f2 = 0;//stereo function system is closed
        int f3 = 0;//sofa function system is closed
        private void smarttv_MouseClick(object sender, MouseEventArgs e)
        {
            if (f1 == 0)
            {
                panel2.Hide();
                f2 = 0;
                panel3.Hide();
                f3 = 0;
                panel1.Show();
                panel1.Location = new Point(130, 300);
                panel1.Size = new Size(325, 320);
                f1 = 1;
            }
            else if(f1==1)
            {
                panel1.Hide();
                f1 = 0;
            }
        }

        private void LivingRoom_Shown(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
        }

        private void stereo_MouseClick(object sender, MouseEventArgs e)
        {
            if (f2 == 0)
            {
                panel1.Hide();
                f1 = 0;
                panel3.Hide();
                f3 = 0;
                panel2.Show();
                panel2.Location = new Point(95, 400);
                panel2.Size = new Size(380, 150);
                f2 = 1;
            }
            else if (f2 == 1)
            {
                panel2.Hide();
                f2 = 0;
            }
        }

        private void button16_Click(object sender, EventArgs e)//sofa off
        {
            button20.Show();
        }

        private void button20_Click(object sender, EventArgs e)//sofa on
        {
            if (radioButton1.Checked == true | radioButton2.Checked == true | radioButton3.Checked == true)
            {
                button20.Hide();
            }
            else
            {
                MessageBox.Show("Please select Vibration Mode!");
            }
        }

        private void smartsofa_MouseClick(object sender, MouseEventArgs e)
        {
            if (f3 == 0)
            {
                panel1.Hide();
                f1 = 0;
                panel2.Hide();
                f2 = 0;
                panel3.Show();
                panel3.Location = new Point(200, 375);
                panel3.Size = new Size(215, 217);
                f3 = 1;
            }
            else if (f3 == 1)
            {
                panel3.Hide();
                f3 = 0;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e) //stereo play
        {
            button15.Show();
        }

        private void button15_Click(object sender, EventArgs e) // stereo play
        {
            if (comboBox1.Text != "")
            {
                button15.Hide();
            }

            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Please select a song!");
            }
        }

        private void button17_Click(object sender, EventArgs e) // stereo stop
        {
            comboBox1.Text = null;
            button15.Show();
        }

        private void onlinehelpbutton_Click(object sender, EventArgs e)//On-Line Help
        {
           MessageBox.Show ("1.To operate its smart TV, select its icon." + "\ n" + "1.1 To open the TV, press the On / Off button" + "\ n" + "1.2 To select a channel press any of the (1 - 9) channel buttons" + "\ n" + "and the channel displayed at that time will be displayed." + "\ n" + "1.3 use the Facebook, Netflix, Youtube and Vimeo apps, select the appropriate icons. "+" \ n "+" 1.4 To adjust the volume under the Volume "+" \ n "+" button press the arrow pointing upwards for her increase the volume "+" \ n "+" and the down arrow button to decrease the volume. "," On-Line Help page 1 ");
           MessageBox.Show ("2.To control the stereo system select its icon." + "\ n" + "2.1 To select a track, under the Pick Track label" + "\ n" + "press the arrow to display the available tracks and select one of them. "+" \ n "+" 2.2 To play the track, press the Play button, and the Pause button to pause it. "+" \ n "+" 2.3 To adjust the volume under the Volume tab "+" \ n "+" move the bar to the right to increase the volume and to the left to decrease. "+" \ N "+" 2.4 To t finding a track online, "+" \ n "+" under the Find song on youtube label is the Youtube track search platform. "," On-Line Help Page 2 ");
           MessageBox.Show ("3.To control the smart armchair select the icon of" + "\ n" + "3.1 To start the smart armchair" + "\ n" + "select one and then press the button Start. "+" \ n "+" 3.2 To adjust the temperature, move the bar under the Heat sign, "+" \ n "+" to the right to raise the temperature and to the left to decrease. "," On-Line Help Page 3 ");        
		}
    }
}
