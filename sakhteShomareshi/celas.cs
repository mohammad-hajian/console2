using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace sakhteShomareshi 
{
    class Celas : IEnumerable 
    {
        public Celas()
        {
        }
        public IEnumerator GetEnumerator()
        {
            string[] Str1 = new string[] { "1", "2", "3" };
            foreach (var StrCelas in Str1)
            {
                yield return StrCelas;
            }
            //or
            //yield return "1";
            //yield return "2";
            //yield return "3";
        }
    }
}
