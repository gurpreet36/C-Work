using phonebook.Models;
using System;
using System.Linq;

namespace phonebook.Service
{
    public class Services
    {
        PhonebookDbContext phonebookDbContext=new PhonebookDbContext();
        public void fetchPoduct(int a)                      //function for fetching data
        {
            var productss = phonebookDbContext.PhoneBooks.Where(s => s.Id== a).FirstOrDefault<PhoneBook>();
            Console.WriteLine(productss.Name);
        }
        public void insertProduct(PhoneBook phoneBook)
        {
            phonebookDbContext.Add(phoneBook);
            phonebookDbContext.SaveChanges();
            Console.WriteLine("Insert successfully");
        }
        public void updateProduct(int ID,string n)
        {
            var phnobk =phonebookDbContext.PhoneBooks.Where(s => s.Id == ID).FirstOrDefault<PhoneBook>();
            phnobk.Name=n;
            phonebookDbContext.SaveChanges();
            Console.WriteLine("Update successfully !!!!");
        }
        public void deleteProduct(int id)
        {
             var phnobk = phonebookDbContext.PhoneBooks.Where(s => s.Id == id).FirstOrDefault<PhoneBook>();
            PhoneBook phoneBook=new PhoneBook();
            phonebookDbContext.Remove(phnobk);
            phonebookDbContext.SaveChanges();
            Console.WriteLine("data deleted successfully");

        }
        
    }
}
