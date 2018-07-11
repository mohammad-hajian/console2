using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IEnumerabl
{
    class CelasArrays : IEnumerable
    {
        public CelasArrays()
        {
            Cla1[0] = new CelasArray("mohammad", "hajian");
            Cla1[1] = new CelasArray("mahdi", "hajian");
            Cla1[2] = new CelasArray("javad", "hajian");
        }
        CelasArray[] Cla1 = new CelasArray[3];


        public IEnumerator GetEnumerator()
        {
            foreach (var item in Cla1)
            {
                yield return item;
            }
            //or
            //yield return Cl1[0];
            //yield return Cl1[1];
            //yield return Cl1[2];
        }
        public string PrArr()
        {
            string Temp = string.Empty;
            foreach (CelasArray item in this)
            {
                Temp += string.Format($"{item}\r\n");
            }
            return Temp;
        }
    }
}
