using System;

namespace AddressProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите индекс: ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите страну: ");
            string country = Console.ReadLine();
            Console.WriteLine("Введите город: ");
            string city = Console.ReadLine();
            Console.WriteLine("Введите улицу: ");
            string street = Console.ReadLine();
            Console.WriteLine("Введите дом: ");
            int house = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите квартиру: ");
            int apartment = Convert.ToInt32(Console.ReadLine());

            Address address = new Address();
            address.Index = index;
            address.Country = country;
            address.City = city;
            address.Street = street;
            address.House = house;
            address.Apartment = apartment;

            Console.WriteLine("Посылка отправлена по адресу: " 
                + address.Index + " "
                + address.Country + " "
                + address.City + " "
                + address.Street + " "
                + address.House + " "
                + address.Apartment);

            Console.ReadKey();
        }
    }
}
