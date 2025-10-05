using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POl
{
    public enum Interaction{ PEACEFUL, AGRESSIVE, UNKNOUN}
    internal abstract class Alien
    {
        protected string _name;
        protected int _lifeExpentancy;
        protected Interaction _interaction; //111
        public string Name => _name;
        public int LifeExpantancy => _lifeExpentancy;
        public Interaction Interaction => _interaction; //222 

        

        public abstract void Communication(Alien alien);
    }
}
