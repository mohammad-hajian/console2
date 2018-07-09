using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sakhteShomareshi
{

    class Program3
    {
        static void Main(string[] args)
        {
            //شمارشی کردن کلاس آرایه ها
            CelasArrays Arr1 = new CelasArrays();
            foreach (CelasArray Arr in Arr1)
            {
                Arr.Chapkon();
            }

            ////شمارشی کردن کلاس
            //Celas Cl1 = new Celas();
            //foreach (var ClProgram in Cl1)
            //{
            //    Console.WriteLine(ClProgram);
            //}
            ////شمارشی کردن متود
            //Metod Mt1 = new Metod();
            //foreach (var MtProgram in Mt1.Test())
            //{
            //    Console.WriteLine(MtProgram);
            //}
        }
    }
}