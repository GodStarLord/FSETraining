using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            OtherSenior rootNode = new OtherSenior("Senior Most");
            rootNode.AddSenior(new Student("Student 1"));
            rootNode.AddSenior(new Student("Student 2"));
            rootNode.AddSenior(new Student("Student 3"));

            OtherSenior branch = new OtherSenior("Student 4");
            branch.AddSenior(new Student("Sub Student 1"));
            branch.AddSenior(new Student("Sub Student 2"));
            branch.AddSenior(new Student("Sub Student 3"));

            rootNode.AddSenior(branch); //Here Student is the leaf node

            rootNode.Display(1);

            Console.ReadLine();
        }
    }
}
