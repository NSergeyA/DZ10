
using LABWORK.LAB12;
using System;

namespace LABWORK
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 12.1");
            Bankacc account1 = new Bankacc(1000, 1000);
            Bankacc account2 = new Bankacc(1000, 1000);
            Console.WriteLine(account1 == account2 ? ("Аккаунты равны") : ("Аккаунты не равны"));
            Console.WriteLine(account1.Equals(account2) ? ("Аккаунты равны") : ("Аккаунты не равны"));
            Console.WriteLine(account1.GetHashCode());
            Console.WriteLine(account1 != account2 ? ("Аккаунты не равны") : ("Аккаунты равны"));


            Console.WriteLine("Домашнее задание 12.1");
            ComplexNumber num1 = new ComplexNumber(2, 3);
            ComplexNumber num2 = new ComplexNumber(4, -2);

            Console.WriteLine($"Сумма: {num1 + num2}, Разность: {num1 - num2}");
            Console.WriteLine(num1 == num2 ? ("Числа равны") : ("Числа не равны"));


            Console.WriteLine("Домашнее задание 12.2");
            Book book1 = new Book("AКнига1", "CАвтор1", "BИздатель1");
            Book book2 = new Book("CКнига2", "AАвтор2", "BИздатель2");
            Book book3 = new Book("BКнига3", "CАвтор3", "AИздатель3");
            Book[] books = { book1, book2, book3 };
            // Критерий сортировки по названию
            Comparison<Book> titleComparison = (b1, b2) => b1.Title.CompareTo(b2.Title);
            // Критерий сортировки по автору
            Comparison<Book> authorComparison = (b1, b2) => b1.Author.CompareTo(b2.Author);
            // Критерий сортировки по издательству
            Comparison<Book> publisherComparison = (b1, b2) => b1.Publisher.CompareTo(b2.Publisher);
            Bookcontainer container = new Bookcontainer(books);


            container.SortBooks(titleComparison);
            Console.WriteLine("Сортировка по названию:");
            container.PrintBooks();
            Console.WriteLine();

            container.SortBooks(authorComparison);
            Console.WriteLine("Сортировка по автору:");
            container.PrintBooks();
            Console.WriteLine();

            container.SortBooks(publisherComparison);
            Console.WriteLine("сортировка по издательству:");
            container.PrintBooks();




        }
    }
}
