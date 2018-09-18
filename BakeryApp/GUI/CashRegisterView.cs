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
using BakeryApp.GUI;

namespace BakeryApp
{
    public partial class CashRegisterView : Form
    {

        private Label totalLabel;
        private TextBox totalBox;

        private DataGridView orderDetails;

        private DataGridViewColumn itemColumn;
        private DataGridViewColumn priceColumn;

        private Button frenchBaguetteButton;
        private Button softBreadButton;
        private Button appleSmoothyButton;
        private Button cokeButton;
        private Button hamSandwichButton;
        private Button paniniButton;
        private Button cookieButton;
        private Button cheeseCakeButton;

        private Button breakfastButton;
        private Button lunchButton;
        private Button afternoonTeaButton;

        private Button loadStocksButton;

        private Button newStocksButton;

        private Button validateButton;

        private Stock stock;

        private Breakfast<Bread, Drink> breakfast;
        private Lunch<Sandwich, Drink> lunch;
        private AfternoonTea<Dessert, Drink> afternoonTea;

        private StockLoader stockloader;
        private String stockFileName;


        public CashRegisterView()
        {
            InitializeComponent();

            this.totalLabel = new Label();
            this.totalBox = new TextBox();

            this.orderDetails = new DataGridView();

            this.itemColumn = new DataGridViewColumn();
            this.priceColumn = new DataGridViewColumn();

            this.frenchBaguetteButton = new Button();
            this.softBreadButton = new Button();
            this.appleSmoothyButton = new Button();
            this.cokeButton = new Button();
            this.hamSandwichButton = new Button();
            this.paniniButton = new Button();
            this.cookieButton = new Button();
            this.cheeseCakeButton = new Button();

            this.breakfastButton = new Button();
            this.lunchButton = new Button();
            this.afternoonTeaButton = new Button();

            this.loadStocksButton = new Button();

            this.newStocksButton = new Button();

            this.validateButton = new Button();

            this.stockloader = new StockLoader();

            totalLabel.Location = new Point(24, 20);
            totalLabel.Size = new Size(80, 50);
            totalLabel.Text = "Total Price";

            totalBox.Location = new Point(120, 20);
            totalBox.Size = new Size(80, 50);
            totalBox.ReadOnly = true;

            itemColumn.HeaderText = "item";
            itemColumn.Name = "item";
            itemColumn.CellTemplate = new DataGridViewTextBoxCell();
            priceColumn.HeaderText = "price";
            priceColumn.Name = "price";
            priceColumn.CellTemplate = new DataGridViewTextBoxCell();

            orderDetails.Location = new Point(300, 24);
            orderDetails.Size = new Size(240, 300);
            orderDetails.Columns.Add(itemColumn);
            orderDetails.Columns.Add(priceColumn);
            orderDetails.Click += new System.EventHandler(orderDetails_Click);

            frenchBaguetteButton.Location = new Point(24, 100);
            frenchBaguetteButton.Size = new Size(120, 24);
            frenchBaguetteButton.Name = "French Baguette";
            frenchBaguetteButton.Click += new System.EventHandler(food_Click);

            softBreadButton.Location = new Point(24, 130);
            softBreadButton.Size = new Size(120, 24);
            softBreadButton.Name = "Soft Bread";
            softBreadButton.Click += new System.EventHandler(food_Click);

            appleSmoothyButton.Location = new Point(24, 160);
            appleSmoothyButton.Size = new Size(120, 24);
            appleSmoothyButton.Name = "Apple Smoothy";
            appleSmoothyButton.Click += new System.EventHandler(food_Click);

            cokeButton.Location = new Point(24, 190);
            cokeButton.Size = new Size(120, 24);
            cokeButton.Name = "Coke";
            cokeButton.Click += new System.EventHandler(food_Click);

            hamSandwichButton.Location = new Point(24, 220);
            hamSandwichButton.Size = new Size(120, 24);
            hamSandwichButton.Name = "Ham Sandwich";
            hamSandwichButton.Click += new System.EventHandler(food_Click);

            paniniButton.Location = new Point(24, 250);
            paniniButton.Size = new Size(120, 24);
            paniniButton.Name = "Panini";
            paniniButton.Click += new System.EventHandler(food_Click);

            cookieButton.Location = new Point(24, 280);
            cookieButton.Size = new Size(120, 24);
            cookieButton.Name = "Cookie";
            cookieButton.Click += new System.EventHandler(food_Click); 

            cheeseCakeButton.Location = new Point(24, 310);
            cheeseCakeButton.Size = new Size(120, 24);
            cheeseCakeButton.Name = "Cheese Cake";
            cheeseCakeButton.Click += new System.EventHandler(food_Click);

            breakfastButton.Location = new Point(150, 100);
            breakfastButton.Size = new Size(120, 50);
            breakfastButton.Name = "Breakfast";
            breakfastButton.Click += new System.EventHandler(menu_Click);

            lunchButton.Location = new Point(150, 190);
            lunchButton.Size = new Size(120, 50);
            lunchButton.Name = "Lunch";
            lunchButton.Click += new System.EventHandler(menu_Click);

            afternoonTeaButton.Location = new Point(150, 280);
            afternoonTeaButton.Size = new Size(120, 50);
            afternoonTeaButton.Name = "Afternoon Tea";
            afternoonTeaButton.Click += new System.EventHandler(menu_Click);

            loadStocksButton.Location = new Point(50, 340);
            loadStocksButton.Size = new Size(100, 30);
            loadStocksButton.Name = "Load Stocks";
            loadStocksButton.Text = "Load Stocks";
            loadStocksButton.Click += new System.EventHandler(loadStock_Click);

            newStocksButton.Location = new Point(200, 340);
            newStocksButton.Size = new Size(100, 30);
            newStocksButton.Name = "New Stocks";
            newStocksButton.Text = "New Stocks";
            newStocksButton.Click += new System.EventHandler(newStock_Click);

            validateButton.Location = new Point(380, 340);
            validateButton.Size = new Size(100, 30);
            validateButton.Name = "Validate";
            validateButton.Text = "Validate";
            validateButton.Click += new System.EventHandler(validate_Click);

            this.stock = new Stock();

            loadButtonsText();

            this.Controls.Add(totalLabel);
            this.Controls.Add(totalBox);

            this.Controls.Add(frenchBaguetteButton);
            this.Controls.Add(softBreadButton);
            this.Controls.Add(appleSmoothyButton);
            this.Controls.Add(cokeButton);
            this.Controls.Add(hamSandwichButton);
            this.Controls.Add(paniniButton);
            this.Controls.Add(cookieButton);
            this.Controls.Add(cheeseCakeButton);

            this.Controls.Add(breakfastButton);
            this.Controls.Add(lunchButton);
            this.Controls.Add(afternoonTeaButton);

            this.Controls.Add(orderDetails);

            this.Controls.Add(loadStocksButton);

            this.Controls.Add(newStocksButton);

            this.Controls.Add(validateButton);
        }

