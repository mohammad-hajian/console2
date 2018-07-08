using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            person person1 = new person(22, "mohsen", enamezdevaj.mojarad);
            teacher teacher1 = new teacher(90, 27, "ali", enamezdevaj.moteahel);
            student student1 = new student(94, 21, "mohammad", enamezdevaj.mojarad);
            Console.WriteLine(person1.display());
            Console.WriteLine(teacher1.display()); 
            Console.WriteLine(student1.display()); 

            Console.WriteLine("----------------------");
            person[] p1 = new person[]
            {
                new person(22,"mohsen",enamezdevaj.mojarad),new student(94,21,"mohammad",enamezdevaj.mojarad)
                ,new teacher(90,27,"ali",enamezdevaj.moteahel)
            };
            #region یا از روش زیر
            //person[] p2 = new person[3];
            //p2[0] = new person(21, "mohammad", enamezdevaj.mojarad);
            //p2[1] = new student(94, 21, "mohammad", enamezdevaj.mojarad);
            //p2[3] = new teacher(90, 27, "ali", enamezdevaj.moteahel);
            #endregion یا از روش زیر

            
            foreach (person p in p1)
            {
                Console.WriteLine(p.display());
            }
        }
    }
}
