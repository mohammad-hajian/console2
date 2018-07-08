using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritCast
{
    class Program
    {
        static void Main(string[] args)
        {
            teacher teacher1 = new teacher(25857,27,"mohammad",enamezdevaj.moteahel);
            student student1 = new student(5547, 15, "ali", enamezdevaj.mojarad);
            teacher1.display();
            student1.ShowStudent();
        }
    }
}
