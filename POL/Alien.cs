using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POl
{
	public enum Interaction{
		PEACEFUL,
		AGRESSIVE,
		UNKNOWN
	}
	internal abstract class Alien
	{
		protected string _name;
		protected int _lifeExpectancy;
		protected Interaction _interaction;
		protected string name;
		protected int lifeExpectancy;

		public string Name => _name;
		public int LifeExpectancy => _lifeExpectancy;
		public Interaction Interaction => _interaction;
		
		public Alien(string name, int lifeExpectancy, Interaction interaction = Interaction.UNKNOWN)
		{
			this._name = name;
			this._lifeExpectancy = lifeExpectancy;
			this._interaction = interaction;
		}

		public Alien() { }

		public abstract void Communication(Alien alien);
	}
}
