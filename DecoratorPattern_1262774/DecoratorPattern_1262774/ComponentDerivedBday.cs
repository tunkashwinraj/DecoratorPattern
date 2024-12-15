﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern_1262774
{
    class ComponentDerivedBday : Component
    {
        public override string Welcome()
        {
            return base.Welcome() + "\nHappy Birthday";
        }
    }

}
