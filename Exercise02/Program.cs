using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfShapes = new List<Shape>
            {
                new Circle { Colour = "Red", Radius = 2.5, Area = 2.5*2.5 * 3.1415926536 },
                new Rectangle { Colour = "Blue", Height = 20.0, Width = 10.0, Area = 20.0 * 10.0},
                new Circle { Colour = "Green", Radius = 8, Area = 8*8 * 3.1415926536 },
                new Circle { Colour = "Purple", Radius = 12.3, Area = 12.3*12.3 * 3.1415926536 },
                new Rectangle { Colour = "Blue", Height = 45.0, Width = 18.0, Area = 45.0 * 18.0 }
            };

            try
            {
                var path = @"C:\Test\myserializationtest.xml";
                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    XmlSerializer xSer = new XmlSerializer(typeof(List<Shape>));


                    xSer.Serialize(fs, listOfShapes);
                };

                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    XmlSerializer _xSer = new XmlSerializer(typeof(List<Shape>));

                    List<Shape> myObject = _xSer.Deserialize(fs) as List<Shape>;

                    foreach (Shape item in myObject)
                    {
                        Console.WriteLine($"{item.GetType().Name} is {item.Colour} and has an area of {item.Area}");
                    }
                };


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            

           

            Console.ReadKey();






        }
    }
}
