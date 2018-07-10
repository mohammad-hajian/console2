using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileTxt
{
    class Program5
    {
        static void Main(string[] args)
        {

            #region Get Files & Folders
            //foreach (string a1 in Directory.GetFiles(@"e:\"))
            //{
            //    Console.WriteLine(a1);
            //}
            //Console.WriteLine("-\n-\n-\n-\n-\n-");

            //foreach (string a2 in Directory.GetDirectories("e:\\"))
            //{
            //    Console.WriteLine(a2);
            //}
            #endregion

            #region StreamWriter
            StreamWriter oSW = new StreamWriter(@"d:\text.txt", true);
            try
            {
                oSW.WriteLine("hello world!");
                oSW.WriteLine("سلام بر جهانیان");
            }
            catch (Exception Ex)
            {

                Console.WriteLine(Ex.Message);
            }
            finally
            {
                oSW.Close();
                oSW.Dispose();
            }
            #endregion

            #region StreamReader
            StreamReader oSR = new StreamReader(@"d:\text.txt");
            try
            {
                while (!oSR.EndOfStream)
                {
                    Console.WriteLine(oSR.ReadToEnd());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                oSR.Close();
                oSR.Dispose();
            }
            #endregion

        }
    }
}
