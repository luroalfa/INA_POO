using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Portfolio_09_LuisRodriguez
{
    public class Client
    {
        private string name;
        private int age;
        private string address;
        private string email;
        private string phone;
        private bool isPremium;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public bool IsPremium
        {
            get { return isPremium; }
            set { isPremium = value; }
        }

        public Client()
        {
            
        }

        public Client(string name, int age, string address, string email, string phone, bool isPremium)
        {
            this.name = name;
            this.age = age;
            this.address = address;
            this.email = email;
            this.phone = phone;
            this.isPremium = isPremium;
        }

        public Client(string name, string email)
        {
            this.name = name;
            this.email = email;
        }

        public string GetInformation()
        {
            return $"Name: {name}\nAge: {age}\nAddress: {address}\nEmail: {email}\nPhone: {phone}\nIs Premium: {isPremium}";
        }

        public void UpdateInformation(string newName, int newAge, string newAddress, string newEmail, string newPhone, bool newIsPremium)
        {
            name = newName;
            age = newAge;
            address = newAddress;
            email = newEmail;
            phone = newPhone;
            isPremium = newIsPremium;
        }

        public void UpdateInformation(string newName, string newEmail)
        {
            name = newName;
            email = newEmail;
        }

        public void PrintInformation()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Phone: {phone}");
            Console.WriteLine($"Is Premium: {isPremium}");
        }

        public void PrintInformation(string additionalMessage)
        {
            Console.WriteLine(additionalMessage);
            PrintInformation();
        }
    }
}