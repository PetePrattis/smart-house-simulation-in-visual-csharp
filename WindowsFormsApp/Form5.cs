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
    public partial class Bathroom : Form
    {
        public Bathroom()
        {
            InitializeComponent();
            Hide();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            /*Functions:
             * Smart Dehumidifier
             * Smart Water Heater
             * Smart Toilet
             * 
             */
        }

        private void Bathroom_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void backbutton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            MainMenu form1 = new MainMenu();
            form1.Show();
            form1.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
        }

        private void Bathroom_Shown(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            comboBox1.Items.AddRange(new string[] { "All Colors", "Dark Clothes", "White", "Sensible Clothes" });
            comboBox1.SelectedIndex = 0;
        }

        int f1 = 0;//dehumidifier window is closed
        int f2 = 0;//water heater window is closed
        int f3 = 0;//smart toilet window is closed
        int f4 = 0;//smart washing machine is closed

        private void smartdehumidifier_MouseClick(object sender, MouseEventArgs e)
        {
            if (f1 == 0)
            {
                panel2.Hide();
                f2 = 0;
                panel3.Hide();
                f3 = 0;
                panel4.Hide();
                f4 = 0;
                panel1.Show();
                panel1.Location = new Point(200, 375);
                panel1.Size = new Size(182, 182);
                f1 = 1;
            }
            else if (f1 == 1)
            {
                panel1.Hide();
                f1 = 0;
            }
        }

        private void waterheater_MouseClick(object sender, MouseEventArgs e)
        {
            if (f2 == 0)
            {
                panel1.Hide();
                f1 = 0;
                panel3.Hide();
                f3 = 0;
                panel4.Hide();
                f4 = 0;
                panel2.Show();
                panel2.Location = new Point(200, 350);
                panel2.Size = new Size(185, 240);
                f2 = 1;
            }
            else if (f2 == 1)
            {
                panel2.Hide();
                f2 = 0;
            }
        }

        private void smarttoilet_MouseClick(object sender, MouseEventArgs e)
        {
            if (f3 == 0)
            {
                panel1.Hide();
                f1 = 0;
                panel2.Hide();
                f2 = 0;
                panel4.Hide();
                f4 = 0;
                panel3.Show();
                panel3.Location = new Point(170, 375);
                panel3.Size = new Size(266, 200);
                f3 = 1;
            }
            else if (f3 == 1)
            {
                panel3.Hide();
                f3 = 0;
            }
        }
        private void washingmachine_MouseClick(object sender, MouseEventArgs e)
        {
            if (f4 == 0)
            {
                panel1.Hide();
                f1 = 0;
                panel2.Hide();
                f2 = 0;
                panel3.Hide();
                f3 = 0;
                panel4.Show();
                panel4.Location = new Point(105, 365);
                panel4.Size = new Size(420, 180);
                f4 = 1;
                
            }
            else if (f4 == 1)
            {
                panel4.Hide();
                f4 = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)//off button for dehumiidifier
        {
            if (radioButton3.Checked == true | radioButton4.Checked == true | radioButton5.Checked == true)
            {
                button3.Hide();
            }
            else
            {
                MessageBox.Show("Error! Please select dehumidifier mode!");
            }

           
        }

        private void don_Click(object sender, EventArgs e)//on button for dehumiidifier
        {
            button3.Show();
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)//off button for water heater
        {
            button4.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button4.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true | radioButton2.Checked == true )
            {
                MessageBox.Show("Toilet freshener has beeb activated");
            }
            else
            {
                MessageBox.Show("Error! Please select freshener sent!");
            }
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Toilet has been flushed");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Toilet has beeb cleaned");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button8.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Hide();
        }

        private void button9_Click(object sender, EventArgs e)//start washing
        {
            if (button9.Text == "Start")
            {
                if (radioButton6.Checked == false & radioButton7.Checked == false & radioButton8.Checked == false )
                {
                    MessageBox.Show("Select Temperature!");
                }
                else
                    button9.Text = "Stop";

            }
            else
                button9.Text = "Start";
        }

        private void onlinehelpbutton_Click(object sender, EventArgs e)//On-Line Help
        {
           MessageBox.Show ("1. To operate the smart dehumidifier select its icon." + "\ n" + "1.1 Select one of the available dehumidifier operating options." + "\ n" + "1.2 Press the Start Button (On / Off). "," On-Line Help Page 1 ");
            MessageBox.Show ("2. Select its icon to operate its smart water heater." + "\ n" + "2.1 Adjust the temperature by moving the bar." + "\ n" + "2.2 Press the start button "," On-Line Help Page 2 ");
            MessageBox.Show ("3. To operate the smart toilet select its icon." + "\ n" + "3.1 To press the flush press Flush" + "\ n" + "3.2 To automatically clean it toilet press Auto - cleaner button "+" \ n "+" 3.3 To perfume the bathroom choose perfume and then press the Toilet Freshener button "+" \ n "+" 3.4 To heat the toilet lid adjust the temperature and press the start button "," On-Line Help page 3 ");
            MessageBox.Show ("4. To operate the smart washing machine select its icon." + "\ n" + "4.1 To start the washing machine select some" + "\ n" + "from the available washing options below in the Washing Mode tab. "+" \ n "+" 4.2 Select a temperature (60, 40 or 30 degrees Celsius) under the Temperature tab. "+" \ n "+" 4.3 Select a washing time under the Time label. " + "\ n" + "4.4 Start the wash by pressing the Start button." + "\ n" + "4.5 To stop washing before finishing, press the Stop button (which takes the Start button after pressing of Start). "," On-Li ne Help page 4 ");
        }
    }
}
