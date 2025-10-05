using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POl
{
    internal class InsectAlien : Alien
    {
        public override void Communication(Alien alien)
        {
            switch (alien.Interaction)
            {
                case Interaction.AGRESSIVE:
                    int i = new Random().Next(0, 2);

                    string result = i == 0 ?
                        $"{Name} охотиться за {alien.Name}" :
                        $"{Name} убегать {alien.Name}";

                    Console.WriteLine(result);
                    break;
                 
                case Interaction.PEACEFUL:
                case Interaction.UNKNOUN:
                    Console.WriteLine($"{Name} охотится за {alien.Name}");
                    break;
            }
        }
        public InsectAlien()
        {
            _name = "Инсектоид";
            _lifeExpentancy = 30;
            _interaction = Interaction.AGRESSIVE;
        }
    }
}
