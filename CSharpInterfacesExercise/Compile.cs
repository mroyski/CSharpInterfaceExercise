using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterfacesExercise
{
    public class Compile : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Project successfully compiled.");
        }
    }
}
