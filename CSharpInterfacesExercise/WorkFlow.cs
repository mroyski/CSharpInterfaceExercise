using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterfacesExercise
{
    public class WorkFlow
    {
        public readonly IList<IActivity> _activities;

        public WorkFlow()
        {
            _activities = new List<IActivity>();
        }
    }
}
