using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace HomeWork6._2
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string path = "D:\\study\\visual studio\\c#\\univ\\HomeWork6\\HomeWork6.2\\file.json";

            string json = await File.ReadAllTextAsync(path);

            List<Book> books;

            if (json == null)
            {
                Console.WriteLine("Error: file is empty.");
                return;
            }
            else
            {
                books = JsonSerializer.Deserialize<List<Book>>(json);
            }

            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.PublishingHouseId}, Publisher: {book.PublishingHouse.Name}");
            }
        }
    }
}
