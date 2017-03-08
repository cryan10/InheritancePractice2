using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice2
{
    class Animals
    {
        protected bool breathing;
        protected string species;
        protected int weight;
        protected bool tail;

        public Animals(bool breathing, string species, int weight, bool tail)
        {
            this.breathing = breathing;
            this.species = species;
            this.weight = weight;
            this.tail = tail;

        }

        public Animals()
        {

        }


        public string Species
        {
            get { return this.species; }
            set { this.species = value; }
            }

        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value;  }
        }

        public void Speak()
        {
            Console.WriteLine("I love playing!");
        }
    }
}
