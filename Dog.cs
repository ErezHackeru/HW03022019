using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW0302
{
    class Dog : Animal
    {
        public string _favoriteDogFood;

        public Dog(string name , string favoriteDogFood) : base(name)
        {
            _favoriteDogFood = favoriteDogFood;
        }

        public override void MakeSound()
        {
            Bark();
        }

        public virtual void Bark()
        {
            Console.WriteLine("How How");
        }

        public override string ToString()
        {
            return base.ToString() + $" favorite dog food is: {_favoriteDogFood}";
        }
    }
}
