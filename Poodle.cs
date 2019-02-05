using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW0302
{
    class Poodle:Dog
    {
        public string _numberOfPonyTails;

        public Poodle(string name, string favoriteDogFood ,string numberOfPonyTails) : base(name, favoriteDogFood)
        {
            _numberOfPonyTails = numberOfPonyTails;
        }

        public override void Bark()
        {
            Console.WriteLine("Bark lik a Poodle");
        }
        
        public override string ToString()
        {
            return base.ToString() + $"number of pony tails: {_numberOfPonyTails}";
        }
    }
}
