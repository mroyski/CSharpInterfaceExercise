using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterfacesExercise
{
    public class Debug : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Program successfully debugged");
        }
    }
}
