using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IEnumerabl
{
    class Metod
    {
        public IEnumerable Test()
        {
            string[] Str1 = new string[] { "4", "5", "6" };
            foreach (string StrMetod in Str1)
            {
                yield return StrMetod;
            }
            //or
            //yield return "4";
            //yield return "5";
            //yield return "6";
            
        }
        public string PrMetod()
        {
            string Temp = string.Empty;
            foreach (string item in Test())
            {
                Temp += string.Format($"{item}\n");
            }
            return Temp;
        }
    }                                     
}
