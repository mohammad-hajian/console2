using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace test
{
    class shomare : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return "mohammad";
            yield return "mahdi";
            yield return "mohammad";
        }
    }
    class Program000
    {
        static void Main(string[] args)
        {
            shomare S1 = new shomare();
            foreach (var item in S1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
