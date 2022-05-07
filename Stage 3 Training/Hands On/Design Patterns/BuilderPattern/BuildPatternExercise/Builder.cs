using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace BuildPatternExercise
{
    public abstract class Builder
    {
        public SweetShop SweetShop { get; set; }
        public abstract void NoOfSweets();
        public abstract void NoOfSavory();
    }
}
