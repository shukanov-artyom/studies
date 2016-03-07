using System;

namespace cf
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new HelloModel())
            {
                Student stud = new Student() { StudentName = "New Student" };
                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}
