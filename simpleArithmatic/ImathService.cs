using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace simpleArithmatic
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ImathService" in both code and config file together.
    [ServiceContract]
    public interface ImathService
    {
        [OperationContract]
        int Plus(int a , int b);
        [OperationContract]
        int Min(int a , int b);
        [OperationContract]
        int Cross(int a, int b);
        [OperationContract]
        int Div(int a, int b);
    }
}
