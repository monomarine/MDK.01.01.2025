using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POl
{
    internal class GreenAlien : Alien
    {
        public override void Communication(Alien alien)
        {
            switch (alien.Interaction)
            {
                case Interaction.PEACEFUL:
                    int i = new Random().Next(0, 2);
                    
                    string result = i == 0 ?
                        $"{Name} мирно общается с {alien.Name}" :
                        $"{Name} убегать {alien.Name}";

                    Console.WriteLine(result);
                    break;

                case Interaction.AGRESSIVE:
                    Console.WriteLine($"{Name} убегает от {alien.Name}");
                    break;

                case Interaction.UNKNOUN:
                    Console.WriteLine($"{Name} прячется {alien.Name}");
                    break;
            }
        }

        public GreenAlien()
        {
            _name = "Зеленый";
            _lifeExpentancy = 1000;
            _interaction = Interaction.UNKNOUN;
        }
    }
}
