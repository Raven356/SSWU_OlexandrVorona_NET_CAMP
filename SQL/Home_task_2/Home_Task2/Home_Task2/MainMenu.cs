using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task2
{
    internal class MainMenu
    {
        private MainMenu() { }
        public static void ChooseOperation(IInterfaceWorker interfaceWorker, Model1Container modelContext)
        {
            while (true)
            {
                try
                {
                    interfaceWorker.Write("Choose what to do:\n1) Create\n2) Update\n" +
                        "3) Read\n4) Delete\n5) Exit");
                    int choiceOperation = int.Parse(interfaceWorker.Read());

                    if (choiceOperation == 5)
                        return;
                    int choiceTable;

                    while (true)
                    {
                        interfaceWorker.Write("Choose table for operations: 1) Books 2) Genre 3) Publisher");
                        choiceTable = int.Parse(interfaceWorker.Read());
                        if (choiceTable > 0 && choiceTable < 4)
                        {
                            break;
                        }
                        interfaceWorker.Write("Try again!");
                    }

                    string answer = "";
                    string[] split = new string[0];
                    interfaceWorker.Clear();
                    switch (choiceOperation)
                    {
                        case 1:
                            Create(choiceTable, answer, split, modelContext, interfaceWorker);
                            modelContext.SaveChanges();
                            break;
                        case 2:
                            Read(choiceTable, answer, split, modelContext, interfaceWorker);
                            Update(choiceTable, answer, split, modelContext, interfaceWorker);
                            modelContext.SaveChanges();
                            break;
                        case 3:
                            Read(choiceTable, answer, split, modelContext, interfaceWorker);
                            break;
                        case 4:
                            Read(choiceTable, answer, split, modelContext, interfaceWorker);
                            Delete(choiceTable, modelContext, interfaceWorker);
                            modelContext.SaveChanges();
                            break;
                        default:
                            interfaceWorker.Write("Try again!");
                            break;
                    }
                }
                catch(Exception ex)
                {
                    interfaceWorker.Write(ex.Message);
                }
               
            }
        }

        private static string Operation(IInterfaceWorker interfaceWorker, string text)
        {
            interfaceWorker.Write(text);
            return interfaceWorker.Read();
        }

        private static void Delete(int choiceTable, Model1Container modelContext, IInterfaceWorker interfaceWorker)
        {
            interfaceWorker.Write("Enter Id of element which tou want to delete");
            int id = int.Parse(interfaceWorker.Read());
            switch (choiceTable)
            {
                case 1:
                    modelContext.BooksSet.Remove(modelContext.BooksSet.Where(x => x.Id == id).First());
                    break;
                case 2:
                    modelContext.GenreSet.Remove(modelContext.GenreSet.Where(x => x.Id == id).First());
                    break;
                case 3:
                    modelContext.PublisherSet.Remove(modelContext.PublisherSet.Where(x => x.Id == id).First());
                    break;
            }
        }

        private static void Read(int choiceTable, string answer, string[] split, Model1Container modelContext, IInterfaceWorker interfaceWorker)
        {
            switch (choiceTable)
            {
                case 1:
                    foreach (var item in modelContext.BooksSet)
                    {
                        interfaceWorker.Write($"{item.Id}, {item.Name}, {item.YearOfCreation}, {item.Amount}, {item.Genre.Name}, {item.Publisher.Name}\n");
                    }
                    break;
                case 2:
                    foreach (var item in modelContext.GenreSet)
                    {
                        interfaceWorker.Write($"{item.Id}, {item.Name}\n");
                    }
                    break;
                case 3:
                    foreach (var item in modelContext.PublisherSet)
                    {
                        interfaceWorker.Write($"{item.Id}, {item.Name}, {item.ContactPhone}, {item.ContactMail}\n");
                    }
                    break;
            }
        }

        private static void Update(int choiceTable, string answer, string[] split, Model1Container modelContext, IInterfaceWorker interfaceWorker)
        {
            int id;
            switch (choiceTable)
            {
                case 1:

                    answer = Operation(interfaceWorker, "Enter book info in format: id, name, Date of creation, Amount, Publisher, Genre");
                    split = answer.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                    id = int.Parse(split[0]);
                    string pubName = split[4];
                    string genreName = split[5];

                    Books books = modelContext.BooksSet.Where(x => x.Id == id).FirstOrDefault();
                    if (books == null)
                    {
                        throw new ArgumentException("No such element!");
                    }

                    books.Name = split[1];
                    books.YearOfCreation = DateTime.Parse(split[2]);
                    books.Amount = int.Parse(split[3]);
                    books.PublisherId = modelContext.PublisherSet.Where(x => x.Name.Equals(pubName)).First().Id;
                    books.GenreId = modelContext.GenreSet.Where(x => x.Name.Equals(genreName)).First().Id;
                    modelContext.BooksSet.AddOrUpdate();

                    break;
                case 2:
                    answer = Operation(interfaceWorker, "Enter genre info in format: id, Genre");
                    split = answer.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                    id = int.Parse(split[0]);

                    Genre genre = modelContext.GenreSet.Where(x => x.Id == id).FirstOrDefault();
                    if (genre == null)
                        throw new ArgumentException("No such element!");

                    genre.Name = split[1];
                    modelContext.GenreSet.AddOrUpdate();

                    break;
                case 3:
                    answer = Operation(interfaceWorker, "Enter publisher info in format: id, name, contact phone, contact mail");
                    split = answer.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                    id = int.Parse(split[0]);

                    Publisher publisher = modelContext.PublisherSet.Where(x => x.Id == id).FirstOrDefault();
                    if (publisher == null)
                        throw new ArgumentException("No such element!");
                    publisher.Name = split[1];
                    publisher.ContactPhone = split[2];
                    publisher.ContactMail = split[3];
                    modelContext.PublisherSet.AddOrUpdate();

                    break;
            }
        }

        private static void Create(int choiceTable, string answer, string[] split, Model1Container modelContext, IInterfaceWorker interfaceWorker)
        {
            switch (choiceTable)
            {
                case 1:
                    answer = Operation(interfaceWorker, "Enter book info in format: name, Date of creation, Amount, Publisher, Genre");
                    split = answer.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                    string pubName = split[3];
                    string genreName = split[4];

                    modelContext.BooksSet.Add(new Books
                    {
                        Name = split[0],
                        YearOfCreation = DateTime.Parse(split[1]),
                        Amount = int.Parse(split[2]),
                        PublisherId = modelContext.PublisherSet.Where(x => x.Name.Equals(pubName)).First().Id,
                        GenreId = modelContext.GenreSet.Where(x => x.Name.Equals(genreName)).First().Id
                    });

                    break;
                case 2:
                    answer = Operation(interfaceWorker, "Enter genre info in format: Genre");
                    modelContext.GenreSet.Add(new Genre { Name = answer });
                    break;
                case 3:
                    answer = Operation(interfaceWorker, "Enter publisher info in format: name, contact phone, contact mail");
                    split = answer.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                    modelContext.PublisherSet.Add(new Publisher { Name = split[0], ContactPhone = split[1], ContactMail = split[2] });
                    break;
            }

        }
    }
}
