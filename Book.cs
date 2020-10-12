using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO3
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public int Qualification { get; set; }

        public Book()
        {
        }

        public Book(string title, string author, int pages, int qualification)
        {
            Title = title;
            Author = author;
            Pages = pages;
            Qualification = qualification;
        }

        public override string ToString()
        {
            string tabs;
            string tab = "";
            if (Title.Length < 15) tabs = "\t\t\t";
            else
            {
                if (Title.Length < 19) tabs = "\t\t";
                else tabs = "\t";
            }
            if (Author.Length<15) tab = "\t";
            return string.Format("{0} {1} {2} {3}\t {4}\t    {5}/10", Title,tabs,Author,tab,Pages,Qualification);
        }
    }
}
