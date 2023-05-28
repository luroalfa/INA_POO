using Portfolio_09_LuisRodriguez;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portafolio_09_LuisRodriguez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Amigos exploran un sanatorio abandonado, enfrentando presencias aterradoras y secretos oscuros. Luchan por sobrevivir y escapar.");
            Console.WriteLine("Información del Libro 1:");
            Console.WriteLine(book1.GetFullInformation());

            Console.WriteLine();

            Book book2 = new Book("1", "Juan Pérez", "Misterio", "Una emocionante novela de misterio", 250, "Español", new DateTime(2022, 10, 15), "Editorial XYZ", true);
            Console.WriteLine("Información del Libro 2:");
            Console.WriteLine(book2.GetFullInformation());

            Console.WriteLine();

            book2.Id = 2;
            book2.Author = "María Gómez";
            book2.Gender = "Romance";
            book2.Synopsis = "Una cautivadora novela romántica";
            book2.Pages = 300;
            book2.Language = "Español";
            book2.Publication = new DateTime(2023, 5, 20);
            book2.Publisher = "Editorial ABC";
            book2.Availability = false;

            Console.WriteLine("Información actualizada del Libro 2:");
            Console.WriteLine(book2.GetFullInformation());

            Console.WriteLine();

            Console.WriteLine("Autor del Libro 2: " + book2.Author);
            Console.WriteLine("Género del Libro 2: " + book2.Gender);

            Console.WriteLine();

            book2.ModifyAttributes("Otro Autor", "Otro Género", "Otra Sinopsis", 300, "Francés", DateTime.Now, "Editorial 2", true);

            Console.WriteLine("Información modificada del Libro 2:");
            Console.WriteLine(book2.GetFullInformation());

            Console.WriteLine();

            book2.PrintInformation();

            Console.WriteLine();

            book2.ModifyNumberPages(250);            

            Book book3 = new Book("2", "Autor 2", "Género 2");
            Console.WriteLine("Páginas del Libro 2: " + book2.Pages);
            Console.WriteLine("Información del Libro 2:");
            Console.WriteLine(book3.GetFullInformation());

            Console.WriteLine();

            Client client1 = new Client("Jose", 30, "Alajuela", "jose@example.com", "70564889", true);
            Client client2 = new Client("Javier", "javi@example.com");

            Console.WriteLine("Informacion de los clientes:");
            Console.WriteLine(client1.GetInformation());
            Console.WriteLine(client2.GetInformation());

            client1.UpdateInformation("Gabi", 35, "San Jose", "gabi@example.com", "987654321", false);
            client2.UpdateInformation("Derick", "derick@example.com");

            Console.WriteLine("Informacion actualizada:");
            client1.PrintInformation();
            client2.PrintInformation("Cliente premium");

            Client client3 = new Client("Claudio", 25, "Guanacaste", "claudio@example.com", "555555555", true);

            Console.WriteLine("Informacion del cliente 3:");
            client3.PrintInformation();
            client3.PrintInformation("Cliente de muy buena paga, deja propina.");

            client3.UpdateInformation("Juan", "juan@example.com");
            Console.WriteLine("Actualizacion del cliente 3:");
            client3.PrintInformation();

            client3.UpdateInformation("Pablo", 28, "Limon", "pablo@example.com", "555555555", false);
            Console.WriteLine("Informacion actualizada cliente 3:");
            client3.PrintInformation();
            Console.ReadLine();
        }
    }
}
