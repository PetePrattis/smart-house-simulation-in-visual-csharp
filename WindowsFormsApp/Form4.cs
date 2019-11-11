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
    public partial class Kitchen : Form
    {
        public Kitchen()
        {
            InitializeComponent();
            Hide();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            /*Functions:
             * Smart Fridge
             * Smart Dishwasher
             * Smart Kitchen Oven
             * Coffee Machine
             */
        }

        private void backbutton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            MainMenu form1 = new MainMenu();
            form1.Show();
            form1.SetBounds(this.Location.X, this.Location.Y, this.Width, this.Height);
        }

        private void Kitchen_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Kitchen_Shown(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel7.Hide();

            comboBox1.Items.AddRange(new string[] { "Black Coffee", "Freddo", "Capuchino", "French", "Greek" });
            comboBox1.SelectedIndex = 0;
            comboBox2.Items.AddRange(new string[] { "Extreme Mode", "normal Mode", "Internal Cleaning" });
            comboBox2.SelectedIndex = 0;
            comboBox4.Items.AddRange(new string[] { "Grill", "Air", "Grill Up", "Grill Down", "Air Up", "Air Down" });
            comboBox4.SelectedIndex = 0;
            comboBox3.Items.AddRange(new string[] { "Low Humidity", "High Humidity", "Dry", "normal Humidity" });
            comboBox3.SelectedIndex = 0;

            panel5.Parent = panel1;
            panel6.Parent = panel1;
            panel8.Parent = panel1;
            panel9.Parent = panel1;

            //children of panel5
            button15.Parent = panel5;
            label13.Parent = panel5;
            label14.Parent = panel5;
            label15.Parent = panel5;
            label16.Parent = panel5;
            numericUpDown6.Parent = panel5;
            numericUpDown7.Parent = panel5;
            comboBox3.Parent = panel5;

            //children of panel6
            button16.Parent = panel6;
            button17.Parent = panel6;
            richTextBox1.Parent = panel6;

            //children of panel8
            label17.Parent = panel8;
            label18.Parent = panel8;
            radioButton6.Parent = panel8;
            radioButton7.Parent = panel8;
            radioButton8.Parent = panel8;
            radioButton9.Parent = panel8;
            radioButton10.Parent = panel8;
            radioButton11.Parent = panel8;
            numericUpDown8.Parent = panel8;
            button19.Parent = panel8;
            button20.Parent = panel8;
            comboBox5.Parent = panel8;
            richTextBox2.Parent = panel8;

            //children of panel9
            richTextBox3.Parent = panel9;
            richTextBox4.Parent = panel9;
            maskedTextBox1.Parent = panel9;
            button21.Parent = panel9;
            button22.Parent = panel9;
            button23.Parent = panel9;
            button24.Parent = panel9;


        }

        int f1 = 0;//fridge window is closed
        int f2 = 0;//dishwasher window is closed
        int f3 = 0;//kitchen window is closed
        int f4 = 0;//coffee machine is closed
        int f7 = 0;//show fridge internal is closed

        private void coffeemachine_Click(object sender, EventArgs e)
        {
            if (f4 == 0)
            {
                panel2.Hide();
                f2 = 0;
                panel3.Hide();
                f3 = 0;
                panel1.Hide();
                f1 = 0;
                panel7.Hide();
                f7 = 0;
                panel4.Show();
                panel4.Location = new Point(200, 370);
                panel4.Size = new Size(210, 220);
                f4 = 1;
            }
            else if (f4 == 1)
            {
                panel4.Hide();
                f4 = 0;
            }
        }
        private void button5_Click(object sender, EventArgs e)//clear filters
        {
            MessageBox.Show("Filters Cleaned");
        }

        private void button6_Click(object sender, EventArgs e)//add water
        {
            MessageBox.Show("Water Added");
        }

        private void button4_Click(object sender, EventArgs e)//make coffee
        {
            string text1;
            if (radioButton1.Checked == true)
            {
                text1 = radioButton1.Text;
            }
            else
                text1 = radioButton2.Text;

            string text2 = comboBox1.Text;

            MessageBox.Show("Coffee is " + text1 + " and it is " + text2);
        }

        private void kitchenoven_Click(object sender, EventArgs e)
        {
            if (f3 == 0)
            {
                panel2.Hide();
                f2 = 0;
                panel4.Hide();
                f4 = 0;
                panel1.Hide();
                f1 = 0;
                panel7.Hide();
                f7 = 0;
                panel3.Show();
                panel3.Location = new Point(130, 350);
                panel3.Size = new Size(360, 205);
                f3 = 1;
            }
            else if (f3 == 1)
            {
                panel3.Hide();
                f3 = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Turn On")
                if (numericUpDown2.Text != "0")
                {
                    button2.Text = "Turn Off";
                }
                else
                {
                    MessageBox.Show("Please select temperature!");
                }
            else
            {
                button2.Text = "Turn On";
                numericUpDown2.Value = 0;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Turn On")
                if (numericUpDown3.Text != "0")
                {
                    button3.Text = "Turn Off";
                }
                else
                {
                    MessageBox.Show("Please select temperature!");
                }
            else
            {
                button3.Text = "Turn On";
                numericUpDown3.Value = 0;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "Turn On")
                if (numericUpDown4.Text != "0")
                {
                    button7.Text = "Turn Off";
                }
                else
                {
                    MessageBox.Show("Please select temperature!");
                }
            else
            {
                button7.Text = "Turn On";
                numericUpDown4.Value = 0;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "Turn On")
                if (numericUpDown5.Text != "0")
                {
                    button8.Text = "Turn Off";
                }
                else
                {
                    MessageBox.Show("Please select temperature!");
                }
            else
            {
                button8.Text = "Turn On";
                numericUpDown5.Value = 0;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "Start" )
            {
                if (numericUpDown9.Text != "0")
                {
                    button9.Text = "Stop";
                    MessageBox.Show("Oven is baking with " + comboBox4.Text + " mode at temperature " + numericUpDown9.Text + " °C.");
                }
                else if (numericUpDown9.Text == "0")
                {
                    MessageBox.Show("Please select oven temperature!");
                }
               
            }
            else
                button9.Text = "Start";
        }

        private void dishwasher_Click(object sender, EventArgs e)
        {
            if (f2 == 0)
            {
                panel1.Hide();
                f1 = 0;
                panel4.Hide();
                f4 = 0;
                panel3.Hide();
                f3 = 0;
                panel7.Hide();
                f7 = 0;
                panel2.Show();
                panel2.Location = new Point(130, 380);
                panel2.Size = new Size(365, 220);
                f2 = 1;
            }
            else if (f2 == 1)
            {
                panel2.Hide();
                f2 = 0;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string text1 = comboBox2.Text;
            string text2 = "0";


            string text3 = numericUpDown1.Value.ToString();
            if (button1.Text == "Start")
            {
                if (radioButton3.Checked == true)
                    text2 = radioButton3.Text;
                else if (radioButton4.Checked == true)
                    text2 = radioButton4.Text;
                else if (radioButton5.Checked == true)
                    text2 = radioButton5.Text;
                MessageBox.Show("Dishwasher is washing for " + text3 + " Hour/s" + " at " + text2 + " with " + text1);
            }
        }


        public string[] products = new string[]{"Orange Juice", "Tabasco", "Pepper", "Sausage", "Mustard", "Tomato", "Tomato", "Soy Sause", "Milk"};
        private void smartfridge_Click(object sender, EventArgs e)
        {
            if (f1 == 0)
            {
                panel2.Hide();
                f2 = 0;
                panel4.Hide();
                f4 = 0;
                panel3.Hide();
                f3 = 0;
                panel7.Hide();
                f7 = 0;
                panel1.Show();
                panel1.Location = new Point(100, 300);
                panel1.Size = new Size(395, 320);
                f1 = 1;
                panel5.Hide();
                panel6.Hide();
                panel8.Hide();
                panel9.Hide();
            }
            else if (f1 == 1)
            {
                panel1.Hide();
                f1 = 0;
            }
        }

        private void button10_Click(object sender, EventArgs e)//fridge conditions
        {
            if (panel5.Visible == false)
            {
                panel5.Show();
                panel5.Location = new Point(125, 20);
                panel5.Size = new Size(255, 280);

                panel6.Hide();
                panel8.Hide();
                panel9.Hide();

            }
            else
                panel5.Hide();
        }

        private void button15_Click(object sender, EventArgs e)//print fridge conditions
        {
            MessageBox.Show("The conditions are: " +"\n"+"Temperature for refrigerator is "+numericUpDown6.Value.ToString()+" degrees Celsius" + "\n" +
                "Temperature for freezer is " + numericUpDown7.Value.ToString() + " degrees Celsius" + "\n" +
                "Humidity level is "+comboBox3.Text);
        }

        private void button11_Click(object sender, EventArgs e)//fridge internal
        {
            if (panel6.Visible == false)
            {
                panel6.Show();
                panel6.Location = new Point(125, 20);
                panel6.Size = new Size(255, 280);

                panel5.Hide();
                panel8.Hide();
                panel9.Hide();


            }
            else
                panel6.Hide();


        }

        private void button16_Click(object sender, EventArgs e)//show image
        {
            panel1.Hide();
            panel7.Show();
            panel7.Location = new Point(100, 300);
            panel7.Size = new Size(395, 320);

        }
        private void button17_Click(object sender, EventArgs e)//show product list
        {
            richTextBox1.Clear();
            for(int i =0; i<products.Length; i++)
            {
                richTextBox1.Text += products[i] + Environment.newLine;
            }
        }


        private void button18_Click_1(object sender, EventArgs e)//click X
        {
            panel7.Hide();
            panel1.Show();

        }

        private void button12_Click(object sender, EventArgs e)//recipes button
        {
            if (panel8.Visible == false)
            {
                panel8.Show();
                panel8.Location = new Point(125, 20);
                panel8.Size = new Size(255, 280);

                panel5.Hide();
                panel6.Hide();
                panel9.Hide();

            }
            else
                panel8.Hide();
        }
        public int portions;
        private void button19_Click(object sender, EventArgs e)//view recipes
        {
            if(!radioButton6.Checked & !radioButton7.Checked & !radioButton8.Checked & !radioButton9.Checked & !radioButton10.Checked & !radioButton11.Checked)
            {
                MessageBox.Show("Pick Basic Ingredient!");
            }
            else
            {
                if(radioButton6.Checked)//beaf
                {
                    comboBox5.Items.Clear();
                    comboBox5.Items.AddRange(new string[] {"Beaf Burger", "Beaf Meatloaf"});
                    comboBox5.SelectedIndex = 0;
                }
                else if(radioButton7.Checked)//Pasta
                {
                    comboBox5.Items.Clear();
                    comboBox5.Items.AddRange(new string[] { "Spaghetti Bolognese", "Macaroni & Cheese" });
                    comboBox5.SelectedIndex = 0;
                }
                else if (radioButton8.Checked)//Vegetables
                {
                    comboBox5.Items.Clear();
                    comboBox5.Items.AddRange(new string[] { "Mixed Green Salad", "Tomato Soup" });
                    comboBox5.SelectedIndex = 0;
                }
                else if (radioButton9.Checked)//Pork
                {
                    comboBox5.Items.Clear();
                    comboBox5.Items.AddRange(new string[] { "Guros Soublaki", "Pork Ribs" });
                    comboBox5.SelectedIndex = 0;
                }
                else if (radioButton10.Checked)//Potato
                {
                    comboBox5.Items.Clear();
                    comboBox5.Items.AddRange(new string[] { "French Fries", "Potato Salad" });
                    comboBox5.SelectedIndex = 0;
                }
                else if (radioButton11.Checked)//Desserts
                {
                    comboBox5.Items.Clear();
                    comboBox5.Items.AddRange(new string[] { "Choco Cake", "Ice Cream" });
                    comboBox5.SelectedIndex = 0;
                }
            }
        }
        public string[] ingredients_needed = new string[] { };
        public string recipe_name;
        private void button20_Click(object sender, EventArgs e)
        {
            if(comboBox5.Text =="")
            {
                MessageBox.Show("Pick a Recipe");
            }
            else
            {
                string[] ingredients = new string[] { };
                if (comboBox5.Text =="Beaf Burger")
                {
                    ingredients = new string[] {"Beaf Burger","Bread", "Bread", "Mustard","Ketchup","Tomato","Pickles"};
                    richTextBox2.Clear();
                    for (int i = 0; i < ingredients.Length; i++)
                    {
                        for(int j=0; j<numericUpDown8.Value; j++)
                            richTextBox2.Text += ingredients[i] + Environment.newLine;
                    }
                }
                if (comboBox5.Text == "Beaf Meatloaf")
                {
                    ingredients = new string[] { "Ground Beaf", "Onion", "Garlic ", "Green Pepper", "Egg", "Egg" };
                    richTextBox2.Clear();
                    for (int i = 0; i < ingredients.Length; i++)
                    {
                        for (int j = 0; j < numericUpDown8.Value; j++)
                            richTextBox2.Text += ingredients[i] + Environment.newLine;
                    }
                }
                if (comboBox5.Text == "Spaghetti Bolognese")
                {
                    ingredients = new string[] { "Spaghetti", "Minced Beaf", "Onion", "Garlic ", "Tomato", "Tomato" };
                    richTextBox2.Clear();
                    for (int i = 0; i < ingredients.Length; i++)
                    {
                        for (int j = 0; j < numericUpDown8.Value; j++)
                            richTextBox2.Text += ingredients[i] + Environment.newLine;
                    }
                }
                if (comboBox5.Text == "Macaroni & Cheese")
                {
                    ingredients = new string[] { "Macaroni", "Cheddar Cheese", "Milk ", "Butter", "Egg", "Flour", "Mustard" };
                    richTextBox2.Clear();
                    for (int i = 0; i < ingredients.Length; i++)
                    {
                        for (int j = 0; j < numericUpDown8.Value; j++)
                            richTextBox2.Text += ingredients[i] + Environment.newLine;
                    }
                }
                if (comboBox5.Text == "Mixed Green Salad")
                {
                    ingredients = new string[] { "Spinach", "Letuce", "Cucumber", "Avocado", "Olive Oil", };
                    richTextBox2.Clear();
                    for (int i = 0; i < ingredients.Length; i++)
                    {
                        for (int j = 0; j < numericUpDown8.Value; j++)
                            richTextBox2.Text += ingredients[i] + Environment.newLine;
                    }
                }
                if (comboBox5.Text == "Tomato Soup")
                {
                    ingredients = new string[] { "Tomato", "Tomato", "Tomato", "Onion", "Garlic", "Bazil", "Cruton" };
                    richTextBox2.Clear();
                    for (int i = 0; i < ingredients.Length; i++)
                    {
                        for (int j = 0; j < numericUpDown8.Value; j++)
                            richTextBox2.Text += ingredients[i] + Environment.newLine;
                    }
                }
                if (comboBox5.Text == "Guros Soublaki")
                {
                    ingredients = new string[] { "Pork Guros", "Pita Bread", "Tomato", "Yogurt", "Cucumber", "Potato" };
                    richTextBox2.Clear();
                    for (int i = 0; i < ingredients.Length; i++)
                    {
                        for (int j = 0; j < numericUpDown8.Value; j++)
                            richTextBox2.Text += ingredients[i] + Environment.newLine;
                    }
                }
                if (comboBox5.Text == "Pork Ribs")
                {
                    ingredients = new string[] { "Pork Rib", "Pork Rib", "Pork Rib", "Barbeque Sause", "Olive Oil" };
                    richTextBox2.Clear();
                    for (int i = 0; i < ingredients.Length; i++)
                    {
                        for (int j = 0; j < numericUpDown8.Value; j++)
                            richTextBox2.Text += ingredients[i] + Environment.newLine;
                    }
                }
                if (comboBox5.Text == "French Fries")
                {
                    ingredients = new string[] { "Potato", "Potato", "Potato", "Olive Oil", "Ketchup", "Mustard"};
                    richTextBox2.Clear();
                    for (int i = 0; i < ingredients.Length; i++)
                    {
                        for (int j = 0; j < numericUpDown8.Value; j++)
                            richTextBox2.Text += ingredients[i] + Environment.newLine;
                    }
                }
                if (comboBox5.Text == "Potato Salad")
                {
                    ingredients = new string[] { "Potato", "Potato", "Olive Oil", "Spring Onion", "Mayonnaise", "Tomato", "Mustard" };
                    richTextBox2.Clear();
                    for (int i = 0; i < ingredients.Length; i++)
                    {
                        for (int j = 0; j < numericUpDown8.Value; j++)
                            richTextBox2.Text += ingredients[i] + Environment.newLine;
                    }
                }
                if (comboBox5.Text == "Choco Cake")
                {
                    ingredients = new string[] { "Flour", "Cocoa", "Chia Seeds", "Almond Milk", "Sugar", "Dark Chocolate", "Oil" };
                    richTextBox2.Clear();
                    for (int i = 0; i < ingredients.Length; i++)
                    {
                        for (int j = 0; j < numericUpDown8.Value; j++)
                            richTextBox2.Text += ingredients[i] + Environment.newLine;
                    }
                }
                if (comboBox5.Text == "Ice Cream")
                {
                    ingredients = new string[] { "Condenced Milk", "Sugar", "Vanilla Extract", "Chocolate Chips" };
                    richTextBox2.Clear();
                    for (int i = 0; i < ingredients.Length; i++)
                    {
                        for (int j = 0; j < numericUpDown8.Value; j++)
                            richTextBox2.Text += ingredients[i] + Environment.newLine;
                    }
                }
                ingredients_needed = ingredients;
                portions = int.Parse(numericUpDown8.Value.ToString());
                recipe_name = comboBox5.Text;
            }
        }

        private void button13_Click(object sender, EventArgs e)//products availability
        {
            if (panel9.Visible == false)
            {
                panel9.Show();
                panel9.Location = new Point(125, 20);
                panel9.Size = new Size(255, 280);

                panel5.Hide();
                panel8.Hide();
                panel6.Hide();

            }
            else
                panel9.Hide();
        }

        private void button21_Click(object sender, EventArgs e)//view products
        {
            richTextBox3.Clear();
            for (int i = 0; i < products.Length; i++)
            {
                richTextBox3.Text += products[i] + Environment.newLine;
            }
        }

        private void button22_Click(object sender, EventArgs e)//add product
        {
            if(maskedTextBox1.Text =="")
            {
                MessageBox.Show("Add a product to the list!");
            }
            else
            {
                richTextBox4.Text += maskedTextBox1.Text + Environment.newLine;
            }
        }

        private void button23_Click(object sender, EventArgs e)//add ingredients from recipe
        {
            if(recipe_name==" " || recipe_name ==null)
            {
                MessageBox.Show("You haven't picked a recipe from the Recipes Menu!");
            }
            else
            {
                MessageBox.Show("Recipe picked is: "+recipe_name);
                for (int i = 0; i < ingredients_needed.Length; i++)
                {
                    for (int j = 0; j < portions; j++)
                        richTextBox4.Text += ingredients_needed[i] + Environment.newLine;
                }
            }
        }

        private void button24_Click(object sender, EventArgs e)//make order
        {
            if (richTextBox4.Text == "")
            {
                MessageBox.Show("Please add ingredients to make an order!");
            }
            else
            {
                var x = new string[products.Length + richTextBox4.Lines.Length];
                products.CopyTo(x, 0);
                richTextBox4.Lines.CopyTo(x, products.Length);
                products = x;
                MessageBox.Show("Order Made, the products are in your Refrigerator!");
            }

        }

        private void button14_Click(object sender, EventArgs e)//extra settings
        {

        }

        private void onlinehelpbutton_Click(object sender, EventArgs e)//On-Line Help
        {
            MessageBox.Show ("1.To operate the smart refrigerator, select its icon." + "\ n" + "1.1 Press the Fridge Conditions button to view the internal refrigerator conditions and then what Print Conditions button." + "\ n" + "1.1.1 Press the arrow keys below the Refrigerator Temperature panel to adjust the refrigerator temperature." + "\ n" + "1.1.2 Press the arrow keys to adjust the freezer temperature. are below the Freezer Temperature sign. "+" \ n "+" 1.1.3 To adjust the humidity, press the arrow below the Humidity leve sign. l. "," On-Line Help Page 1 ");
            MessageBox.Show ("1.2 Press the Fridge Internal button to display the interior of the refrigerator and then the Show Internal button." + "\ n" + "1.2.1 Press the Print button to print the products in the refrigerator products. "," On-Line Help Page 2 ");
            MessageBox.Show ("1.3 To view the available recipes click on the Recipes button" + "\ n" + "1.3.1 Select basic ingredients under the Basic Ingredients" + "\ n" + "tab and click the View Recipes button to view the available recipes. "+" \ n "+" 1.3.2 After selecting the recipe, select the number of portions next to the Select Portions "+" \ n "+" tab and click the Show recipe's ingredients button to view the recipes. components of the selected recipe. "," On-Line Help page 3 ");
            MessageBox.Show ("1.4 To view the availability of refrigerator products press the Products Availability button" + "\ n" + "1.4.1 Then click the view products button to display the products available in the refrigerator" + "\ n "+" 1.4.2 To add a product to the shopping list, enter the product name in the special box and press the Add products "+" \ n "+" button 1.4.3 If a recipe has been previously selected, you can press "+" \ n "+" button Add ingredients from recipe to add recipe materials to the "+" \ n "+" shopping list 1.4.4 laughter of the products that are in the shopping list, press the Make order button, "+" \ n "+" and then what view products button to display the products in the refrigerator "," On-Line Help " page 4 ");
            MessageBox.Show ("2. To operate the smart dishwasher select its icon." + "\ n" + "2.1 Select one of the available washing options under the Washing Mode tab." + "\ n" + "2.2 Select a temperature (40, 60 or 100 degrees Celsius) under the Temperature tab." + "\ n" + "2.3 Select a washing time under the Time tab." + "\ n" + "2.4 Start the washing by pressing the Start button. "+" \ n "+" 2.5 To stop washing before finishing, "+" \ n "+" press the Stop button (which takes the position of the Start button after pressing Start). "," On-Line Help Page 5 ");
            MessageBox.Show ("3. To operate the smart oven select its icon." + "\ n" + "3.1 To set one of the kitchen eyes first, set the temperature below the" + "eye sign. \ n "+" to use (eg. Kitchen Hob 1, Kitchen Hub 2, etc.) "+" \ n "+" 3.2 Then press the Turn On button below the corresponding kitchen eye label wish to light "+" \ n "+" 3.3 To switch on the oven, first select the "+" \ n "+" mode 3.4 Then select the temperature "+" \ n "+" 3.5 Press the Start button "," On-Line Help page 6 ");
            MessageBox.Show ("4. To operate the smart coffee maker select its icon." + "\ n" + "4.1 Choose whether the coffee will be cold or hot" + "\ n" + "4.2 Select the type of coffee (eg Greek, French, etc.) "+" \ n "+" 4.3 Add water by pressing the Add Water button "+" \ n "+" 4.4 Make coffee by pressing the Make Coffee button "+" \ n "+" 4.5 Press the Clean Filters button "," On-Line Help page 7 "to clean the coffee maker);        }
    }
}
