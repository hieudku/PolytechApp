using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PolytechLibrary.Student;

namespace PolytechLibrary
{
    internal class Student : Person
    {
        public enum GradLevels { Level_5, Level_7, Level_8, Level_9 }
        public GradLevels GradLevel { get; set; }

        public override float ComputeGradeAverage()
        {
            return 4.0f;
        }

    }
}
