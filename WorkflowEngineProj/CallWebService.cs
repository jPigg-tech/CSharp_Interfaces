using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngineProj
{
    public class CallWebService : IWorkflowExecutable
    {
        public void Execute()
        {
            Console.WriteLine("Calling a web service to tell them you have a video ready for encoding.");
        }
    }
}
