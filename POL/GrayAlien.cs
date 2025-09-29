using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POl
{
	internal class GrayAlien : Alien
	{
		public GrayAlien() 
		{
			_name = "Серый";
			_lifeExpectancy = 200;
			_interaction = Interaction.PEACEFUL;
		}

		public override void Communication(Alien alien)
		{
			switch (alien.Interaction)
			{
				case Interaction.PEACEFUL:
                    Console.WriteLine($"{Name} мирно общается с {alien.Name}");
					break;
				case Interaction.AGRESSIVE:
					Console.WriteLine($"{Name} убегает от {alien.Name}");
					break;
				default:
                    Console.WriteLine($"{Name} изучает {alien.Name}");
					break;
			}
		}
	}
}
