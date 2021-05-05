using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngineProj
{
    public class UploadVideo : IWorkflowExecutable
    {
        public void Execute()
        {
            Console.WriteLine("Uploaded a video");
        }
    }
}
