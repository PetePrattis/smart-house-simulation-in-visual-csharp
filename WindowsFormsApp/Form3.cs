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
    public partial class Bedroom : Form
    {
        public Bedroom()
        {
            InitializeComponent();
            Hide();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            /*Functions:
             * Heated Bed
             * Radio
             * Smart Wardrobe
             * 
             */
        }

        private void backbutton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            MainMenu form1 = new MainMenu();
            form1.Show();
            form1.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
        }

        private void Bedroom_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }


        int f1 = 0;//heated bed window is closed
        int f2 = 0;//radio window is closed
        int f3 = 0;//smart wardrobe window is closed
        private void heatedbed_MouseClick(object sender, MouseEventArgs e)
        {
            if (f1 == 0)
            {
                panel2.Hide();
                f2 = 0;
                panel3.Hide();
                f3 = 0;
                panel1.Show();
                panel1.Location = new Point(110, 300);
                panel1.Size = new Size(382, 249);
                f1 = 1;
            }
            else if (f1 == 1)
            {
                panel1.Hide();
                f1 = 0;
            }

        }

        private void Bedroom_Shown(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
        }

        private void radio_MouseClick(object sender, MouseEventArgs e)
        {
            if (f2 == 0)
            {
                panel1.Hide();
                f1 = 0;
                panel3.Hide();
                f3 = 0;
                panel2.Show();
                panel2.Location = new Point(151, 303);
                panel2.Size = new Size(278, 215);
                f2 = 1;
            }
            else if (f2 == 1)
            {
                panel2.Hide();
                f2 = 0;
            }
        }

        private void smartwardrobe_MouseClick(object sender, MouseEventArgs e)
        {
            if (f3 == 0)
            {
                panel1.Hide();
                f1 = 0;
                panel2.Hide();
                f2 = 0;
                panel3.Show();
                panel3.Location = new Point(40, 258);
                panel3.Size = new Size(496, 361);
                f3 = 1;
                /*label21.Hide();
                label22.Hide();
                label23.Hide();
                label24.Hide();
                comboBox2.Hide();
                comboBox3.Hide();
                comboBox4.Hide();
                comboBox5.Hide();*/
            }
            else if (f3 == 1)
            {
                panel3.Hide();
                f3 = 0;
            }
            panel4.Hide();

        }

       

        private void button3_Click(object sender, EventArgs e)//left side of bed
        {
            if (radioButton1.Checked == true)
            {
                if (button3.Text == "Start")
                {
                    button3.Text = "Stop";
                }
                else if (button3.Text == "Stop")
                {
                    button3.Text = "Start";
                }
                if (button5.Text == "Stop")
                {
                    button5.Text = "Start";
                }
            }
            else
            {
                MessageBox.Show("Please select bed side!");
            }
        }

        private void button4_Click(object sender, EventArgs e)//right side of bed
        {
            if (radioButton2.Checked == true )
            {
                if (button4.Text == "Start")
                {
                    button4.Text = "Stop";
                }
                else if (button4.Text == "Stop")
                {
                    button4.Text = "Start";
                }
                if(button5.Text =="Stop")
                {
                    button5.Text = "Start";
                }
            }
            else
            {
                MessageBox.Show("Please select bed side!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ( radioButton3.Checked == true)
            {
                if (button5.Text == "Start")
                {
                    button5.Text = "Stop";
                    button3.Text = "Start";
                    button4.Text = "Start";
                }
                else if (button5.Text == "Stop")
                {
                    button5.Text = "Start";
                }
            }
            else
            {
                MessageBox.Show("Please select bed side!");
            }
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)// radio pause 
        {
            button13.Show();
        }

        private void button13_Click(object sender, EventArgs e)//radio play
        {
            if (comboBox1.Text != "")
            {
                button13.Hide();
            }

            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Please select a station!");
            }
          
        }

        private void button14_Click(object sender, EventArgs e)//radio stop
        {
            comboBox1.Text = null ;
            button13.Show();
            
        }


        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "View Inside")
            {
                panel4.Show();
                panel4.Location = new Point(30, 75);
                panel4.Size = new Size(450, 285);
                button8.Text = "Hide";
                panel4.BringToFront();

            }
            else if (button8.Text == "Hide")
            {
                panel4.Hide();
                button8.Text = "View Inside";
            }
            
        }


        //variables that show outfit options
        int o1 = 0;//sporty
        int o2 = 0;//casual
        int o3 = 0;//formal

        private void button9_Click(object sender, EventArgs e) //sporty
        {
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
            if (button8.Text == "Hide")
            {
                panel4.Hide();
                button8.Text = "View Inside";
            }
            if (o1 == 0)
            {
                

                o2 = 0;
                o3 = 0;
                o1 = 1;

                comboBox2.Items.AddRange(new string[] {"Nike White Shoes","Adidas Black Shoes", "Nike Blue Shoes" });
                comboBox2.SelectedIndex=0;
                comboBox3.Items.AddRange(new string[] { "Champion Overall", "Nike Shorts", "Nike Legging" });
                comboBox3.SelectedIndex = 0;
                comboBox4.Items.AddRange(new string[] { "Puma Black Shirt", "Nike White Shirt", "Nike Long-Sleeve Grey Shirt" });
                comboBox4.SelectedIndex = 0;
                comboBox5.Items.AddRange(new string[] { "Puma Black Jacket", "Nike White Sweater"});
                comboBox5.SelectedIndex = 0;
            }
            else if (o1 == 1)
            {

                o1 = 0;
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                comboBox4.Items.Clear();
                comboBox5.Items.Clear();
                if (button8.Text == "Hide")
                {
                    panel4.Hide();
                    button8.Text = "View Inside";
                }
            }
        }

        private void button10_Click(object sender, EventArgs e) // casual
        {
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
            if (button8.Text == "Hide")
            {
                panel4.Hide();
                button8.Text = "View Inside";
            }
            if (o2 == 0)
            {
                 o1 = 0;
                o3 = 0;
                o2 = 1;


                comboBox2.Items.AddRange(new string[] { "All-Star White Shoes", "Vans Black Shoes", "Nike Blue Shoes" });
                comboBox2.SelectedIndex = 0;
                comboBox3.Items.AddRange(new string[] { "Blue Jeans", "Black Jeans", "Red Skirt" });
                comboBox3.SelectedIndex = 0;
                comboBox4.Items.AddRange(new string[] { "Navy-Green Grey Blouse", "Nike White Shirt", "Pull&Bear Black Shirt" });
                comboBox4.SelectedIndex = 0;
                comboBox5.Items.AddRange(new string[] { "Puma Black Jacket", "Filla Grey Jacket" });
                comboBox5.SelectedIndex = 0;
            }
            else if (o2 == 1)
            {

                o2 = 0;
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                comboBox4.Items.Clear();
                comboBox5.Items.Clear();
                if (button8.Text == "Hide")
                {
                    panel4.Hide();
                    button8.Text = "View Inside";
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)// formal
        {
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
            if (button8.Text == "Hide")
            {
                panel4.Hide();
                button8.Text = "View Inside";
            }
            if (o3 == 0)
            {
                o1 = 0;
                o2 = 0;
                o3 = 1;

                comboBox2.Items.AddRange(new string[] { "Alestino Black Leather Shoes", "Kraasa Black Formal Shoes", "Red Heels" });
                comboBox2.SelectedIndex = 0;
                comboBox3.Items.AddRange(new string[] { "Calvin Klein Jeans", "Louis Vuitton Black Dress", "Red Skirt" });
                comboBox3.SelectedIndex = 0;
                comboBox4.Items.AddRange(new string[] { "Navy-Green Grey Blouse", "Lacoste Green Blouse", "Pull&Bear Black Shirt" });
                comboBox4.SelectedIndex = 0;
                comboBox5.Items.AddRange(new string[] { "Armani Black Coat", "Navy Grey Coat" });
                comboBox5.SelectedIndex = 0;

            }
            else if (o3 == 1)
            {

                o3 = 0;
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                comboBox4.Items.Clear();
                comboBox5.Items.Clear();
                if (button8.Text == "Hide")
                {
                    panel4.Hide();
                    button8.Text = "View Inside";
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (o1 == 0 & o2 == 0 & o3 == 0)
            {
                MessageBox.Show("Please select Clothes!");
            }
            else {
                string text1 = comboBox2.SelectedItem.ToString();
                string text2 = comboBox3.SelectedItem.ToString();
                string text3 = comboBox4.SelectedItem.ToString();
                string text4 = comboBox5.SelectedItem.ToString();


                MessageBox.Show("Selected Clothes: "+ text1 +" , "+ text2 + " , " + text3 + " , " + text4);
            }
        }

        private void onlinehelpbutton_Click(object sender, EventArgs e)//On-Line Help
        {
            MessageBox.Show ("1.To control the heated bed select its icon." + "\ n" + "1.1 Select the bed side" + "\ n" + "1.2 Adjust the temperature with the bar next to it from the side you choose "+" \ n "+" 1.3 Press the Start button located in the same line as the selected bed side. "," On-Line Help page 1 ");
            MessageBox.Show ("2.To operate the radio, select its icon." + "\ n" + "2.1 To select a radio station, under the Pick Station" + "\ n" + "button press the show the available radio stations and select one of them. "+" \ n "+" 2.2 To adjust the volume under the Volume tab "+" \ n "+" move the bar to the right to increase of volume and left to decrease. "," On-Line Help page 2 ");
            MessageBox.Show ("3.To operate the smart cupboard select its icon." + "\ n" + "3.1 To view the inside of the cupboard press the View Image button." + "\ n" + "3.2 select the set, select the occasion (Sporty, Casual, Formal) "+" \ n "+" and then select one of the available shoes, blouses etc "+" \ n "+" and complete the process by tapping of the Pick Clothes button. "," On-Line Help page 3 ");
        }
    }
}
