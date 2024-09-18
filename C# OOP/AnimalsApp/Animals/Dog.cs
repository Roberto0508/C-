using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Dog: Animal
    {
        public Dog(string name, string favouriteFood)
        {
        }

        public override string ExplainMyself()
        {
            return base.ExplainMyself() + Environment.NewLine + "DJAAF";
        }
    }
}
