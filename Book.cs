using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    //Класс Book
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int Count { get; set; } = 0;
        public Book(string name, string author, string isbn)
        {
            Name = name;
            Author = author;
            ISBN = isbn;
        }
    }
}
