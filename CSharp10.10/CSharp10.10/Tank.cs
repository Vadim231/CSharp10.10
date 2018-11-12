using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10._10
{
    class Tank
    {
        protected string name;
        protected int armorLevel;
        protected int ammunition;
        protected int maneuverability;

        public Tank()
        {
            name = "";
            armorLevel = 0;
            ammunition = 0;
            maneuverability = 0;
        }

        public Tank(string name,int ammunition, int armorLevel, int maneuverability)
        {

            this.name = name;
            this.armorLevel = armorLevel;
            this.ammunition = ammunition;
            this.maneuverability = maneuverability;
        }

        public void Print()
        {
            Console.WriteLine("name: " + name);
            Console.WriteLine("ammunition: " + ammunition + ", armorLevel: " + armorLevel + ", maneuverability: " + maneuverability);
        }

        public static Tank operator *(Tank firstTank, Tank secondTank)
        {

            if ((firstTank.ammunition > secondTank.ammunition && firstTank.armorLevel > secondTank.armorLevel)
                ||(firstTank.ammunition > secondTank.ammunition && firstTank.maneuverability > secondTank.maneuverability)
                    ||(firstTank.armorLevel > secondTank.armorLevel && firstTank.maneuverability > secondTank.maneuverability))
            {
                return firstTank;
            }
            else if((firstTank.ammunition == secondTank.ammunition && firstTank.armorLevel == secondTank.armorLevel)
                || (firstTank.ammunition == secondTank.ammunition && firstTank.maneuverability == secondTank.maneuverability)
                    || (firstTank.armorLevel == secondTank.armorLevel && firstTank.maneuverability == secondTank.maneuverability))
            {
                Console.WriteLine("Танки подружились и уехали в закат");//вероятность очень мала
                return secondTank;
            }
            else
            {
                return secondTank;
            }
        }
    }
}
