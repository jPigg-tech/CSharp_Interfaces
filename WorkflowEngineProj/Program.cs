using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngineProj
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflowEngine = new WorkflowEngine();
            workflowEngine.RegisterWorkflowExecutable(new UploadVideo());
            workflowEngine.RegisterWorkflowExecutable(new SendEmail());
            workflowEngine.RegisterWorkflowExecutable(new CallWebService());
            workflowEngine.Run(new Workflow());
        }
    }
}
