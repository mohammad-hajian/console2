﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace FileXml_GenericInterface
{
    public class Listt : ISerializerGeneric<Person>
    {
        public Listt()
        {
        }
        /// <summary>
        /// Example : "d:\\mohammad.xml"
        /// </summary>
        /// <param name="spath"></param>
        public Listt(string spath) : base(spath)
        {
        }
    }
}
