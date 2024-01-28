using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_1.Classes
{
    internal class Teacher
    {
        public List<string> Subjects { private get; set; }

        public string GetSubjects()
        {
            return string.Join(", ", Subjects);
        }
    }
}
