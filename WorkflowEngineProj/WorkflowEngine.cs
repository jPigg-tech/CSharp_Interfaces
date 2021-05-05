using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngineProj
{
    class WorkflowEngine
    {
        private readonly IList<IWorkflowExecutable> _workflowExecutables;
        public WorkflowEngine()
        {
            _workflowExecutables = new List<IWorkflowExecutable>();
        }

        public void Run(Workflow workflow)
        {
            foreach (var executable in _workflowExecutables)
            {
                executable.Execute();                
            }

        }
        public void RegisterWorkflowExecutable(IWorkflowExecutable executable)
        {
            _workflowExecutables.Add(executable);
        }
    }
}
