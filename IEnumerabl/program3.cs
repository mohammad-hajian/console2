using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerabl
{

    class Program3
    {
        static void Main(string[] args)
        {
            //شمارشی کردن کلاس آرایه ها
            CelasArrays Arr1 = new CelasArrays();
            Console.WriteLine(Arr1.PrArr());

            //شمارشی کردن کلاس
            Celas Cl1 = new Celas();
            Console.WriteLine(Cl1.PrCelas());

            //شمارشی کردن متود
            Metod Mt1 = new Metod();
            Console.WriteLine(Mt1.PrMetod());
        }
    }
}