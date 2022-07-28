using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues {
    internal class Order {

        // order id
        public int OrderId { get; set; }

        // order quantity
        public int OrderQuantity { get; set; }

        // simple constructor
        public Order(int id, int quantity) {
            this.OrderId = id;
            this.OrderQuantity = quantity;
        }

        // print message to console that order was processed
        public void ProcessOrder() {
            Console.WriteLine($"Order - {OrderId} processed!");
        }
    }
}
