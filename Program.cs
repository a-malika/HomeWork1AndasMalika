using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        //Тестирование системы
        static void Main(string[] args)
        {
            //Создание библиотеки, книг и читателей
            Library CentralLibrary = new Library();
            Book book0 = new Book("Дневник памяти", "Николас Спаркс", "978-5-17-093757-8");
            Book book1 = new Book("Книга чая", "Окакура Какудзо", "978-5-17-145717-4");
            Book book2 = new Book("Былое и думы", "Александр Герцен", "978-5-17-148325-8");
            Reader reader0 = new Reader("Мэри Кьюри");
            Reader reader1 = new Reader("Энн Тодд");
            Reader reader2 = new Reader("Томас Джеферсон");
            Reader reader3 = new Reader("Питер Корн");
            //Добавление книг и читателей в библиотеку
            CentralLibrary.addBook(book0, 12);
            CentralLibrary.addBook(book1);
            CentralLibrary.addBook(book2, 8);
            CentralLibrary.addReader(reader0);
            CentralLibrary.addReader(reader1);
            CentralLibrary.addReader(reader2);
            CentralLibrary.addReader(reader3);
            //Выдача книг читателям
            CentralLibrary.giveTheBookToReader(book1, reader0);
            CentralLibrary.giveTheBookToReader(book0, reader2);
            CentralLibrary.giveTheBookToReader(book1, reader1);
            //Удаления читателя и книги
            CentralLibrary.deleteReader(reader3);
            CentralLibrary.deleteBook(book0, 3);
            //Возврат книги
            CentralLibrary.returnTheBookToLibrary(book1, reader1);
            CentralLibrary.returnTheBookToLibrary(book1, reader0);
            CentralLibrary.returnTheBookToLibrary(book1, reader2);
        }
    }
}
