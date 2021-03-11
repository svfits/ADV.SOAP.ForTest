using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;

namespace ADV.SOAP.Test.Model
{
    [ServiceContract]
    public interface ISampleService
    {
        [OperationContract]
        string Test(string s);

        [OperationContract]
        void XmlMethod(System.Xml.Linq.XElement xml);

        [OperationContract]
        User TestCustomModel(User inputModel);
    }
}
