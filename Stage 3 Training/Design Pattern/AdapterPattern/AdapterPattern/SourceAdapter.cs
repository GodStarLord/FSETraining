using System;

namespace AdapterPattern
{
    public class SourceAdapter : ChangeClass, ISource
    {
        public void CheckSource()
        {
            Console.WriteLine("Call for CheckSource but internally call for ChangeMethod from ChangeClass");
            ChangeMethod();
        }
    }
}