using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW0302
{
    abstract class Animal
    {
        public string _name;

        public Animl(string name)
        {
            _name = name;
        }

        public abstract void MakeSound();

        public override string ToString()
        {
            return $"The name is {_name}";
        }
    }
}
