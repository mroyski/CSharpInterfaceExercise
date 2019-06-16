using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterfacesExercise
{
    public class WorkFlowEngine
    {
        public void Run(WorkFlow workFlow)
        {
            foreach(var activity in workFlow._activities)
            {
                activity.Execute();
            }
        }
    }
}
