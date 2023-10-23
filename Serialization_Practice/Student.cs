using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_Practice
{
    [Serializable]
    public class Student
    {
      public   int ID;
      public  string Name;
        public Student(int id,string name)
        {
            ID = id;
            Name = name;
        }
    }
}
