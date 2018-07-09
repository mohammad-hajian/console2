using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IEnumerabl
{
    class Celas : IEnumerable 
    {
        public Celas()
        {
        }
        public IEnumerator GetEnumerator()
        {
            string[] Str1 = new string[] { "12", "2", "3" };
            foreach (string StrCelas in Str1)
            {
                yield return StrCelas;
            }
            //or
            //yield return "1";
            //yield return "2";
            //yield return "3";
        }
        public string Chapkon_3()
        {
            string Temp = string.Empty;
            foreach (string item in this)
            {
                Temp += string.Format($"{item}\n");
            }
            return Temp;
        }
    }
}
