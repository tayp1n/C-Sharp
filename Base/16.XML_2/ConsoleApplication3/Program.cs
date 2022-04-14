using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml;
namespace ConsoleApplication3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*BusBmw bmw = new BusBmw{Color = "Red", Name = "bmw", Number = 345345, Seats = 12, MaxSpeed = 117.3};
            BusVolvo volvo = new BusVolvo{Color = "Green", Name = "volvo", Number = 345785, Seats = 20, MaxSpeed = 116.9};
            MercedesBus mercedes = new MercedesBus{Color = "Blue", Name = "mercedes", Number = 435345, Seats = 15, MaxSpeed = 120.5};
            PeugeotBus peugeot = new PeugeotBus{Color = "Yellow", Name = "peugeot", Number = 347845, Seats = 17, MaxSpeed = 126.1};*/
            List<Busses> bussesList = new List<Busses>
            {
                new Busses{Color = "Red", Name = "bmw", Number = 345345, Seats = 12, MaxSpeed = 117.3},
                new Busses{Color = "Green", Name = "volvo", Number = 345785, Seats = 20, MaxSpeed = 116.9},
                new Busses{Color = "Blue", Name = "mercedes", Number = 435345, Seats = 15, MaxSpeed = 120.5},
                new Busses{Color = "Yellow", Name = "peugeot", Number = 347845, Seats = 17, MaxSpeed = 126.1}
            };
            
            XmlDocument xmlDocument = new XmlDocument();
            XmlDeclaration declaration = xmlDocument.CreateXmlDeclaration("1.0", "utf-8", null);

            int i = 1;
            XmlElement root = xmlDocument.CreateElement("busses"); XmlElement bus = null;
            
            xmlDocument.AppendChild(root);
            foreach (var item in bussesList)
            {
                bus = xmlDocument.CreateElement($"bus-{i++}");
                XmlElement color = xmlDocument.CreateElement($"Color");
                XmlElement name = xmlDocument.CreateElement($"Name");
                XmlElement number = xmlDocument.CreateElement($"Number");
                XmlElement seats = xmlDocument.CreateElement($"Seats");
                XmlElement maxspeed = xmlDocument.CreateElement($"MaxSpeed");
                
                XmlText txtColor = xmlDocument.CreateTextNode(item.Color);
                XmlText txtName = xmlDocument.CreateTextNode(item.Name);
                XmlText txtNumber = xmlDocument.CreateTextNode(item.Number.ToString());
                XmlText txtSeats = xmlDocument.CreateTextNode(item.Seats.ToString());
                XmlText txtMaxSpeed = xmlDocument.CreateTextNode(item.MaxSpeed.ToString(CultureInfo.InvariantCulture));
                
                root.AppendChild(bus);
                bus.AppendChild(color);
                bus.AppendChild(name);
                bus.AppendChild(number);
                bus.AppendChild(seats);
                bus.AppendChild(maxspeed);
                
                color.AppendChild(txtColor);
                name.AppendChild(txtName);
                number.AppendChild(txtNumber);
                seats.AppendChild(txtSeats);
                maxspeed.AppendChild(txtMaxSpeed);
            }
            
            
            
            
            
            xmlDocument.Save("Busses.xml");

        }
    }
}