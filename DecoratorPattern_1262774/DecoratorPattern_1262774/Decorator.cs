using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern_1262774
{
    public abstract class Decorator : IComponent
    {
        protected IComponent icmp;

        public Decorator(IComponent cmp)
        {
            icmp = cmp;
        }

        public abstract string Welcome();
        public abstract string Welcome(string name);
    }

}
