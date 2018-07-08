using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFace
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] o1 = new object[]
            {
                new person(),new teacher(),new student()
            };
            foreach (IFace o in o1)
            {
                Console.WriteLine(o.Test());
            }
        }
    }
}
