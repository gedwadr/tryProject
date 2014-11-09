using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace simpleArithmatic
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "mathService" in code, svc and config file together.
    public class mathService : ImathService
    {
      
        public int Plus(int a, int b)
        {
            return a + b;
        }

        public int Min(int a, int b)
        {
            return a - b;
        }

        public int Cross(int a, int b)
        {
            return a * b;
        }

        public int Div(int a, int b)
        {
            return a / b;
        }

    }
}
