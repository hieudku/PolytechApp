using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolytechLibrary
{
    internal class Teacher : Person
    {
        public string Subject { get; set; }

        public override float ComputeGradeAverage()
        {
            //TODO: fix the implementation later
            return 0.0f;
        }

    }
}
