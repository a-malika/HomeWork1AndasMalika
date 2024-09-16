using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    //Класс Library
    public class Library
    {
        public List<Book> books { get; set; }
        public List<Reader> readers { get; set; }
        public Library()
        {
            books = new List<Book>();
            readers = new List<Reader>();
        }
        //Добавить книгу в библиотеку(Можно в разном количестве)
        public void addBook(Book book, int count = 1)
        {
            if (!books.Contains(book)) books.Add(book);
            book.Count += count;
            Console.WriteLine($"Книга '{book.Name}' была добавлена в количестве {count}.");
        }
        //Удалить книгу из библиотеки(Можно в разном количестве)
        public void deleteBook(Book book, int count = 1)
        {
            if (count > books.Count) 
            { 
                Console.WriteLine("В библиотеке недостаточно книг для удаления."); 
                return; 
            }
            if (books.Contains(book))
            {
                book.Count -= count;
                Console.WriteLine($"Книга '{book.Name}' была удалена в количестве {count}.");
            }
            else Console.WriteLine($"Книга '{book.Name}' не была найдена в системе.");
        }
        //Добавить читателя в библиотеку
        public void addReader(Reader reader)
        {
            readers.Add(reader);
            Console.WriteLine($"Читатель {reader.Name} Был добавлен в систему.");
        }
        //Удалить читателя из библиотеки
        public void deleteReader(Reader reader)
        {
            if (readers.Remove(reader)) Console.WriteLine($"Читатель {reader.Name} был удален из системы.");
            else Console.WriteLine($"Читатель {reader.Name} не был найден в системе.");
        }
        //Выдача книги читателю
        public void giveTheBookToReader(Book book, Reader reader)
        {
            if (checkHavingItems(book, reader)) return;
            if (book.Count <= 0) 
            { 
                Console.WriteLine($"Книга '{book.Name}' не доступна на данный момент."); 
                return; 
            }
            reader.addToListOfBooks(book);
            Console.WriteLine($"Книга '{book.Name}' была выдана читателю {reader.Name}.");
        }
        //Возврат книги в библиотеку
        public void returnTheBookToLibrary(Book book, Reader reader)
        {
            if (checkHavingItems(book, reader)) return;
            if (!reader.ListOfBooks.Contains(book)) 
            { 
                Console.WriteLine($"Читатель {reader.Name} не брал книгу '{book.Name}'."); 
                return; 
            }
            reader.removeFromListOfBooks(book);
            Console.WriteLine($"Книга '{book.Name}' Была возвращена в библиотеку читателем {reader.Name}.");
        }
        //Дополнительный метод на проверку наличия читателя и книги в библиотеке
        private bool checkHavingItems(Book book, Reader reader)
        {
            if (!books.Contains(book)) { Console.WriteLine($"Книга '{book.Name}' не была найдена в системе."); return true; }
            if (!readers.Contains(reader)) { Console.WriteLine($"Читатель {reader.Name} не был найден в системе."); return true; }
            return false;
        }
    }
}
