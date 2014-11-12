using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;
using System.Collections;
using System.Collections.Generic;

namespace simpleWorkflow
{

    class Program
    {
        static void Main(string[] args)
        {
            //WorkflowInvoker.Invoke(new Workflow1());
            //Console.ReadLine();

            var w1 = new Workflow1();
            IDictionary<String, Object> inputw1  = new Dictionary<String, Object>();
            IDictionary<String, Object> outputw1 = new Dictionary<String, Object>();
            IDictionary<String, Object> inputw2 = new Dictionary<String, Object>();

            inputw1["number1"] = 10;
            inputw1["number2"] = 15;
            inputw1["operation"] = "op1";
             
            var wa1 = new WorkflowApplication(w1, inputw1);
           

            wa1.Completed = e =>
            {
                outputw1 = e.Outputs;
                
                Console.WriteLine("yup yup : " + outputw1["result"]);
                inputw2["number1"] = outputw1["result"];

            };

            
            wa1.Run();
            Console.ReadLine();

            var w2 = new SimpleFlowChart();
            var wa2 = new WorkflowApplication(w2, inputw2);
            wa2.Run();
            
           // WorkflowInvoker.Invoke(new SimpleFlowChart());
            Console.ReadLine();
           
        }
    }
}
