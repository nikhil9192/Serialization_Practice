using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Serialization

            // string path = @"C:\Users\NIKHIL SINGH\source\repos\Serialization_Practice\Serialization_Practice\bin\Debug\Student.txt";
            //  FileStream stream= new FileStream(path,FileMode.OpenOrCreate);
            //   Student st1=new Student(12,"Nikhil Singh");
            //  BinaryFormatter bf=new BinaryFormatter();
            //  bf.Serialize(stream,st1);
            //   stream.Close();
            //   Console.WriteLine("Sucessfull Enter =>  " +path);

            //Deserialization 

            string path = @"C:\Users\NIKHIL SINGH\source\repos\Serialization_Practice\Serialization_Practice\bin\Debug\Student.txt";
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
          
            Student s1 =(Student)bf.Deserialize(stream);
            Console.WriteLine("Student id is :"+ s1.ID);
            Console.WriteLine("Student name is :" + s1.Name);
            stream.Close();
            Console.ReadLine();
        }
    }
}
