using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW0302
{
    class Wolf :Dog
    {
        public string _nameOfPack;

        public Wolf(string name, string favoriteDogFood, string nameOfPack) : base(name, favoriteDogFood)
        {
            _nameOfPack = nameOfPack;
        }

        public override void Bark()
        {
            Console.WriteLine("Bark like a Wolf");
        }

        public override string ToString()
        {
            return base.ToString() + $"name of pack: {_nameOfPack}";
        }
    }
}
