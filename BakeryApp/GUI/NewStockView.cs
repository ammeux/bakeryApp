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
using System.Reflection;

namespace BakeryApp.GUI
{
    public partial class NewStockView : Form
    {

        private Label frenchBaguetteLabel;
        private Label softBreadLabel;
        private Label appleSmoothyLabel;
        private Label cokeLabel;
        private Label hamSandwichLabel;
        private Label paniniLabel;
        private Label cookieLabel;
        private Label cheeseCakeLabel;

        private TextBox frenchBaguetteTextBox;
        private TextBox softBreadTextBox;
        private TextBox appleSmoothyTextBox;
        private TextBox cokeTextBox;
        private TextBox hamSandwichTextBox;
        private TextBox paniniTextBox;
        private TextBox cookieTextBox;
        private TextBox cheeseCakeTextBox;

        private Button addStockButton;

        public Stock stock;

        public NewStockView(Stock stock)
        {
            InitializeComponent();

            this.stock = stock;

            this.frenchBaguetteLabel = new Label();
            this.softBreadLabel = new Label();
            this.appleSmoothyLabel = new Label();
            this.cokeLabel = new Label();
            this.hamSandwichLabel = new Label();
            this.paniniLabel = new Label();
            this.cookieLabel = new Label();
            this.cheeseCakeLabel = new Label();

            this.frenchBaguetteTextBox = new TextBox();
            this.softBreadTextBox = new TextBox();
            this.appleSmoothyTextBox = new TextBox();
            this.cokeTextBox = new TextBox();
            this.hamSandwichTextBox = new TextBox();
            this.paniniTextBox = new TextBox();
            this.cookieTextBox = new TextBox();
            this.cheeseCakeTextBox = new TextBox();

            this.addStockButton = new Button();

            frenchBaguetteLabel.Location = new Point(24, 24);
            frenchBaguetteLabel.Size = new Size(100, 24);
            frenchBaguetteLabel.Text = "French Baguette: ";

            softBreadLabel.Location = new Point(24, 50);
            softBreadLabel.Size = new Size(100, 24);
            softBreadLabel.Text = "Soft Bread: ";

            appleSmoothyLabel.Location = new Point(24, 75);
            appleSmoothyLabel.Size = new Size(100, 24);
            appleSmoothyLabel.Text = "Apple Smoothy: ";

            cokeLabel.Location = new Point(24, 100);
            cokeLabel.Size = new Size(100, 24);
            cokeLabel.Text = "Coke: ";

            hamSandwichLabel.Location = new Point(24, 125);
            hamSandwichLabel.Size = new Size(100, 24);
            hamSandwichLabel.Text = "Ham Sandwich: ";

            paniniLabel.Location = new Point(24, 150);
            paniniLabel.Size = new Size(100, 24);
            paniniLabel.Text = "Panini: ";

            cookieLabel.Location = new Point(24, 175);
            cookieLabel.Size = new Size(100, 24);
            cookieLabel.Text = "Cookie : ";

            cheeseCakeLabel.Location = new Point(24, 200);
            cheeseCakeLabel.Size = new Size(100, 24);
            cheeseCakeLabel.Text = "Cheese Cake: ";

            frenchBaguetteTextBox.Location = new Point(150, 24);
            frenchBaguetteTextBox.Size = new Size(100, 24);
            frenchBaguetteTextBox.Name = "French Baguette";
            frenchBaguetteTextBox.Text = "0";

            softBreadTextBox.Location = new Point(150, 50);
            softBreadTextBox.Size = new Size(100, 24);
            softBreadTextBox.Name = "Soft Bread";
            softBreadTextBox.Text = "0";

            appleSmoothyTextBox.Location = new Point(150, 75);
            appleSmoothyTextBox.Size = new Size(100, 24);
            appleSmoothyTextBox.Name = "Apple Smoothie";
            appleSmoothyTextBox.Text = "0";

            cokeTextBox.Location = new Point(150, 100);
            cokeTextBox.Size = new Size(100, 24);
            cokeTextBox.Name = "Coke";
            cokeTextBox.Text = "0";

            hamSandwichTextBox.Location = new Point(150, 125);
            hamSandwichTextBox.Size = new Size(100, 24);
            hamSandwichTextBox.Name = "Ham Sandwich";
            hamSandwichTextBox.Text = "0";

            paniniTextBox.Location = new Point(150, 150);
            paniniTextBox.Size = new Size(100, 24);
            paniniTextBox.Name = "Panini";
            paniniTextBox.Text = "0";

            cookieTextBox.Location = new Point(150, 175);
            cookieTextBox.Size = new Size(100, 24);
            cookieTextBox.Name = "Cookie";
            cookieTextBox.Text = "0";

            cheeseCakeTextBox.Location = new Point(150, 200);
            cheeseCakeTextBox.Size = new Size(100, 24);
            cheeseCakeTextBox.Name = "Cheese Cake";
            cheeseCakeTextBox.Text = "0";
            
            addStockButton.Location = new Point(80, 230);
            addStockButton.Size = new Size(100, 24);
            addStockButton.Text = "Add Stock";
            addStockButton.Click += new System.EventHandler(addStock_Click);

            this.Controls.Add(frenchBaguetteLabel);
            this.Controls.Add(softBreadLabel);
            this.Controls.Add(appleSmoothyLabel);
            this.Controls.Add(cokeLabel);
            this.Controls.Add(hamSandwichLabel);
            this.Controls.Add(paniniLabel);
            this.Controls.Add(cookieLabel);
            this.Controls.Add(cheeseCakeLabel);

            this.Controls.Add(frenchBaguetteTextBox);
            this.Controls.Add(softBreadTextBox);
            this.Controls.Add(appleSmoothyTextBox);
            this.Controls.Add(cokeTextBox);
            this.Controls.Add(hamSandwichTextBox);
            this.Controls.Add(paniniTextBox);
            this.Controls.Add(cookieTextBox);
            this.Controls.Add(cheeseCakeTextBox);

            this.Controls.Add(addStockButton);
        }

        public void addStock_Click(object sender, EventArgs e)
        {

            List<Int32> stockList = new List<int>();
            PropertyInfo[] properties = typeof(Stock).GetProperties();
            int i = 0;
            int prevStock;
             
            foreach (Control x in this.Controls)
            {             
                if(x is TextBox)
                {
                    stockList.Add(int.Parse(x.Text));
                }
            }

            foreach (PropertyInfo property in properties)
            {
                prevStock = int.Parse(property.GetValue(stock).ToString());
                property.SetValue(stock, prevStock + stockList[i]);
                i++;
            }

            this.Close();
        }
    }
}
