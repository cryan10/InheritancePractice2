using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice2
{
    class Dogs : Animals
    {
    public Dogs() : base (true, "golden retriever", 100, true)
        {

        }

    public void WhatAmI()
        {
            Console.WriteLine("I'm a dog!");
        }
    }
}
