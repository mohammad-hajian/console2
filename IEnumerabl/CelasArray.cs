using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerabl
{
    class CelasArray 
    {
        public CelasArray()
        {

        }
        public CelasArray(string name,string family)
        {
            Family = family;
            Name = name;
        }
        public string Name { get; set; }
        public string Family { get; set; }

        public override string ToString()
        {
            return string.Format($"name is : {Name} and family is : {Family}");
        }
    }
}
