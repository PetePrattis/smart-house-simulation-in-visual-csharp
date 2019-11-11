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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void livingroombutton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            LivingRoom form2 = new LivingRoom();
            form2.Show();
            form2.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void bedroombutton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Bedroom form3 = new Bedroom();
            form3.Show();
            form3.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
        }

        private void kitchenbutton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Kitchen form4 = new Kitchen();
            form4.Show();
            form4.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
        }

        private void bathroombutton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Bathroom form5 = new Bathroom();
            form5.Show();
            form5.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
        }

        private void extrafunctionsbutton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Extra form6 = new Extra();
            form6.Show();
            form6.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
        }

        private void usermanualbutton_Click(object sender, EventArgs e)//Getting Started Guide
        {
            MessageBox.Show("Welcome to your new smart home application. " + "\n" + "This application enables you to handle a wide range of " + "\n" + "smart devices within your home.", "Getting Started Guide Page 1");
            MessageBox.Show("The main menu contains all the applications you will need " + "\n" + "o take advantage of all the features your smart home gives you. " + "\n" + "Every time you select a room (eg 'Living Room') the corresponding menu is displayed.  " + "\n" + "If you want to go to a previous menu press the back arrow " + "\n" + "which is always visible in the upper left part of the screen. " + "\n" + "From the main menu you can access the individual functions of the home," + "\n" + " in the living room, bedroom, kitchen and bathroom " + "\n" + "clicking on the corresponding buttons.", "Getting Started Guide page 2");
            MessageBox.Show("Pressing the home +" + "\ n" + "button will take you to a new form with additional features." + "\ n" + "Extra features include changing the light" + "\ n" + "in each room and outside of the house," + "\ n" + "changing the temperature in each room," + "\ n" + "controlling security cameras and turning them on "+" \ n "+" traffic alert and finally home lock. "+" \ n "+" Home locking involves closing windows and activating conceit alarm "+" \ n "+" and the total lock of the house. "" Getting Started Guide page 3 ");
			MessageBox.Show("Pressing the lounge button will take you to a new form with extra features." + "\ n" + "Extra features are for managing the" + "\ n" + "smart devices on this room. "+" \ n "+" These devices are smart TV, stereo system and smart armchair. "," Getting Started Guide page 4 ");
            MessageBox.Show("Pressing the bedroom button will move" + "\ n" + "to a new form with extra features." + "\ n" + "Extra features are for managing smart devices located in this room. "+" \ n "+" These are the heated bed, radio and smart wardrobe. "," Getting Started Page 5 ");
            MessageBox.Show("Pressing the kitchen key will take you to" + "\ n" + "to a new form with extra features." + "\ n" + "Extra features include managing smart devices located on this room. "+" \ n "+" These appliances are smart refrigerator, dishwasher, "+" \ n "+" smart oven and smart coffee maker. "," Getting Started Guide page 6 ") ;
            MessageBox.Show("Pressing the bedroom button will take you to" + "\ n" + "in a new form with extra features." + "\ n" + "Extra features include managing smart devices located on this room. "+" \ n "+" These appliances are the smart dehumidifier, the smart water heater, the "+" \ n "+" smart toilet and the washing machine. "," Getting Started Guide page 7 ") ;
        }

        private void technicalmanualbutton_Click(object sender, EventArgs e)//Short Manual
        {
            MessageBox.Show ("When connecting to the smart home application, you will be taken to the home screen where you can take some action." + "\ n" + "These actions are:" + "\ n" + " • Selecting a room to view the most possible actions in each room "+" \ n "+" • Selecting the individual functions for manipulating security cameras, "+" \ n "+" temperature, lighting and home lock "+" \ n "+" • Viewing online help information about the capabilities of each form "+" \ n "+" • Viewing the this manual (User Manual) for a detailed presentation of the application features "," Short Manual page 1 ");
            MessageBox.Show ("Entering the lounge form presents the following controls:" + "\ n" + "• Smart TV," + "\ n" + "• Stereo System and" + "\ n" + "• The Smart Armchair", "Short Manual Page 2");
            MessageBox.Show ("Entering the bedroom form presents the following controls:" + "\ n" + "• Heated bed," + "\ n" + "• Radio and" + "\ n" + "• The Smart Wardrobe", "Short Manual Page 3");
            MessageBox.Show ("Entering the kitchen form presents the following controls:" + "\ n" + "• Smart refrigerator," + "\ n" + "• Smart dishwasher," + "\ n "+" • The smart oven and "+" \ n "+" • The smart coffee maker "," Short Manual page 4 ");
            MessageBox.Show ("Entering the bathroom form presents the following controls:" + "\ n" + "• smart dehumidifier," + "\ n" + "• Smart water heater," + "\ n" + "• The smart toilet and" + "\ n" + "• The smart washing machine", "Short Manual page 5");        }

        private void onlinehelpbutton_Click(object sender, EventArgs e)//on-line help
        {
MessageBox.Show ("When you enter the application you will find the home page with all the rooms of the house." + "\ n" + "1.To view the features provided by the form click on the 'help' button" + "\ n" + "located at the top right of the screen. The help button is in every form of the application." + "\ n" + "2. Press the Extra Functions button to manage the extra features of the home. "+" \ n "+" 3.To operate the smart appliances in the living room, select the "+" \ n "+" icon for the salon, as well as for the other d eyes of the house. "+" \ n "+" 4. For returning to the previous form press 'Back'. "," On-Line Help ");        }
    }
}
