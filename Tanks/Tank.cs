using System;
using System.Collections.Generic;
using System.Text;

namespace Tanks
{
    public class tank
    {
        protected string name;
        protected int Ammunition;
        protected int ArmorLvL;
        protected int MannersLvL;
        public tank(int Ammunition, int ArmorLvL, int MannersLvL, string name)
        {
            this.Ammunition = Ammunition;
            this.ArmorLvL = ArmorLvL;
            this.MannersLvL = MannersLvL;
            this.name = name;
        }
        public tank()
        {
            Ammunition = 0;
            ArmorLvL = 0;
            MannersLvL = 0;
            name = "null";
        }
        public void Print()
        {
            Console.WriteLine("name - " + name);
            Console.WriteLine("Ammunition = " + Ammunition + " lvlBroni = " + ArmorLvL + " lvlManevr = " + MannersLvL);
        }
        public static tank operator *(tank T34, tank pantera)
        {
            if (T34.Ammunition > pantera.Ammunition && T34.ArmorLvL > pantera.ArmorLvL)
            {
                return T34;
            }
            if (T34.Ammunition > pantera.Ammunition && T34.MannersLvL > pantera.MannersLvL)
            {
                return T34;
            }
            if (T34.ArmorLvL > pantera.ArmorLvL && T34.MannersLvL > pantera.MannersLvL)
            {
                return T34;
            }
            else
            {
                return pantera;
            }
        }
    }
}
