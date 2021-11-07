using System;


namespace Application
{
    class Program
    {
        public static void Main()
        {
           Console.WriteLine("Enter EmpId :");
           int eid=Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Enter EmpName :");
           string eName=Console.ReadLine();
           var data=new Models{
               EmpId=eid,
               EmpName=eName
           };
           var service=new Crud_List();
            lable:
            Console.WriteLine("Enter the Choice Acc to CRUD");
           int ch=Convert.ToInt32(Console.ReadLine());
          
                switch (ch)
                {
                    case 1:
                            var a=service.CreateData(data);
                            Console.WriteLine(a);
                            break;
                    case 2:
                            Console.WriteLine(service.removeData(0));
                            break;
                    case 3:
                            Console.WriteLine(service.updateData(0,data));
                            break;
                    case 4:
                                service.displayData();
                                break;
                    default:
                                Console.WriteLine("Invalid Input ....");
                                break;
                }
            goto lable;
        }
    }
}
