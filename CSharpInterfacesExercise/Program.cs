using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterfacesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var workFlowEngine = new WorkFlowEngine();
            var workFlow1 = new WorkFlow();

            workFlow1.AddActivity(new Compile());
            workFlow1.AddActivity(new Debug());
            workFlowEngine.Run(workFlow1);
        }
    }
}
