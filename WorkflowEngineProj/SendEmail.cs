using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngineProj
{
    public class SendEmail : IWorkflowExecutable
    {
        public void Execute()
        {
            Console.WriteLine("Sending Email to the owner of the video.");
        }
    }
}
