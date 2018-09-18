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
    public partial class AfternoonTeaView : Form
    {
        Button cookieMenuButton;
        Button cheeseCakeMenuButton;

        Button appleSmoothyMenuButton;
        Button cokeMenuButton;

        Dessert dessert;
        Drink drink;

        public AfternoonTea<Dessert, Drink> afternoonTea;

        public Stock stock;

        public AfternoonTeaView(Stock stock)
        {
            InitializeComponent();
            cookieMenuButton = new Button();
            cheeseCakeMenuButton = new Button();
            appleSmoothyMenuButton = new Button();
            cokeMenuButton = new Button();

            cookieMenuButton.Text = "Cookie";
            cookieMenuButton.Location = new Point(24, 24);
            cookieMenuButton.Size = new Size(150, 24);
            cookieMenuButton.Click += new System.EventHandler(firstItemMenu_Click);

            cheeseCakeMenuButton.Text = "Cheese Cake";
            cheeseCakeMenuButton.Location = new Point(180, 24);
            cheeseCakeMenuButton.Size = new Size(150, 24);
            cheeseCakeMenuButton.Click += new System.EventHandler(firstItemMenu_Click);

            appleSmoothyMenuButton.Text = "Apple Smoothy";
            appleSmoothyMenuButton.Location = new Point(24, 24);
            appleSmoothyMenuButton.Size = new Size(150, 24);
            appleSmoothyMenuButton.Click += new System.EventHandler(secondItemMenu_Click);

            cokeMenuButton.Text = "Coke";
            cokeMenuButton.Location = new Point(180, 24);
            cokeMenuButton.Size = new Size(150, 24);
            cokeMenuButton.Click += new System.EventHandler(secondItemMenu_Click);


            this.Controls.Add(cookieMenuButton);
            this.Controls.Add(cheeseCakeMenuButton);

            this.stock = stock;
        }

        private void firstItemMenu_Click(object sender, EventArgs e)
        {
            Button buttonClicked = sender as Button;
            switch (buttonClicked.Text)
            {
                case "Cookie":
                    dessert = new Cookie();
                    this.stock.cookieStock -= 1;
                    break;
                case "Cheese Cake":
                    dessert = new CheeseCake();
                    this.stock.cheeseCakeStock -= 1;
                    break;
            }
            cookieMenuButton.Dispose();
            cheeseCakeMenuButton.Dispose();
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
            afternoonTea = new AfternoonTea<Dessert, Drink>(dessert, drink);
            this.Close();
        }
    }
}
