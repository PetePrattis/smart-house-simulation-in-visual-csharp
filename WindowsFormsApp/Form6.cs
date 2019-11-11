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
    public partial class Extra : Form
    {
        public Extra()
        {
            InitializeComponent();
            Hide();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void Extra_FormClosed(object sender, FormClosedEventArgs e)
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

        private void Extra_Shown(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton3.Checked = true;

            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
           
        }

        int f1 = 0;//camera window is closed
        int f2 = 0;//temperature window is closed
        int f3 = 0;//lights window is closed
        int f4 = 0;//lockdown and alarm window is closed
        int f5 = 0;//show rooms camera is closed
        int f6 = 0;//show outside cameras is closed

        private void camera_MouseClick(object sender, MouseEventArgs e)//camera button
        {
            if (f1 == 0)
            {
                panel2.Hide();
                f2 = 0;
                panel3.Hide();
                f3 = 0;
                panel4.Hide();
                f4 = 0;
                panel5.Hide();
                f5 = 0;
                panel6.Hide();
                f6 = 0;
                panel1.Show();
                panel1.Location = new Point(99, 333);
                panel1.Size = new Size(400, 285);
                f1 = 1;
            }
            else if (f1 == 1)
            {
                panel1.Hide();
                f1 = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)//show inside
        {
            panel1.Hide();
            f1 = 0;
            panel5.Show();
            panel5.Location = new Point(99, 333);
            panel5.Size = new Size(400, 285);
            f5 = 1;
        }

        private void button3_Click(object sender, EventArgs e)//show outside
        {
            panel1.Hide();
            f1 = 0;
            panel6.Show();
            panel6.Location = new Point(99, 333);
            panel6.Size = new Size(400, 285);
            f6 = 1;
        }

        private void button1_Click(object sender, EventArgs e)//close inside
        {
            panel5.Hide();
            f5 = 0;
            panel1.Show();
            panel1.Location = new Point(99, 333);
            panel1.Size = new Size(400, 285);
            f1 = 1;
        }

        private void button4_Click(object sender, EventArgs e)//close outside
        {
            panel6.Hide();
            f6 = 0;
            panel1.Show();
            panel1.Location = new Point(99, 333);
            panel1.Size = new Size(400, 285);
            f1 = 1;
        }

        private void lighting_Click(object sender, EventArgs e)//house lighting
        {
            if (f3 == 0)
            {
                panel2.Hide();
                f2 = 0;
                panel1.Hide();
                f1 = 0;
                panel4.Hide();
                f4 = 0;
                panel5.Hide();
                f5 = 0;
                panel6.Hide();
                f6 = 0;
                panel3.Show();
                panel3.Location = new Point(99, 369);
                panel3.Size = new Size(400, 230);
                f3 = 1;
            }
            else if (f3 == 1)
            {
                panel3.Hide();
                f3 = 0;
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)//livingroom light
        {
            hScrollBar1.Value = Math.Abs((400 - vScrollBar1.Value - vScrollBar2.Value - vScrollBar3.Value - vScrollBar4.Value) / 4);
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)//bedroom light
        {
            hScrollBar1.Value = Math.Abs((400 - vScrollBar1.Value - vScrollBar2.Value - vScrollBar3.Value - vScrollBar4.Value) / 4);
        }

        private void vScrollBar3_Scroll(object sender, ScrollEventArgs e)//kitchen light
        {
            hScrollBar1.Value = Math.Abs((400 - vScrollBar1.Value - vScrollBar2.Value - vScrollBar3.Value - vScrollBar4.Value) / 4);
        }

        private void vScrollBar4_Scroll(object sender, ScrollEventArgs e)//bathroom light
        {
            hScrollBar1.Value = Math.Abs((400 - vScrollBar1.Value - vScrollBar2.Value - vScrollBar3.Value - vScrollBar4.Value) / 4);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)//all rooms lights
    {
            vScrollBar1.Value = Math.Abs(100 - hScrollBar1.Value);
            vScrollBar2.Value = Math.Abs(100 - hScrollBar1.Value);
            vScrollBar3.Value = Math.Abs(100 - hScrollBar1.Value);
            vScrollBar4.Value = Math.Abs(100 - hScrollBar1.Value);
        }

        private void temperature_Click(object sender, EventArgs e)//house temperature
        {
            if (f2 == 0)
            {
                panel1.Hide();
                f1 = 0;
                panel3.Hide();
                f3 = 0;
                panel4.Hide();
                f4 = 0;
                panel5.Hide();
                f5 = 0;
                panel6.Hide();
                f6 = 0;
                panel2.Show();
                panel2.Location = new Point(99, 369);
                panel2.Size = new Size(400, 230);
                f2= 1;
            }
            else if (f2 == 1)
            {
                panel2.Hide();
                f2 = 0;
            }
        }

        private void vScrollBar5_Scroll(object sender, ScrollEventArgs e)//bathroom temp
        {
            hScrollBar2.Value = Math.Abs((400 - vScrollBar5.Value - vScrollBar6.Value - vScrollBar7.Value - vScrollBar8.Value) / 4);
        }

        private void vScrollBar6_Scroll(object sender, ScrollEventArgs e)//kitchen temp
        {
            hScrollBar2.Value = Math.Abs((400 - vScrollBar5.Value - vScrollBar6.Value - vScrollBar7.Value - vScrollBar8.Value) / 4);
        }

        private void vScrollBar7_Scroll(object sender, ScrollEventArgs e)//bedroom temp
        {
            hScrollBar2.Value = Math.Abs((400 - vScrollBar5.Value - vScrollBar6.Value - vScrollBar7.Value - vScrollBar8.Value) / 4);
        }

        private void vScrollBar8_Scroll(object sender, ScrollEventArgs e)//livingroom temp
        {
            hScrollBar2.Value = Math.Abs((400 - vScrollBar5.Value - vScrollBar6.Value - vScrollBar7.Value - vScrollBar8.Value) / 4);
        }


        private void hScrollBar2_Scroll_1(object sender, ScrollEventArgs e)//all rooms temp
        {
            vScrollBar5.Value = Math.Abs(100 - hScrollBar2.Value);
            vScrollBar6.Value = Math.Abs(100 - hScrollBar2.Value);
            vScrollBar7.Value = Math.Abs(100 - hScrollBar2.Value);
            vScrollBar8.Value = Math.Abs(100 - hScrollBar2.Value);
        }

        private void lockalarm_Click(object sender, EventArgs e)//lock and alarm
        {
            if (f4 == 0)
            {
                panel1.Hide();
                f1 = 0;
                panel3.Hide();
                f3 = 0;
                panel2.Hide();
                f2 = 0;
                panel5.Hide();
                f5 = 0;
                panel6.Hide();
                f6 = 0;
                panel4.Show();
                panel4.Location = new Point(167, 355);
                panel4.Size = new Size(270, 265);
                f4 = 1;
            }
            else if (f4 == 1)
            {
                panel4.Hide();
                f4 = 0;
            }
        }

        private void button9_Click(object sender, EventArgs e)//1
        {
            if(button8.Text =="UnLOCK")
            {
                textBox1.Text += "1";
            }
        }

        private void button11_Click(object sender, EventArgs e)//2
        {
            if (button8.Text == "UnLOCK")
            {
                textBox1.Text += "2";
            }
        }

        private void button13_Click(object sender, EventArgs e)//3
        {
            if (button8.Text == "UnLOCK")
            {
                textBox1.Text += "3";
            }
        }

        private void button15_Click(object sender, EventArgs e)//4
        {
            if (button8.Text == "UnLOCK")
            {
                textBox1.Text += "4";
            }
        }

        private void button17_Click(object sender, EventArgs e)//5
        {
            if (button8.Text == "UnLOCK")
            {
                textBox1.Text += "5";
            }
        }

        private void button16_Click(object sender, EventArgs e)//6
        {
            if (button8.Text == "UnLOCK")
            {
                textBox1.Text += "6";
            }
        }

        private void button14_Click(object sender, EventArgs e)//7
        {
            if (button8.Text == "UnLOCK")
            {
                textBox1.Text += "7";
            }
        }

        private void button12_Click(object sender, EventArgs e)//8
        {
            if (button8.Text == "UnLOCK")
            {
                textBox1.Text += "8";
            }
        }

        private void button10_Click(object sender, EventArgs e)//9
        {
            if (button8.Text == "UnLOCK")
            {
                textBox1.Text += "9";
            }
        }

        private void button18_Click(object sender, EventArgs e)//0
        {
            if (button8.Text == "UnLOCK")
            {
                textBox1.Text += "0";
            }
        }

        private void button5_Click(object sender, EventArgs e)//locks
        {
            if (button5.Text == "unlocked")
                button5.Text = "locked";
            else if (button5.Text == "locked")
                button5.Text = "unlocked";
        }

        private void button6_Click(object sender, EventArgs e)//alarm
        {
            if(button6.Text == "alarm off")
                button6.Text = "alarm on";
            else if (button6.Text == "alarm on")
                button6.Text = "alarm off";
        }

        private void button7_Click(object sender, EventArgs e)//windows
        {
            if (button7.Text == "windows open")
                button7.Text = "windows closed";
            else if (button7.Text == "windows closed")
                button7.Text = "windows open";
        }

        private void button8_Click(object sender, EventArgs e)//lockdown
        {
            if(button8.Text =="LOCKDOWn")
            {
                if(button5.Text =="unlocked" & button6.Text =="alarm off" & button7.Text =="windows open")
                {
                    MessageBox.Show("You need to lock house or put alarm or close windows before Lockdown of house");
                }
                else
                {
                    MessageBox.Show("House Lockdown is successful");
                    button8.Text = "UnLOCK";
                }
                textBox1.Clear();
            }
            else if (button8.Text == "UnLOCK")
            {
                if(textBox1.Text == "1234")
                {
                    MessageBox.Show("House unlock is successful");
                    button8.Text = "LOCKDOWn";
                    textBox1.Clear();
                    button5.Text = "unlocked";
                    button7.Text = "windows open";
                    button6.Text = "alarm off";
                }
                else
                {
                    MessageBox.Show("Password is 1234", "Wrong Password");
                    textBox1.Clear();
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)//clear password
        {
            textBox1.Clear();
        }

        private void onlinehelpbutton_Click(object sender, EventArgs e)//On-Line Help
        {
            MessageBox.Show ("1. To view the interior of the house press the Show Inside button" + "\ n" + "2. To display the exterior of the house press the Show Outside button" + "\ n" + "3.To activate alerts in the event of a" + "\ n" + "home alert, use the buttons under the notify me for movement.", "On-Line Help page 1");
            MessageBox.Show ("1. To change the heating of individual rooms in the house, move the bars under the name of each room." + "\ n" + "2.To change the heating of all rooms in the bar under the General Temperature tab "," On-Line Help Page 2 ");
            MessageBox.Show ("1. To change the brightness of individual rooms in the house, move the bars under the name of each room." + "\ n" + "2.To change the lighting of all rooms, move the bar under the General Lighting "+" \ n "+" sign 3. To turn the lights on or off outside the home, press the buttons under the "Outside lighting" sign, "On-Line Help page 3") ;
            MessageBox.Show ("1. To unlock the house, select an option from unlocked, alarm off, windows open, and then press the LOCKDOWn" + "\ n" + "button. 2.Press unlocked, alarm off , "+" \ n "+" windows open choose how to lock the house, which is lock, alarm and window closing respectively "+" \ n "+" 3. To do the lock you must select at least one way locking house (LOCKDOWn) "+" \ n "+" 4. To unlock the house you need to press the code (1234) with the number buttons and press the UnLOCK button "+ "\ n" + "5. In case of a password error, press the clear password button to delete the password", "On-Line Help page 4");
        }
    }
}
