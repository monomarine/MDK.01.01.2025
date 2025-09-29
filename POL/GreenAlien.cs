using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POl
{
	internal class GreenAlien : Alien
	{
		public GreenAlien()
		{
			_name = "Зеленый";
			_lifeExpectancy = 1000;
			_interaction = Interaction.UNKNOWN;
		}

		public override void Communication(Alien alien)
		{
			Random rand = new Random();
			switch (alien.Interaction)
			{
				case Interaction.PEACEFUL:
					int randomNumber = rand.Next(0, 2);
					string result = randomNumber == 0 ?
						$"{Name} мирно общается с {alien.Name}" :
						$"{Name} убегает от {alien.Name}";
					Console.WriteLine(result);
					break;
				case Interaction.AGRESSIVE:
					Console.WriteLine($"{Name} убегает от {alien.Name}");
					break;
				default:
					Console.WriteLine($"{Name} прячется от {alien.Name}");
					break;
			}
		}
	}
}
