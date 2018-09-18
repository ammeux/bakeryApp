using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BakeryApp.Food;

namespace BakeryApp.GUI
{
    public partial class LunchView : Form
    {
        Button hamSandwichMenuButton;
        Button paniniMenuButton;

        Button appleSmoothyMenuButton;
        Button cokeMenuButton;

        Sandwich sandwich;
        Drink drink;

        public Stock stock;

        public Lunch<Sandwich, Drink> lunch;

        public LunchView(Stock stock)
        {
            InitializeComponent();

            hamSandwichMenuButton = new Button();
            paniniMenuButton = new Button();
            appleSmoothyMenuButton = new Button();
            cokeMenuButton = new Button();

            hamSandwichMenuButton.Text = "Ham Sandwich";
            hamSandwichMenuButton.Location = new Point(24, 24);
            hamSandwichMenuButton.Size = new Size(150, 24);
            hamSandwichMenuButton.Click += new System.EventHandler(firstItemMenu_Click);

            paniniMenuButton.Text = "Panini";
            paniniMenuButton.Location = new Point(180, 24);
            paniniMenuButton.Size = new Size(150, 24);
            paniniMenuButton.Click += new System.EventHandler(firstItemMenu_Click);

            appleSmoothyMenuButton.Text = "Apple Smoothy";
            appleSmoothyMenuButton.Location = new Point(24, 24);
            appleSmoothyMenuButton.Size = new Size(150, 24);
            appleSmoothyMenuButton.Click += new System.EventHandler(secondItemMenu_Click);

            cokeMenuButton.Text = "Coke";
            cokeMenuButton.Location = new Point(180, 24);
            cokeMenuButton.Size = new Size(150, 24);
            cokeMenuButton.Click += new System.EventHandler(secondItemMenu_Click);


            this.Controls.Add(hamSandwichMenuButton);
            this.Controls.Add(paniniMenuButton);

            this.stock = stock;
        }

        private void firstItemMenu_Click(object sender, EventArgs e)
        {
            Button buttonClicked = sender as Button;
            switch (buttonClicked.Text)
            {
                case "Ham Sandwich":
                    sandwich = new HamSandwich();
                    this.stock.hamSandwichStock -= 1;
                    break;
                case "Panini":
                    sandwich = new Panini();
                    this.stock.paniniStock -= 1;
                    break;
            }
            hamSandwichMenuButton.Dispose();
            paniniMenuButton.Dispose();
            this.Controls.Add(appleSmoothyMenuButton);
            this.Controls.Add(cokeMenuButton);
        }

        private void secondItemMenu_Click(object sender, EventArgs e)
        {
            Button buttonClicked = sender as Button;
            switch (buttonClicked.Text)
            {
                case "Apple Smoothy":
                    drink = new AppleSmoothy();
                    this.stock.appleSmoothyStock -= 1;
                    break;
                case "Coke":
                    drink = new Coke();
                    this.stock.cokeStock -= 1;
                    break;
            }
            lunch = new Lunch<Sandwich, Drink>(sandwich, drink);
            this.Close();
        }
    }
}
