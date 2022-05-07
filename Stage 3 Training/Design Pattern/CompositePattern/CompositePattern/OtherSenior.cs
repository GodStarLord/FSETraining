using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CompositePattern
{
    public class OtherSenior : Senior
    {
        List<Senior> seniors = new List<Senior>();

        public OtherSenior(string name) : base(name)
        {
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('*', depth) + Name);
            foreach (Senior senior in seniors)
            {
                senior.Display(depth + 2);
            }
        }

        public override void Remove(Senior senior)
        {
            seniors.Remove(senior);
        }

        public override void AddSenior(Senior senior)
        {
            seniors.Add(senior);
        }
    }
}