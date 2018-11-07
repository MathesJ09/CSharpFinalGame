using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Game
{
    class Monster 
    {      
        public void MonsterDamageSingleTarget(Character Monster, Character Tank, Character StatSupport, Character CloseRangeDPS, Character LongRangeDPS, Character Healer)
        {
            int randomSelection;
            Random RandomSTDmg = new Random();
            randomSelection = RandomSTDmg.Next(1, 5);

            if (Monster.Class == "Physical Monster")
            {
                if (randomSelection == 1)
                {
                    decimal MonsterSTDmgTank = Monster.PhysicalAttack - Tank.Defense * (decimal)0.15;
                    Tank.Health -= MonsterSTDmgTank;
                }
                else if (randomSelection == 2)
                {
                    decimal MonsterSTDmgStatSupport = Monster.PhysicalAttack - StatSupport.Defense * (decimal)0.15;
                    StatSupport.Health -= MonsterSTDmgStatSupport;
                }
                else if (randomSelection == 3)
                {
                    decimal MonsterSTDmgCloseRangeDPS = Monster.PhysicalAttack - CloseRangeDPS.Defense * (decimal)0.15;
                    CloseRangeDPS.Health -= MonsterSTDmgCloseRangeDPS;
                }
                else if (randomSelection == 4)
                {
                    decimal MonsterSTDmgLongRangeDPS = Monster.PhysicalAttack - LongRangeDPS.Defense * (decimal)0.15;
                    LongRangeDPS.Health -= MonsterSTDmgLongRangeDPS;
                }
                else if (randomSelection == 5)
                {
                    decimal MonsterSTDmgHealer = Monster.PhysicalAttack - Healer.Defense * (decimal)0.15;
                    Healer.Health -= MonsterSTDmgHealer;
                }
            }
            else if (Monster.Class == "Magical Monster")
            {
                if (randomSelection == 1)
                {
                    decimal MonsterSTDmgTank = Monster.MagicalAttack - Tank.MagicalDefense * (decimal)0.15;
                    Tank.Health -= MonsterSTDmgTank;
                }
                else if (randomSelection == 2)
                {
                    decimal MonsterSTDmgStatSupport = Monster.MagicalAttack - StatSupport.MagicalDefense * (decimal)0.15;
                    StatSupport.Health -= MonsterSTDmgStatSupport;
                }
                else if (randomSelection == 3)
                {
                    decimal MonsterSTDmgCloseRangeDPS = Monster.MagicalAttack - CloseRangeDPS.MagicalDefense * (decimal)0.15;
                    CloseRangeDPS.Health -= MonsterSTDmgCloseRangeDPS;
                }
                else if (randomSelection == 4)
                {
                    decimal MonsterSTDmgLongRangeDPS = Monster.MagicalAttack - LongRangeDPS.MagicalDefense * (decimal)0.15;
                    LongRangeDPS.Health -= MonsterSTDmgLongRangeDPS;
                }
                else if (randomSelection == 5)
                {
                    decimal MonsterSTDmgHealer = Monster.MagicalAttack - Healer.MagicalDefense * (decimal)0.15;
                    Healer.Health -= MonsterSTDmgHealer;
                }

            }
       
        }
        public void MonsterAttacksifStealth(Character Monster, Character Tank, Character StatSupport, Character CloseRangeDPS, Character LongRangeDPS, Character Healer)
        {
            Console.WriteLine($"{CloseRangeDPS} is now stealthed so they have a reduced chance of being hit.");

        }
        public void MonsterAttacksifGuardAllies(Character Monster, Character Tank, Character StatSupport, Character CloseRangeDPS, Character LongRangeDPS, Character Healer)
        {
            Console.WriteLine($"Since Guard Allies is active {Monster.Name} will do less damage.");
            var RedDmg = (Monster.PhysicalAttack - Tank.Defense*(decimal)0.15);
            Tank.Health -= RedDmg;
            StatSupport.Health -= RedDmg;
            CloseRangeDPS.Health -= RedDmg;
            LongRangeDPS.Health -= RedDmg;
            Healer.Health -= RedDmg;

        }
        public void MonsterBigAttacks(Character Monster, Character Tank, Character StatSupport, Character CloseRangeDPS, Character LongRangeDPS, Character Healer)
        {
            int randomSelection;
            Random RandomSTDmg = new Random();
            randomSelection = RandomSTDmg.Next(1, 5);

            if (Monster.Class == "Physical Monster")
            {
                if (randomSelection == 1)
                {
                    decimal MonsterSTDmgTank = Monster.PhysicalAttack - Tank.Defense * (decimal)0.25;
                    Tank.Health -= MonsterSTDmgTank;
                }
                else if (randomSelection == 2)
                {
                    decimal MonsterSTDmgStatSupport = Monster.PhysicalAttack - StatSupport.Defense * (decimal)0.25;
                    StatSupport.Health -= MonsterSTDmgStatSupport;
                }
                else if (randomSelection == 3)
                {
                    decimal MonsterSTDmgCloseRangeDPS = Monster.PhysicalAttack - CloseRangeDPS.Defense * (decimal)0.25;
                    CloseRangeDPS.Health -= MonsterSTDmgCloseRangeDPS;
                }
                else if (randomSelection == 4)
                {
                    decimal MonsterSTDmgLongRangeDPS = Monster.PhysicalAttack - LongRangeDPS.Defense * (decimal)0.25;
                    LongRangeDPS.Health -= MonsterSTDmgLongRangeDPS;
                }
                else if (randomSelection == 5)
                {
                    decimal MonsterSTDmgHealer = Monster.PhysicalAttack - Healer.Defense * (decimal)0.25;
                    Healer.Health -= MonsterSTDmgHealer;
                }
            }
            else if (Monster.Class == "Magical Monster")
            {
                if (randomSelection == 1)
                {
                    decimal MonsterSTDmgTank = Monster.MagicalAttack - Tank.MagicalDefense * (decimal)0.25;
                    Tank.Health -= MonsterSTDmgTank;
                }
                else if (randomSelection == 2)
                {
                    decimal MonsterSTDmgStatSupport = Monster.MagicalAttack - StatSupport.MagicalDefense * (decimal)0.25;
                    StatSupport.Health -= MonsterSTDmgStatSupport;
                }
                else if (randomSelection == 3)
                {
                    decimal MonsterSTDmgCloseRangeDPS = Monster.MagicalAttack - CloseRangeDPS.MagicalDefense * (decimal)0.25;
                    CloseRangeDPS.Health -= MonsterSTDmgCloseRangeDPS;
                }
                else if (randomSelection == 4)
                {
                    decimal MonsterSTDmgLongRangeDPS = Monster.MagicalAttack - LongRangeDPS.MagicalDefense * (decimal)0.25;
                    LongRangeDPS.Health -= MonsterSTDmgLongRangeDPS;
                }
                else if (randomSelection == 5)
                {
                    decimal MonsterSTDmgHealer = Monster.MagicalAttack - Healer.MagicalDefense * (decimal)0.25;
                    Healer.Health -= MonsterSTDmgHealer;
                }

            }
        }
        public void MonsterDeath(Character Monster)
        {
            if(Monster.Health < 0)
            {
                Monster.Health -= Monster.Health;
                Console.WriteLine($"{Monster.Name} has been defeated!");
                Console.WriteLine("Press 1 to exit.");
                Environment.Exit(1);
            }
        }
    }
}
