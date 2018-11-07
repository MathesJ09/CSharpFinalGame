using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Game
{
    class CloseRangeDPS
    {

        public void ChargeStrike(Character Monster, Character Tank, Character StatSupport, Character CloseRangeDPS, Character LongRangeDPS, Character Healer, Turns Catt)
        {
           

            if (CloseRangeDPS.Class == "Assassin")
            {               
                var AssassinateDmg = (CloseRangeDPS.PhysicalAttack * 2) - Monster.Defense;
                Monster.Health -= AssassinateDmg;
                Console.WriteLine($"{CloseRangeDPS.Name} did {AssassinateDmg} damage to {Monster.Name} using Assassinate.");
            }
            else if (CloseRangeDPS.Class == "Warrior")
            {
                if (Catt.CATT == 0)
                {
                    Console.WriteLine($"{CloseRangeDPS.Name} is charging up their attack.");
                }
                else if (Catt.CATT == 1)
                {
                    var ChargeAttackDmg = (CloseRangeDPS.PhysicalAttack * 2) - Monster.Defense;
                    Monster.Health -= ChargeAttackDmg;
                    Console.WriteLine($"{CloseRangeDPS.Name} did {ChargeAttackDmg} damage to {Monster.Name} using their charged attack.");
                }
            }
            else if (CloseRangeDPS.Class == "Battle Mage")
            {
                var BurstBombDmg = (CloseRangeDPS.PhysicalAttack * 2) - Monster.Defense;
                Monster.Health -= BurstBombDmg;
                Console.WriteLine($"{CloseRangeDPS.Name} did {BurstBombDmg} damage to {Monster.Name} using their burst bomb attack.");
            }

        }
        public void DefensiveAbility(Character Monster, Character Tank, Character StatSupport, Character CloseRangeDPS, Character LongRangeDPS, Character Healer)
        {
            if (CloseRangeDPS.Class == "Assassin")
            {
                Console.WriteLine($"{CloseRangeDPS.Name} used Stealth. {Monster.Name} will have a harder time hitting them.");
            }
            else if (CloseRangeDPS.Class == "Warrior")
            {
                Console.WriteLine($"{CloseRangeDPS.Name} used Berserk. {CloseRangeDPS.Name} will take massive damage in exchange for half their health.");
                var BerserkStrike = (CloseRangeDPS.PhysicalAttack * 4) - Monster.Defense;
                Monster.Health -= BerserkStrike;
                CloseRangeDPS.Health -= CloseRangeDPS.Health / 2;
            }
            else if (CloseRangeDPS.Class == "Battle Mage")
            {
                Console.WriteLine($"{CloseRangeDPS.Name} used Bubble Shield. Your max health for all your characters has been increased.");
                Tank.MaxHealth += 200;
                StatSupport.MaxHealth += 200;
                CloseRangeDPS.MaxHealth += 200;
                LongRangeDPS.MaxHealth += 200;
                Healer.MaxHealth += 200;
                Tank.Health += 200;
                StatSupport.Health += 200;
                CloseRangeDPS.Health += 200;
                LongRangeDPS.Health += 200;
                Healer.Health += 200;
            }
           
        }
    }
}
