using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    //Класс Reader
    public class Reader
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public List<Book> ListOfBooks { get; set; }
        private static int id_counter = 0;
        public Reader(string name)
        {
            Name = name;
            ID = id_counter++;
            ListOfBooks = new List<Book>();
        }
        //Добавить книгу в список книг читателя
        public void addToListOfBooks(Book book)
        {
            book.Count -= 1;
            ListOfBooks.Add(book);
        }
        //Удалить книгу из списка книг читателя
        public void removeFromListOfBooks(Book book)
        {
            book.Count += 1;
            ListOfBooks.Remove(book);
        }
    }
}
