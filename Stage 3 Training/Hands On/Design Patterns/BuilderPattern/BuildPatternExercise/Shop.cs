using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildPatternExercise
{
    public class Shop
    {
        public void Construct(Builder shopBuilder)
        {
            shopBuilder.NoOfSweets();
            shopBuilder.NoOfSavory();

        }
    }
}
