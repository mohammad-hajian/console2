using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileXml_GenericInterface
{
    [Serializable]
    public class Person
    {
        public Person()
        {

        }
        public Person(string name, string family)
        {
            Name = name;
            Family = family;
        }
        public string Name { get; set; }
        public string Family { get; set; }
        public override string ToString()
        {
            return string.Format($"name : {Name} , family : {Family}"); 
        }
    }
}
