using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace YBInterface.Support.C010003
{
    public partial class responseBody
    {
        [XmlElement(ElementName = "item")]
        public responseItem[] item { get; set; }

        [XmlIgnoreAttribute]
        public string F1 { get; set; }

        [XmlIgnoreAttribute]
        public string F2 { get; set; }

        [XmlIgnoreAttribute]
        public string F3 { get; set; }

        [XmlIgnoreAttribute]
        public string F4 { get; set; }
    }

    public partial class responseItem
    {
        public string D501_02 { get; set; }
        public string D501_03 { get; set; }
        public string D501_04 { get; set; }
        public string D501_05 { get; set; }
        public string D501_40 { get; set; }
        public string D501_43 { get; set; }
        public string D501_11 { get; set; }
        public string D101_02 { get; set; }
        public string D501_12 { get; set; }
        public string D503_15 { get; set; }
        public string D503_44 { get; set; }
        public string D503_20 { get; set; }
        public string D603_02 { get; set; }
        public string D503_17 { get; set; }
        public string D503_02_2 { get; set; }
        public string D503_09 { get; set; }
        public string D503_57 { get; set; }
        public string D503_57_A { get; set; }
        public string D503_60 { get; set; }
        public string D503_61 { get; set; }

        [XmlIgnoreAttribute]
        public string Address { get; set; }

        [XmlIgnoreAttribute]
        public string F1 { get; set; }

        [XmlIgnoreAttribute]
        public string F2 { get; set; }

        [XmlIgnoreAttribute]
        public string F3 { get; set; }

        [XmlIgnoreAttribute]
        public string F4 { get; set; }
    }
}
