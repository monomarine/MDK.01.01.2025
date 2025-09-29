using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POl
{
	internal class InsectAlien : Alien
	{
		public InsectAlien()
		{
			_name = "Инсектоид";
			_lifeExpectancy = 30;
			_interaction = Interaction.AGRESSIVE;
		}

		public override void Communication(Alien alien)
		{
			switch (alien.Interaction)
			{
				case Interaction.AGRESSIVE:
					int randomNumber = new Random().Next(0, 2);
					string result = randomNumber == 0 ?
						$"{Name} охотится за {alien.Name}" :
						$"{Name} убегает от {alien.Name}";
					Console.WriteLine(result);
					break;
				case Interaction.PEACEFUL:
				case Interaction.UNKNOWN:
					Console.WriteLine($"{Name} охотится за {alien.Name}");
					break;
			}
		}
	}
}
