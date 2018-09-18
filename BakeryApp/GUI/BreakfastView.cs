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
    public partial class BreakfastView : Form
    {
        Button frenchBaguetteMenuButton;
        Button softBreadMenuButton;

        Button appleSmoothyMenuButton;
        Button cokeMenuButton;

        Bread bread;
        Drink drink;

        public Breakfast<Bread, Drink> breakfast;

        public Stock stock;

        public BreakfastView(Stock stock)
        {
            InitializeComponent();
            frenchBaguetteMenuButton = new Button();
            softBreadMenuButton = new Button();
            appleSmoothyMenuButton = new Button();
            cokeMenuButton = new Button();

            frenchBaguetteMenuButton.Text = "French Baguette";
            frenchBaguetteMenuButton.Location = new Point(24, 24);
            frenchBaguetteMenuButton.Size = new Size(150, 24);
            frenchBaguetteMenuButton.Click += new System.EventHandler(firstItemMenu_Click);

            softBreadMenuButton.Text = "Soft Bread";
            softBreadMenuButton.Location = new Point(180, 24);
            softBreadMenuButton.Size = new Size(150, 24);
            softBreadMenuButton.Click += new System.EventHandler(firstItemMenu_Click);

            appleSmoothyMenuButton.Text = "Apple Smoothy";
            appleSmoothyMenuButton.Location = new Point(24, 24);
            appleSmoothyMenuButton.Size = new Size(150, 24);
            appleSmoothyMenuButton.Click += new System.EventHandler(secondItemMenu_Click);

            cokeMenuButton.Text = "Coke";
            cokeMenuButton.Location = new Point(180, 24);
            cokeMenuButton.Size = new Size(150, 24);
            cokeMenuButton.Click += new System.EventHandler(secondItemMenu_Click);
           

            this.Controls.Add(frenchBaguetteMenuButton);
            this.Controls.Add(softBreadMenuButton);

            this.stock = stock;
        }

        private void firstItemMenu_Click(object sender, EventArgs e)
        {
            Button buttonClicked = sender as Button;
            switch (buttonClicked.Text)
            {
                case "French Baguette":
                    bread = new FrenchBaguette();
                    this.stock.frenchBaguetteStock -= 1;
                    break;
                case "Soft Bread":
                    bread = new SoftBread();
                    this.stock.softBreadStock -= 1;
                    break;
            }
            frenchBaguetteMenuButton.Dispose();
            softBreadMenuButton.Dispose();
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
            breakfast = new Breakfast<Bread, Drink>(bread, drink);
            this.Close();
        }
    }
}
