using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW0302
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog("1", "Dogli");
            Horse h = new Horse("2", true);
            Poodle p = new Poodle("3", "Rice", "2");
            Wolf w = new Wolf("4", "Tiras", "box");

            PetWolf PwL = new PetWolf("5", "Apple", "Big");
        }
        static void AnimalSing(Animal[] AllAnimals)
        {
            for (int i = 0; i < AllAnimals.Length; i++)
            {
                AllAnimals[i].MakeSound();
            }
        }

        static Horse[] GetRacingHorses(Horse[] AllHorses)
        {
            Horse[] result;
            int HowManyRacingHorses = 0;
            int index = 0;
            for (int i = 0; i < AllHorses.Length; i++)
            {
                if (AllHorses[i]._racingHorse == true)
                    HowManyRacingHorses++;
            }

            result = new Horse[HowManyRacingHorses];
            for (int i = 0; i < AllHorses.Length; i++)
            {
                if (AllHorses[i]._racingHorse == true)
                {
                    result[index] = AllHorses[i];
                    index++;
                }
            }

            return result;
        }
    }
}
