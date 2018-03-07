using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerProject.Models
{
    public class Order
    {
        public Order() { }
        public Order(DateTime date, decimal total, int customerID)
        {
            Date = date;
            Total = total;
            CustomerId = customerID;
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}