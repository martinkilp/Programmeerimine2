using System;
using System.Collections.Generic;
using System.Text;

namespace KooliProjekt.Application.Data
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderNo { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DueDate { get; set; }
        public int Status { get; set; } = 1;
        public decimal Discount { get; set; }
        public decimal Subtotal { get; set; }
        public string Shipping { get; set; }
        public decimal GrandTotal { get; set; }
    }
}
