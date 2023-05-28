using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portafolio_09_LuisRodriguez
{
    public class Book
    {
        private int id;
        private string author;
        private string gender;
        private string synopsis;
        private int pages;
        private string language;
        private DateTime publication;
        private string publisher;
        private bool availability;

        public int Id { get => id; set => id = value; }
        public string Author { get => author; set => author = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Synopsis { get => synopsis; set => synopsis = value; }
        public int Pages { get => pages; set => pages = value; }
        public string Language { get => language; set => language = value; }
        public DateTime Publication { get => publication; set => publication = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public bool Availability { get => availability; set => availability = value; }

        public Book(string newSynopsis)
        {
            id = 0;
            author = "Unknown";
            gender = "Unknown";
            synopsis = newSynopsis;
            pages = 20;
            language = "Español";
            publication = DateTime.Now;
            publisher = "Editorial_1";
            availability = true;
        }

        public Book(string id, string author, string gender, string synopsis, int pages, string language, DateTime publication, string publisher, bool availability)
        {
            this.id = int.Parse(id);
            this.author = author;
            this.gender = gender;
            this.synopsis = synopsis;
            this.pages = pages;
            this.language = language;
            this.publication = publication;
            this.publisher = publisher;
            this.availability = availability;
        }

        public Book(string id, string author, string gender)
        {
            this.id = int.Parse(id);
            this.author = author;
            this.gender = gender;
        }

        public string GetFullInformation()
        {
            return $"Author: {author}\nGender: {gender}\nSynopsis: {synopsis}\n" +
                   $"Pages: {pages}\nLanguage: {language}\nPublication: {publication}\n" +
                   $"Publisher: {publisher}\nAvailability: {availability}";
        }

        public List<string> GetAttributes()
        {
            List<string> attributes = new List<string>();
            attributes.Add(id.ToString());
            attributes.Add(author);
            attributes.Add(gender);
            return attributes;
        }

        public void ModifyAttributes(string newAuthor, string newGender, string newSynopsis, int newPages, string newLanguage, DateTime newPublication, string newPublisher, bool newAvailability)
        {
            author = newAuthor;
            gender = newGender;
            synopsis = newSynopsis;
            pages = newPages;
            language = newLanguage;
            publication = newPublication;
            publisher = newPublisher;
            availability = newAvailability;
        }

        public void ModifyAttributes(string newAuthor, string newGender, string newSynopsis)
        {
            author = newAuthor;
            gender = newGender;
            synopsis = newSynopsis;
        }

        public void PrintInformation()
        {
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Publisher: {publisher}");
            Console.WriteLine($"Availability: {availability}");
        }

        public void ModifyNumberPages(int newPages)
        {
            pages = newPages;
        }

        public void ModifyNumberPages(string newPages)
        {
            pages = int.Parse(newPages);
        }

    }
}