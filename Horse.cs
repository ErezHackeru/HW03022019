using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW0302
{
    class Horse : Animal
    {
        public bool _racingHorse;

        public Horse(string name, bool racingHorse):base(name)
        {
            _racingHorse = racingHorse;
        }

        public override void MakeSound()
        {
            Neigh();
        }

        public virtual void Neigh()
        {
            Console.WriteLine("Neigh");
        }

        public override string ToString()
        {
            return base.ToString() + $" is racing horse: {_racingHorse}";
        }
    }
}
