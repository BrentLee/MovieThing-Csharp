using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Person
    {
        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public string Biography { get; set; }

        public int Age { get { return DateTime.Now.Year - Birthday.Year; } }
    }
}
