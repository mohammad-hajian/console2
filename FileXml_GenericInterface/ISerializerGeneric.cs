using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Collections;

namespace FileXml_GenericInterface
{
    public class ISerializerGeneric<G> : IList<G>
    {
        string SPath = string.Empty;
        XmlSerializer oXS2;
        public ISerializerGeneric()
        {
            oXS2 = new XmlSerializer(this.GetType(), new XmlRootAttribute(string.Format($"{ typeof(G).Name }s")));
            //با کد پایین، فایل را در پوشه خود پروژه میسازد
            //SPath = string.Format($"{Environment.CurrentDirectory}{typeof(G).Name}.xml");
            SPath = "d:\\defaultXml.xml";
        }
        public ISerializerGeneric(string spath)
        {
            oXS2 = new XmlSerializer(this.GetType(), new XmlRootAttribute(string.Format($"{ typeof(G).Name }s")));
            SPath = spath;
        }

        List<G> InnereList = new List<G>();
        public G this[int index]
        {
            get
            {
                return InnereList[index];
            }

            set
            {
                InnereList[index] = value;
            }
        }
        public void Save()
        {
            try
            {
                using (StreamWriter oSW2 = new StreamWriter(SPath))

                {
                    oXS2.Serialize(oSW2, this);
                }
            }
            catch (Exception xe)
            {

                Console.WriteLine($"************ {xe.Message}");
                Console.WriteLine("************ nam va pasvande file ra niz vared konid(agar vared nakardid)");
            }

        }
        public void Load()
        {
            StreamReader oSR2 = new StreamReader(SPath);
            try
            {
                this.InnereList = ((ISerializerGeneric<G>)oXS2.Deserialize(oSR2)).InnereList;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); ;
            }
            finally
            {
                oSR2.Close();
                oSR2.Dispose();
            }
        }
        public void Add(G item)
        {
            InnereList.Add(item);
        }
        public void AddItem(G item)
        {
            if (File.Exists(SPath))
            {
                Load();
                InnereList.Add(item);
                Save();
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return InnereList.GetEnumerator();

        }
        public IEnumerator<G> GetEnumerator()
        {
            return InnereList.GetEnumerator();
        }

        public override string ToString()
        {
            string Temp = string.Empty;
            foreach (G item in this)
            {
                Temp += string.Format($"{item}\n");
            }
            return Temp;
        }

        public int Count
        {
            get
            {
                return InnereList.Count;
            }
        }

        #region اضافه
        public bool IsReadOnly => throw new NotImplementedException();

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(G item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(G[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }
        public int IndexOf(G item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, G item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(G item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
