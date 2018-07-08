using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritCast
{
    class teacher :person
    {
        public int Tid { get; set; }
        public teacher()
        {
        }
        public teacher(int tid, int age, string fullName, enamezdevaj ezdevaj) : base(age, fullName, ezdevaj)
        {
            Tid = tid;
        }
        public override void display()
        {
            Console.WriteLine($"\n teacher : \n FullName: {FullName} \n Age: {Age} \n Tid:{Tid}\n ezdevaj:{Ezdevaj} ");
        }
    }
}
