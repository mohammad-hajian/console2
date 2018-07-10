using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEquatableGeneric
{
    class Program4
    {
        static void Main(string[] args)
        {
            Persen P1 = new Persen("mohammad","hajian");
            Persen P2 = new Persen("mohammad", "hajian");

            Console.WriteLine(P1.Equals(P2));

            Console.WriteLine(P1==P2);//کردیم Equals() بود که بر حسب  GetHashCode() بر حسب 
            Console.WriteLine(P1.GetHashCode());
            Console.WriteLine(P2.GetHashCode());


            Console.WriteLine("----------------------");
            GenericStart<string> G1 = new GenericStart<string>();
            G1.Method2("mohammad");
            GenericStart<int> G2 = new GenericStart<int>();
            G2.Method2(34+6);
        }
    }
}
