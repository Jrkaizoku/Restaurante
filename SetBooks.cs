using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO3
{
    class SetBooks
    {
        public int index;
        int numBook = 10;
        Book[] _book = new Book[10];

        public SetBooks()
        {
            index = 0;
        }

        public void AddBook(Book book)
        {
            if (index <  numBook)
            {
                _book[index] = book;
                index++;
            }
            else
            {
                Console.WriteLine("Libreria Llena");
            }
        }
        public void GetBook(int book)
        {
            Console.WriteLine(_book[book]);
        }

        public override string ToString()
        {
            return StringBooks(_book);
        }
        private string StringBooks(Book[] book)
        {
            StringBuilder sb = new StringBuilder();
          
            for (int i = 0; i < index; i++)
            {
                if (_book[i] == null) { continue; }               
                string dato = string.Format("     {0}. {1} ", i + 1, book[i]);              
                sb.AppendLine(dato);
              
            }

            return sb.ToString();
        }
        public void ShowBooks()
        {
            Console.WriteLine(this);
        }

    }
}
