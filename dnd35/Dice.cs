using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dnd35
{
    class Dice
    {
        private Random rnd = new Random();
        private int sides;
        private int number;
        private int total;
        private List<int> results = new List<int>();
        private List<int> history = new List<int>();

        public int Sides
        {
            get { return this.sides; }
            set { this.sides = value; }
        }

        public int Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        public int Total
        {
            get { return this.total; }
        }

        public List<int> Results
        {
            get { return this.results; }
        }

        public int Roll()
        {
            int returnTotal = 0;
            int newvalue = 0;

            for (int i = 0; i < this.number; i++)
            {
                newvalue = rnd.Next(this.sides) + 1;
                this.results.Add(newvalue);
                returnTotal = newvalue + returnTotal;
            }

            this.total = this.results.Sum();

            return returnTotal;
        }

        public int RollNormal()
        {
            int newvalue = 0;

            this.results.Clear();

            for (int i = 0; i < this.number + 2; i++)
            {
                newvalue = rnd.Next(this.sides) + 1;
                this.results.Add(newvalue);
                //returnTotal = newvalue + returnTotal;
            }

            this.results.Remove(this.results.Min());
            this.results.Remove(this.results.Max());
            this.total = this.results.Sum();

            return this.total;
        }
    }
}
