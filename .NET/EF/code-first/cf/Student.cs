using System;
using System.Collections.Generic;

namespace cf
{
    public class Student
    {
        public Student()
        {
            DateOfBirth = DateTime.Now;
        }

        public long StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

        public IList<Standard> Standard { get; set; }
    }
}
