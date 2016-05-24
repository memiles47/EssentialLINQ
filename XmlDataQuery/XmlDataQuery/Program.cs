using System;
using System.Linq;
using System.Xml.Linq;

namespace XmlDataQuery
{
    class Program
    {
        static void Main()
        {
            #region SurfaceBook
            //var customers = XDocument.Load(@"f:\XML_Files\Customers.xml"); 
            #endregion

            #region SurfacePro 3
            var customers = XDocument.Load(@"d:\XML_Files\Customers.xml"); 
            #endregion

            var xml = from x in customers.Descendants("Customer")
                where x.Attribute("City").Value == "Mexico D.F."
                select x;

            foreach(var name in xml)
                Console.WriteLine($"Customer Name: {name.Attribute("ContactName").Value}");
        }
    }
}
