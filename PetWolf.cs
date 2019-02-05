using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW0302
{
    sealed class PetWolf : Wolf
    {
        public PetWolf(string name, string favoriteDogFood, string nameOfPack) : base(name, favoriteDogFood, nameOfPack)
        {

        }
        public override void Bark()
        {
            Console.WriteLine("Pet Wolf Bark");
        }
    }
}
