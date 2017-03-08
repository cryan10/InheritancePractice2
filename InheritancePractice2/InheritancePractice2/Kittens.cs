using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice2
{
    class Cats : Animals
    {
        public Cats() : base(true, "mancoon", 100, true)
        {

        }

        public void WhatAmI()
        {
            Console.WriteLine("I'm a cat!");
        }

    }
}
