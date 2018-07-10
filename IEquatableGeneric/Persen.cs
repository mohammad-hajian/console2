using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IEquatableGeneric
{
    public class Persen : IEquatable<Persen>
    {
        public Persen()
        {

        }
        public Persen(string name, string family)
        {
            Family = family;
            Name = name;
        }
        public string Name { get; set; }
        public string Family { get; set; }

        public bool Equals(Persen P)
        {
            if (this.Name == P.Name && this.Family == P.Family)
            {// خاموش است و فقط برای فهم بهتر گذاشته شده است this
                return true;
            }
            else
            {
                return false; 
            }
        }
        #region به خاطر گیر های الکی وژوال گذاشته شده است و زیاد مهم نیست
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        public static bool operator ==(Persen P1, Persen P2)
        {
            return P1.Equals(P2);
        }
        public static bool operator !=(Persen P1, Persen P2)
        {
            return P1.Equals(P2);
        }

    }
}

