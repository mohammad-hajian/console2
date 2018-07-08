using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritOverride
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

        public override string display()
        {
           return base.display();//override to father
            //یا بالایی کار میکنه یا پایینی
           return ($"\n teacher :\n  FullName: {FullName} \n Age: {Age} \n Id:{Tid}\n ezdevaj:{Ezdevaj} ");
        }
    }
}
