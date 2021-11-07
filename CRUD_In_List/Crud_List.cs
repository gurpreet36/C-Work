using System;
using System.Collections.Generic;

namespace Application
{
    public class Crud_List
    {
        
        List<Models> data=new List<Models>();   
        public string CreateData(Models models)
        {
            data.Add(models);
            return "Data Entered Successfully";
        }
        public string  removeData(int i)
        {
            data.RemoveAt(i);
            return "Deleted Sucessfully";
        }
        public string updateData(int i,Models models)
        {
            var temp= data[i];
            temp.EmpId=models.EmpId;
            temp.EmpName=models.EmpName;
            return "data Update Successfully";
        }
        public void displayData()
        {
            foreach(var i in data)
            {
                Console.WriteLine(i.EmpId +" "+i.EmpName);
            }
        }

    }
}