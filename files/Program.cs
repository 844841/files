using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;  //must add this directory

namespace files
{
    class Program
    {
        static void Main(string[] args)
        {

            String path = @"D:\hai.txt";
            if (!File.Exists(path))
            {
                //create a file to write to
                using (StreamWriter sw = File.CreateText(path))
                {
                    Console.WriteLine("enter name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("enter city:");
                    string city = Console.ReadLine();
                    Console.WriteLine("enter id:");
                    string id = Console.ReadLine();
                    sw.WriteLine("name is " + name);
                    sw.WriteLine("city is " + city);
                    sw.WriteLine("id is " + id);
                    //sw.Flush();
                }
            }

            //open the file to read from
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s=sr.ReadLine())!=null)
                    {
                    Console.WriteLine(s);
                }
                //sr.ReadToEnd(); //read all the data from stream

                File.Delete(path);   //deleting a file
            }




        }
    }
}
  
