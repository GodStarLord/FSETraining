namespace CompositePattern
{
    public abstract class Senior
    {
        public string Name;

        public Senior(string name)
        {
            Name = name;
        }
        public abstract void AddSenior(Senior senior);
        public abstract void Remove(Senior senior);
        public abstract void Display(int depth);
    }
}