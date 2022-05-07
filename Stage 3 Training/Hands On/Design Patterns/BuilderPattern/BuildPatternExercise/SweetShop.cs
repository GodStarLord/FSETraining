using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildPatternExercise
{
    public class SweetShop
    {
        private readonly string _packageType;
        private readonly Dictionary<string, int> _item = new Dictionary<string, int>();

        public SweetShop(string packageType)
        {
            this._packageType = packageType;
        }

        public int this[string key]
        {
            get => _item[key];
            set => _item[key] = value;
        }
        public void Show()
        {
            Console.WriteLine("Package Type: {0}", _packageType);
            Console.WriteLine(" Sweet : {0}", _item["sweet"]);
            Console.WriteLine(" Item : {0}", _item["savory"]);
        }
    }
}
