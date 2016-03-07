using System;
using System.Collections.Generic;

namespace cf
{
    public class Standard
    {
        public Standard()
        {

        }

        public long StandardId { get; set; }
        public string StandardName { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
