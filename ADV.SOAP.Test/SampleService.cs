using ADV.SOAP.Test.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ADV.SOAP.Test
{
    public class SampleService : ISampleService
    {
        public string Test(string s)
        {
            Console.WriteLine("Test Method Executed!");
            return s;
        }

        public void XmlMethod(XElement xml)
        {
            Console.WriteLine(xml.ToString());
        }

        public User TestCustomModel(User customModel)
        {
            return customModel;
        }
    }
}
