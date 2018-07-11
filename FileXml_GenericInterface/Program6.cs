using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace FileXml_GenericInterface
{
    class Program6
    {
        static void Main(string[] args)
        {
            #region xml Õ«·  ”«œÂ 
            //Person oP = new Person("mohammad", "hajian");
            //StreamWriter oSW = new StreamWriter(@"d:\Xml.xml");
            //XmlSerializer oXS = new XmlSerializer(typeof(Person));
            //try
            //{
            //    oXS.Serialize(oSW, oP);
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message); ;
            //}
            //finally
            //{
            //    if (oSW != null)
            //    {
            //        oSW.Close();
            //        oSW.Dispose();
            //    }
            //}
            #endregion

            Listt olistt = new Listt();
            olistt.Add(new Person("mohammad","hajian"));
            Person oPerson = new Person("mohsen","bagheri");
            olistt.Add(oPerson);
            olistt.Save("d:\\");
            olistt.Load("d:\\");
            Console.WriteLine(olistt);
        }

    }
}
