using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Game
{
    class LongRangeDPS
    {
        public void AOEAttack(Character Monster, Character Tank, Character StatSupport, Character CloseRangeDPS, Character LongRangeDPS, Character Healer)
        {
            if (LongRangeDPS.Class == "Mage")
            {
                Console.WriteLine($"{LongRangeDPS.Name} rained meteors from the heaven doing heavy aoe damage.");
                var MeteorDmg = ((LongRangeDPS.MagicalAttack/2) - Monster.MagicalDefense);
                Monster.Health -= MeteorDmg;

            }
            else if (LongRangeDPS.Class == "Archer")
            {
                Console.WriteLine($"{LongRangeDPS.Name} shot arrows into the sky causing a rain of arrows to fall on {Monster.Name}");
                var ArrowRainDmg = ((LongRangeDPS.PhysicalAttack / 2) - Monster.Defense);
                Monster.Health -= ArrowRainDmg;
            }
            else if (LongRangeDPS.Class == "Knife Slinger")
            {
                Console.WriteLine($"{LongRangeDPS.Name} threw knives precisely at the weak points of {Monster.Name}");
                var KnifeRainDmg = ((LongRangeDPS.PhysicalAttack / 2) - Monster.Defense);
                Monster.Health -= KnifeRainDmg;
            }

        }
        public void SingleTarget(Character Monster, Character Tank, Character StatSupport, Character CloseRangeDPS, Character LongRangeDPS, Character Healer)
        {
            if (LongRangeDPS.Class == "Mage")
            {
                var HolyDmg = (LongRangeDPS.MagicalAttack * (decimal)1.5) - Monster.MagicalDefense;
                Monster.Health -= HolyDmg;
                Console.WriteLine($"{LongRangeDPS.Name} used Holy to deal massive damage to enemy.");
            }
            if (LongRangeDPS.Class == "Archer")
            {
                var PullBackDmg = (LongRangeDPS.PhysicalAttack * (decimal)1.5) - Monster.Defense;
                Monster.Health -= PullBackDmg;
                Console.WriteLine($"{LongRangeDPS.Name} launched an arrow at full might.");
            }
            if (LongRangeDPS.Class == "Knife Slinger")
            {
                var ExCalDmg = (LongRangeDPS.PhysicalAttack * (decimal)1.5) - Monster.Defense;
                Monster.Health -= ExCalDmg;
                Console.WriteLine($"{LongRangeDPS.Name} hit the {Monster.Name} with the holy sword Excaliber.");
            }

        }
    }
}
