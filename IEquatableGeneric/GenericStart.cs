using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEquatableGeneric
{
   public class GenericStart<A>
    {
        public A GetA { get; set; }
        public A Method1(A a)
        {
            return GetA;
        }
        /// <summary>
        /// مقدار خواسته شده را وارد کنید
        /// </summary>
        /// <param name="a"></param>
        public void Method2(A a)
        {
            Console.WriteLine(a);

        }
    }
}
