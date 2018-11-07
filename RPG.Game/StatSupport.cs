using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Game
{
    class StatSupport
    {
      
        public void RaiseAttandMag(Character Tank, Character StatSupport, Character CloseRangeDPS, Character LongRangeDPS, Character Healer)
        {
            if (Tank.PhysicalAttack == Tank.DefaultPhysicalAttack)
            {
                Console.WriteLine($"{StatSupport.Name} is now buffing your offensive stats by 50%.");
                Tank.PhysicalAttack *= (decimal)1.5;
                Tank.MagicalAttack *= (decimal)1.5;
                StatSupport.PhysicalAttack *= (decimal)1.5;
                StatSupport.MagicalAttack *= (decimal)1.5;
                CloseRangeDPS.PhysicalAttack *= (decimal)1.5;
                CloseRangeDPS.MagicalAttack *= (decimal)1.5;
                LongRangeDPS.PhysicalAttack *= (decimal)1.5;
                LongRangeDPS.MagicalAttack *= (decimal)1.5;
                Healer.PhysicalAttack *= (decimal)1.5;
                Healer.MagicalAttack *= (decimal)1.5;

                StatSupport.ManaPool -= 35;
            }
            else if (Tank.PhysicalAttack > Tank.DefaultPhysicalAttack)
            {
                Console.WriteLine("You have already used this action.");
            }
        }

        public void RaiseDefandMagDef(Character Tank, Character StatSupport, Character CloseRangeDPS, Character LongRangeDPS, Character Healer)
        {
            if (Tank.Defense == Tank.DefaultDefense)
            {
                Console.WriteLine($"{StatSupport.Name} is now buffing your defensive stats by 50%.");
                Tank.Defense *= (decimal)1.5;
                Tank.MagicalDefense *= (decimal)1.5;
                StatSupport.Defense *= (decimal)1.5;
                StatSupport.MagicalDefense *= (decimal)1.5;
                CloseRangeDPS.Defense *= (decimal)1.5;
                CloseRangeDPS.MagicalDefense *= (decimal)1.5;
                LongRangeDPS.Defense *= (decimal)1.5;
                LongRangeDPS.MagicalDefense *= (decimal)1.5;
                Healer.Defense *= (decimal)1.5;
                Healer.MagicalDefense *= (decimal)1.5;

                StatSupport.ManaPool -= 35;
            }
            else if (Tank.Defense > Tank.DefaultDefense)
            {
                Console.WriteLine("You have already used this action.");
            }
        }

        public void DebuffAttandMag(Character Monster, Character StatSupport)
        {
            if (Monster.PhysicalAttack == Monster.DefaultPhysicalAttack &&
                Monster.MagicalAttack == Monster.DefaultMagicalAttack)
            {
                Console.WriteLine($"{StatSupport.Name} is now debuffing {Monster.Name}'s offensive stats by 50%.");
                Monster.PhysicalAttack *= (decimal)0.5;
                Monster.MagicalAttack *= (decimal)0.5;

                StatSupport.ManaPool -= 35;
            }
            else if (Monster.PhysicalAttack > Monster.DefaultPhysicalAttack ||
                Monster.MagicalAttack > Monster.DefaultMagicalAttack)
            {
                Console.WriteLine("You have already used this action.");
            }

        }

        public void DebuffDefandMagDef(Character Monster, Character StatSupport)
        {
            if (Monster.Defense == Monster.DefaultDefense &&
                Monster.MagicalDefense == Monster.DefaultMagicalDefense)
            {
                Console.WriteLine($"{StatSupport.Name} is now debuffing {Monster.Name}'s defensive stats by 50%.");
                Monster.Defense *= (decimal)0.5;
                Monster.MagicalDefense *= (decimal)0.5;

                StatSupport.ManaPool -= 35;
            }
            else if (Monster.Defense > Monster.DefaultDefense ||
                    Monster.MagicalDefense > Monster.DefaultMagicalDefense)
            {
                Console.WriteLine("You have already used this action.");
            }
        }
    }
}