        private void food_Click(object sender, EventArgs e)
        {
            Button buttonClicked = sender as Button;
            int rowIndex = orderDetails.Rows.Add();
            var row = orderDetails.Rows[rowIndex];
            IFood food;

            switch (buttonClicked.Name)
            {
                case "French Baguette":
                    food = new FrenchBaguette();
                    row.Cells["item"].Value = buttonClicked.Name;
                    row.Cells["price"].Value = food.price;
                    stock.frenchBaguetteStock -= 1;
                    break;
                case "Soft Bread":
                    food = new SoftBread();
                    row.Cells["item"].Value = buttonClicked.Name;
                    row.Cells["price"].Value = food.price;
                    stock.softBreadStock -= 1;
                    break;
                case "Apple Smoothy":
                    food = new AppleSmoothy();
                    row.Cells["item"].Value = buttonClicked.Name;
                    row.Cells["price"].Value = food.price;
                    stock.appleSmoothyStock -= 1;
                    break;
                case "Coke":
                    food = new Coke();
                    row.Cells["item"].Value = buttonClicked.Name;
                    row.Cells["price"].Value = food.price;
                    stock.cokeStock -= 1;
                    break;
                case "Ham Sandwich":
                    food = new HamSandwich();
                    row.Cells["item"].Value = buttonClicked.Name;
                    row.Cells["price"].Value = food.price;
                    stock.hamSandwichStock -= 1;
                    break;
                case "Panini":
                    food = new Panini();
                    row.Cells["item"].Value = buttonClicked.Name;
                    row.Cells["price"].Value = food.price;
                    stock.paniniStock -= 1;
                    break;
                case "Cookie":
                    food = new Cookie();
                    row.Cells["item"].Value = buttonClicked.Name;
                    row.Cells["price"].Value = food.price;
                    stock.cookieStock -= 1;
                    break;
                case "Cheese Cake":
                    food = new CheeseCake();
                    row.Cells["item"].Value = buttonClicked.Name;
                    row.Cells["price"].Value = food.price;
                    stock.cheeseCakeStock -= 1;
                    buttonClicked.Text = "Cheese Cake " + stock.cheeseCakeStock;
                    break;
            }
            updateTotal();
            loadButtonsText();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            Button buttonClicked = sender as Button;
            int rowIndex = orderDetails.Rows.Add();
            var row = orderDetails.Rows[rowIndex];

            switch (buttonClicked.Name)
            {
                case "Breakfast":
                    BreakfastView breakfastView = new BreakfastView(stock);
                    breakfastView.ShowDialog();
                    breakfast = breakfastView.breakfast;
                    row.Cells["item"].Value = buttonClicked.Name;
                    row.Cells["price"].Value = breakfast.price;

                    break;
                case "Lunch":
                    LunchView lunchView = new LunchView(stock);
                    lunchView.ShowDialog();
                    lunch = lunchView.lunch;
                    row.Cells["item"].Value = buttonClicked.Name;
                    row.Cells["price"].Value = lunch.price;
                    break;
                case "Afternoon Tea":
                    AfternoonTeaView afternoonTeaView = new AfternoonTeaView(stock);
                    afternoonTeaView.ShowDialog();
                    afternoonTea = afternoonTeaView.afternoonTea;
                    row.Cells["item"].Value = buttonClicked.Name;
                    row.Cells["price"].Value = afternoonTea.price;
                    break;
            }
            updateTotal();
            loadButtonsText();
        }

