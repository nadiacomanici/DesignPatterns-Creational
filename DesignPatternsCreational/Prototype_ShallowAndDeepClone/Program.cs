using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype_ShallowAndDeepClone.Classes;

namespace Prototype_ShallowAndDeepClone
{
    class Program
    {
        static void Main(string[] args)
        {
            var author = new Author("Nadia", "Comanici");
            var book = new Book("Curs C#", author);
            Console.WriteLine($"Book (initial): {book.Title} by: {book.Author.FirstName}  {book.Author.LastName}");

            var clonedBook = book.Clone() as Book;
            Console.WriteLine($"Book (shallow): {clonedBook.Title} by: {clonedBook.Author.FirstName}  {clonedBook.Author.LastName}");

            var deepClonedBook = book.DeepClone();
            Console.WriteLine($"Book (deep): {deepClonedBook.Title} by: {deepClonedBook.Author.FirstName}  {deepClonedBook.Author.LastName}");

            Console.WriteLine("Update first name...");
            book.Author.FirstName = "NADINA";

            Console.WriteLine($"Book (initial): {book.Title} by: {book.Author.FirstName}  {book.Author.LastName}");
            Console.WriteLine($"Book (shallow): {clonedBook.Title} by: {clonedBook.Author.FirstName}  {clonedBook.Author.LastName}");
            Console.WriteLine($"Book (deep): {deepClonedBook.Title} by: {deepClonedBook.Author.FirstName}  {deepClonedBook.Author.LastName}");
        }
    }
}
