using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO3
{
    class Invoice
    {
        public int Number { get; set; }
        public int NumTable { get; set; }
        public int NumPersons { get; set; }
        Waiter[] waiter=new Waiter[5] ;
        public Order[] orders;
        public int _index;
        int numOrder=10;

        public Invoice(int number, int numTable, int numPersons)
        {
            Number = number;
            NumTable = numTable;
            NumPersons = numPersons;
            orders = new Order[numOrder];
            
            Waiters();
        }

        public Invoice()
        {
            orders = new Order[numOrder];
            _index = 0;
            Waiters();
        }
        public string SearchWaiter(int id) {
            return waiter[id].Name;
        }
        public void AddOrder(Order order) {           
             if (_index < numOrder) {
                 orders[_index] = order;
                _index++;
             }    
        }
        public double Total() {
            double subTotal = 0;
            for (int i = 0; i < _index; i++) 
               subTotal+= (orders[i].Price * orders[i].Quantity);

            return  subTotal;
        }
        public void Waiters()
        {
            string[] waiters = { "Jenniffer Granados", "Jericho Barrons", "Androssi Zahad", "Mackeyla Lane", "Malori Crowel" };
            for (int i = 0; i < 5; i++)
                waiter[i] =new Waiter(i + 10, waiters[i]);
            
        }
        public void GetInvoice(int order)
        {
            Console.WriteLine(orders[order]);
        }

        public override string ToString()
        {
            return StringOrder(orders);
        }
        private string StringOrder(Order[] order)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < _index; i++)
            {
                if (orders[i] == null) { continue; }
                string dato = string.Format("   {0} ", order[i]);
                sb.AppendLine(dato);

            }

            return sb.ToString();
        }
        public void ShowInvoice()
        {
            Console.WriteLine(this);
        }



    }
}
