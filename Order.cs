using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO3
{
    class Order
    {
        public string Detail { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Order()
        {
        }

        public Order(string detail, int quantity, double price)
        {
            Detail = detail;
            Quantity = quantity;
            Price = price;
        }

        public override string ToString()
        {           
            for (int i = Detail.Length; i < 15; i++) 
                Detail += " ";

             if (Detail.Length > 15) {
                Detail = Detail.Substring(0, 15);
            }
            

            return string.Format("  {0} x \t{1}\n     {2}\t       {3}", Quantity,Price, Detail, Price*Quantity);
        }
    }
}
