using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BakeryApp.SyncExploration;
using Syncfusion.WinForms.DataGrid;

namespace BakeryApp.GUI
{
    public partial class SyncExplorationView : Form
    {
        public SyncExplorationView()
        {
            InitializeComponent();
            SfDataGrid sfDataGrid = new SfDataGrid();
            sfDataGrid.Location = new Point(24, 24);
            sfDataGrid.Size = new Size(400, 400);

            OrderInfoCollection orderInfoCollection = new OrderInfoCollection();
            sfDataGrid.DataSource = orderInfoCollection.Orders;

            this.Controls.Add(sfDataGrid);
        }
    }
}
