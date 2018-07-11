using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritOverride
{
    enum enamezdevaj
    {
        mojarad = 1, moteahel, bive
    }
    class person
    {
        public person()
        {
        }
        public person(int age, string fullName, enamezdevaj ezdevaj)
        {
            Age = age;
            FullName = fullName;
            Ezdevaj = ezdevaj;
        }
        public int Age { get; set; }
        public string FullName { get; set; }
        public enamezdevaj Ezdevaj { get; set; }
        public virtual string display()
        {
            return ($"\n person :\n  FullName: {FullName} \n Age: {Age} \n ezdevaj:{Ezdevaj} ");
        }
    }
}
