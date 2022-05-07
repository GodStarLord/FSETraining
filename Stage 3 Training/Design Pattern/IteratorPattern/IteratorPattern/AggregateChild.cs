using System.Collections;

namespace IteratorPattern
{
    public class AggregateChild : MyAggregate
    {
        private readonly ArrayList _myList = new ArrayList();

        public override MyIterator CreateIterator()
        {
            return new IteratorChild(this);
        }

        public int Count => _myList.Count;

        public object this[int index]
        {
            get => _myList[index];
            set => _myList.Insert(index, value);
        }

    }
}