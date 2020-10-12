using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO3
{
    class Program
    {
        static Book book;
        static SetBooks setBooks = new SetBooks();
        static int initial_position = 1;
        static void Main(string[] args)
        {
            addBook();
            Console.Title = "KOD1GO";
            string menu = "";
            Console.WriteLine("           _\\|/_\n           (o o)");
            Console.WriteLine("  +----oOO -{_}-OOo---------------------- +");
            Console.WriteLine("  |                                       |");
            Console.WriteLine("  |      Ejercicio POO3 - Menu Opciones   |");
            Console.WriteLine("  |                                       |");
            Console.WriteLine("  |   Libros ------------------------- 1  |");
            Console.WriteLine("  |   Restaurante -------------------- 2  |");
            Console.WriteLine("  |   Salir -------------------------- 3  |");
            Console.WriteLine("  |                                       |");
            Console.WriteLine("  +---------------------------------------*");
            menu = Console.ReadLine();

            switch (menu)
            {
                case "1":
                    ShowBooks();
                    break;
                case "2":
                    ShowInvoice();
                    break;               
            }
            Console.Write("Presione cualquier tecla para continuar...");
            Console.ReadKey();           
           
        }
        static void addBook() {
            string[,] books = { { "Luz Negra", "Alvaro Menen Deslead" }, { "Narraciones Extraordinarias", "Edgar Allan Poe" },
                { "Fiebre Oscura","Karen Marie Moning" }, {"El señor de los anillos","J.R.R Tolkien" }, {"Harry Potter","J.K Rowling" } };
            int[] pages = {70,170,167,521,146 };
            for (int i = 0; i < 5; i++) {
                book = new Book();
                book.Title = books[i,0];
                book.Author = books[i,1];
                book.Pages = pages[i];
                book.Qualification = i + 6;
                setBooks.AddBook(book);

            }
        }
        static void Button(int x, int y, string type, int color)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(" _______________");
            Console.SetCursorPosition(x, y + 1);
            Console.Write("|");
            if (color == 1) Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Write("  {0}  ", type);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("|");
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine(" ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");


        }
        static void ButtonMenu(int y) {
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.RightArrow)
                {
                    if (initial_position > 1) initial_position = 0;
                    initial_position += 1;

                }
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    if (initial_position < 1) initial_position = 2;
                    initial_position -= 1;
                }
                if (initial_position == 1)
                {
                    Button(15, y, " + Agregar ", 1);
                    Button(45, y, "  x Salir  ", 0);

                }
                else
                {
                    Button(15, y, " + Agregar ", 0);
                    Button(45, y, "  x Salir  ", 1);
                }

            } while (key.Key != ConsoleKey.Enter);
            Console.SetCursorPosition(5, 13);
            if (initial_position == 1)
            {
            }
        }
        static void DeleteButton(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("                 ");
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine("                 ");
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine("                 ");

        }
        static void ShowBooks() {
            initial_position = 1;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("                     MI LISTA DE LIBROS LEIDOS  -  KODIGO\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("     #  Titulo  \t\t\t Autor\t\t\tPagina\t Calificacion");
                Console.ForegroundColor = ConsoleColor.Gray;

                setBooks.ShowBooks();
                Button(15, setBooks.index + 4, " + Agregar ", 1);
                Button(45, setBooks.index + 4, "  x Salir  ", 0);
                ButtonMenu(setBooks.index + 4);
                if (initial_position == 1)
                {
                    DeleteButton(15, setBooks.index + 4);
                    DeleteButton(45, setBooks.index + 4);
                    book = new Book();
                    Console.SetCursorPosition(5, setBooks.index + 3);
                    Console.WriteLine("{0}.", setBooks.index + 1);

                    Console.SetCursorPosition(8, setBooks.index + 3);
                    book.Title = Console.ReadLine();
                    Console.SetCursorPosition(41, setBooks.index + 3);
                    book.Author = Console.ReadLine();
                    Console.SetCursorPosition(65, setBooks.index + 3);
                    book.Pages = int.Parse(Console.ReadLine());
                    Console.SetCursorPosition(76, setBooks.index + 3);
                    book.Qualification = int.Parse(Console.ReadLine());
                    setBooks.AddBook(book);
                }
            } while (initial_position == 1 && setBooks.index < 10);
        }
        static void ShowInvoice() {
            Invoice invoice = new Invoice();
            DateTime dateTime= DateTime.Now;
            Order order;
            int idWaiter;
            int initial = 7;
            Random random = new Random();

            Console.Clear();
            Console.WriteLine("                     LACA LACA MULTIPLAZA");
            Console.WriteLine("                       TAQUERIA MEXICANA\n");
           
            invoice.Number = 110899;
            Console.WriteLine("     CUENTA  {0}", invoice.Number);
            idWaiter = random.Next(5);
            Console.Write("     MESERO  {0}",idWaiter+1);
            Console.SetCursorPosition(35, 3);
            Console.Write("MESA ");
            Console.SetCursorPosition(35, 4);
            Console.Write("PERSONAS ");

            Console.SetCursorPosition(45, 3);
            invoice.NumTable = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(45, 4);
            invoice.NumPersons = int.Parse(Console.ReadLine());
            Console.Write("\n     CANTIDAD \t\t CONCEPTO\t\t PRECIO");
            initial_position = 1;
            do
            {
                order = new Order();
                Console.SetCursorPosition(8, initial);
                order.Quantity = int.Parse(Console.ReadLine());
                Console.SetCursorPosition(25, initial);
                order.Detail = Console.ReadLine();
                Console.SetCursorPosition(49, initial);
                Console.Write("$");
                order.Price = Convert.ToDouble(Console.ReadLine());
                invoice.AddOrder(order);
                initial++;
                Button(15, invoice._index + 8, " + Agregar ", 1);
                Button(45, invoice._index + 8, "  x Salir  ", 0);
                ButtonMenu(invoice._index + 8);
                DeleteButton(15, invoice._index + 8);
                DeleteButton(45, invoice._index + 8);


            } while (initial_position == 1 && invoice._index < 10);
            Console.Clear();
            double total = (invoice.Total() * .1) + invoice.Total();
            double dollar;
            Console.WriteLine(" Su total es: ${0}",total );
            do
            {
                Console.WriteLine(" Ingrese la cantidad a pagar");
                Console.SetCursorPosition(2, 2);
                dollar = Convert.ToDouble(Console.ReadLine());
            } while (dollar < total);
            if (dollar == total) Console.WriteLine(" Dinero Exacto");
            else Console.WriteLine(" Su vuelto es de ${0}",dollar-total);
            Console.WriteLine(" Generando Ticket... Presione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("       LACA LACA MULTIPLAZA");
            Console.WriteLine("         TAQUERIA MEXICANA\n");
            Console.WriteLine("          ESTADO DE CUENTA");
            Console.WriteLine("          EXIJA SU FACTURA\n");

            Console.WriteLine("     CUENTA  {0}", invoice.Number);
            Console.WriteLine("     MESERO  {0}\n",idWaiter);
            Console.SetCursorPosition(22, 6);
            Console.Write("MESA     {0}", invoice.NumTable);
            Console.SetCursorPosition(22, 7);
            Console.Write("PERSONAS {0}", invoice.NumPersons );
            Console.WriteLine("\n");
            invoice.ShowInvoice();
            Console.WriteLine("             ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
            Console.WriteLine("     SUBTOTAL               {0}", invoice.Total());
            Console.WriteLine("     PROPINA                {0}", invoice.Total()*.1);
            Console.WriteLine("     TOTAL                  {0}", (invoice.Total() * .1)+invoice.Total());
            Console.WriteLine("\n         {0}", invoice.SearchWaiter(idWaiter));
            Console.WriteLine("             {0}", dateTime);             

        }
       
    }

}
