using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Student : Senior //Here Student is the last node
    {
        public Student(string name) : base(name)
        {
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('*', depth) + Name);
        }

        public override void Remove(Senior senior)
        {
            Console.WriteLine("Student is junior most cannot remove more");
        }

        public override void AddSenior(Senior senior)
        {
            Console.WriteLine("Student is the junior most so cannot add more");
        }
    }
}
