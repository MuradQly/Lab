using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Murik.Entities
{
    internal class Teacher:Person
    {
        public int Salary { get; set; }
        public string Faculty { get; set; }
        public string Subject { get; set; }
    }
}
