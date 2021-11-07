using System;
using phonebook.Models;
using phonebook.Service;
namespace phonebook
{
    class Program
    {
        public static void Main()
        {
            Services service = new Services();
            Console.WriteLine("enter your choice fUID:-");
            int ch = Convert.ToInt32(Console.ReadLine());
            int b;
            PhoneBook phoneBook = new PhoneBook();
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter Id :-");
                    b = Convert.ToInt32(Console.ReadLine());
                    service.fetchPoduct(101);
                    break;
                case 2:
                    Console.WriteLine("Enter Id :");
                    phoneBook.Id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Name :");
                    phoneBook.Name = Console.ReadLine();
                    service.updateProduct(phoneBook.Id, phoneBook.Name);
                    break;
                case 3:
                    Console.WriteLine("Enter Id :");
                    phoneBook.Id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Name :");
                    phoneBook.Name = Console.ReadLine();
                    Console.WriteLine("Enter Phno :");
                    phoneBook.Phno = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Addr :");
                    phoneBook.Address = Console.ReadLine();
                    service.insertProduct(phoneBook);
                    break;
                case 4:
                    Console.WriteLine("Enter Id :-");
                    b = Convert.ToInt32(Console.ReadLine());
                    service.deleteProduct(b);
                    break;
                default:
                    break;
            }
        }
    }
}
