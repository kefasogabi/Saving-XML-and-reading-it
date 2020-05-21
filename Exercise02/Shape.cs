using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Exercise02
{
    [XmlInclude(typeof(Circle))]
    [XmlInclude(typeof(Rectangle))]
    [Serializable]
    public class Shape
    {
        public string Colour { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Radius { get; set; }
        public double Area { get; set; }

       
    }
}
