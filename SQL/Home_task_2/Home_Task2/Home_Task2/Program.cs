using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu.ChooseOperation(new ConsoleWorker(), new Model1Container());
            //Genre genre = new Genre { Name = "Genre2" };
            //Publisher publisher = new Publisher { Name = "Publisher2", 
            //    ContactPhone = "+380000000", ContactMail = "test2@gmail.com" };
            //Books books = new Books { 
            //    Name = "Book2",
            //    YearOfCreation = DateTime.Now,
            //    Amount = 10,
            //    PublisherId = 1,
            //    GenreId = 1
            //};

            //Model1Container modelContext = new Model1Container();
            ////modelContext.GenreSet.Add(genre);
            //modelContext.GenreSet.Where(x => x.Name == "Genre3").First().Name = "Genre2";
            //modelContext.GenreSet.AddOrUpdate();
            ////genre.Id = 2;
            ////modelContext.GenreSet.RemoveRange(modelContext.GenreSet.Where(x => x.Name == "Genre2"));
            
            ////modelContext.PublisherSet.Add(publisher);
            ////modelContext.BooksSet.Add(books);
            //modelContext.SaveChanges();
        }
    }
}
