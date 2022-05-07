namespace IteratorPattern
{
    public abstract class MyIterator
    {
        //Iterator will have 4 methods
        public abstract object First();
        public abstract object GetCurrentItem();
        public abstract object Next();
        public abstract bool IsLast();
    }
}