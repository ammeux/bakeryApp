using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApp.SyncExploration
{
    class OrderInfo
    {
        private int orderId;
        private string customerId;
        private string country;
        private string customerName;
        private string shippingCity;

        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }

        public string CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string ShipCity
        {
            get { return shippingCity; }
            set { shippingCity = value; }
        }

        public OrderInfo(int orderId, string customerName, string country, string customerId, string shipCity)
        {
            this.OrderId = orderId;
            this.CustomerName = customerName;
            this.Country = country;
            this.CustomerId = customerId;
            this.ShipCity = shipCity;
        }
    }
}