        private void orderDetails_Click(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
            if (dgv.CurrentRow.Selected)
            {
                switch (dgv.Rows[dgv.CurrentRow.Index].Cells["item"].Value.ToString())
                {
                    case "French Baguette":
                        stock.frenchBaguetteStock += 1;
                        break;
                    case "Soft Bread":
                        stock.softBreadStock += 1;
                        break;
                    case "Apple Smoothy":
                        stock.appleSmoothyStock += 1;
                        break;
                    case "Coke":
                        stock.cokeStock += 1;
                        break;
                    case "Ham Sandwich":
                        stock.hamSandwichStock += 1;
                        break;
                    case "Panini":
                        stock.paniniStock += 1;
                        break;
                    case "Cookie":
                        stock.paniniStock += 1;
                        break;
                    case "Cheese Cake":
                        stock.cheeseCakeStock += 1;
                        break;
                }
                dgv.Rows.Remove(dgv.CurrentRow);
                updateTotal();
                loadButtonsText();
            }
        }

        private void updateTotal()
        {
            double sum = 0;
            for(int i=0; i<orderDetails.Rows.Count; i++)
            {
                sum += Convert.ToDouble(orderDetails.Rows[i].Cells["price"].Value);
            }
            totalBox.Text = sum.ToString();
        }

        private void loadButtonsText()
        {
            frenchBaguetteButton.Text = "French Baguette " + stock.frenchBaguetteStock;
            softBreadButton.Text = "Soft Bread " + stock.softBreadStock;
            appleSmoothyButton.Text = "Apple Smoothy " + stock.appleSmoothyStock;
            cokeButton.Text = "Coke " + stock.cokeStock;
            hamSandwichButton.Text = "Ham Sandwich " + stock.hamSandwichStock;
            paniniButton.Text = "Panini " + stock.paniniStock;
            cookieButton.Text = "Cookie " + stock.cookieStock;
            cheeseCakeButton.Text = "Cheese Cake " + stock.cheeseCakeStock;
            breakfastButton.Text = "Breakfast " + Math.Min(Math.Min(stock.frenchBaguetteStock, stock.softBreadStock), Math.Min(stock.appleSmoothyStock, stock.cokeStock));
            lunchButton.Text = "Lunch " + Math.Min(Math.Min(stock.hamSandwichStock, stock.paniniStock), Math.Min(stock.appleSmoothyStock, stock.cokeStock));
            afternoonTeaButton.Text = "Afternoon Tea " + Math.Min(Math.Min(stock.cookieStock, stock.cheeseCakeStock), Math.Min(stock.appleSmoothyStock, stock.cokeStock));
            if (stock.frenchBaguetteStock == 0)
                frenchBaguetteButton.Enabled = false;
            if (stock.softBreadStock == 0)
                softBreadButton.Enabled = false;
            if (stock.appleSmoothyStock == 0)
                appleSmoothyButton.Enabled = false;
            if (stock.cokeStock == 0)
                cokeButton.Enabled = false;
            if (stock.hamSandwichStock == 0)
                hamSandwichButton.Enabled = false;
            if (stock.paniniStock == 0)
                paniniButton.Enabled = false;
            if (stock.cookieStock == 0)
                cookieButton.Enabled = false;
            if (stock.cheeseCakeStock == 0)
                cheeseCakeButton.Enabled = false;
        }

        public void validate_Click(object sender, EventArgs e)
        {
            stockFileName = DateTime.Now.ToString("dd-MMMM-yy hh.mm") + ".xml";
            stockloader.save(stock, stockFileName);
            orderDetails.Rows.Clear();
        }

        public void loadStock_Click(object sender, EventArgs e)
        {
            stock = stockloader.load();
            loadButtonsText();
        }

        public void newStock_Click(object sender, EventArgs e)
        {
            NewStockView newStockView = new NewStockView(stock);
            newStockView.ShowDialog();
            stock = newStockView.stock;
            loadButtonsText();
        }
    }
}
