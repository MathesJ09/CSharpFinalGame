using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RPG.Game
{

    class GameScript
    {
        string TankAct;
        string StatSupportAct;
        string CloseRangeDPSAct;
        string LongRangeDPSAct;
        string HealerAct;



        public void OpeningDialogue()
        {
            Console.WriteLine("Welcome to the game! The rules are simple. Use your companions below to defeat your enemies! Below is a list of characters including a tank, healer, ranged dps, close range dps, and a stat buffer. Your first enemy will be a giant. He is weak to magic but be careful as he hits incredibly hard on the physical side! Good luck!");
        }
        public void ShowCharacterStats(Character Monster, Character Tank, Character StatSupport, Character CloseRangeDPS, Character LongRangeDPS, Character Healer)
        {
            Console.WriteLine("");
            Console.WriteLine($"{Tank.Name} {Tank.Class} HP:{Tank.Health}/{Tank.MaxHealth} MP:{Tank.ManaPool}/{Tank.MaxManaPool} " +
                $"PhyAtt:{Tank.PhysicalAttack} MagAtt:{Tank.MagicalAttack} PhyDef:{Tank.Defense} MagDef:{Tank.MagicalDefense}");

            Console.WriteLine($"{StatSupport.Name} {StatSupport.Class} HP:{StatSupport.Health}/{StatSupport.MaxHealth} MP:{StatSupport.ManaPool}/{StatSupport.MaxManaPool} " +
                $"PhyAtt:{StatSupport.PhysicalAttack} MagAtt:{StatSupport.MagicalAttack} PhyDef:{StatSupport.Defense} MagDef:{StatSupport.MagicalDefense}");

            Console.WriteLine($"{CloseRangeDPS.Name} {CloseRangeDPS.Class} HP:{CloseRangeDPS.Health}/{CloseRangeDPS.MaxHealth} MP:{CloseRangeDPS.ManaPool}/{CloseRangeDPS.MaxManaPool} " +
                $"PhyAtt:{CloseRangeDPS.PhysicalAttack} MagAtt:{CloseRangeDPS.MagicalAttack} PhyDef:{CloseRangeDPS.Defense} MagDef:{CloseRangeDPS.MagicalDefense}");

            Console.WriteLine($"{LongRangeDPS.Name} {LongRangeDPS.Class} HP:{LongRangeDPS.Health}/{LongRangeDPS.MaxHealth} MP:{LongRangeDPS.ManaPool}/{LongRangeDPS.MaxManaPool} " +
                $"PhyAtt:{LongRangeDPS.PhysicalAttack} MagAtt:{LongRangeDPS.MagicalAttack} PhyDef:{LongRangeDPS.Defense} MagDef:{LongRangeDPS.MagicalDefense}");

            Console.WriteLine($"{Healer.Name} {Healer.Class} HP:{Healer.Health}/{Healer.MaxHealth} MP:{Healer.ManaPool}/{Healer.MaxManaPool} " +
                $"PhyAtt:{Healer.PhysicalAttack} MagAtt:{Healer.MagicalAttack} PhyDef:{Healer.Defense} MagDef:{Healer.MagicalDefense}");
        }
        public void TankActions(Character Monster, Character Tank, Character StatSupport)
        {
            Console.WriteLine("");
            Console.WriteLine($"It's {Tank.Name}'s turn. Select {Tank.Name}'s abilites by using the corresponding number below.");
            Console.WriteLine("Guard Allies = 1");
            Console.WriteLine("Provoke = 2");

            Tank TankAction = new Tank();
        Start:
            TankAct = Console.ReadLine();
            if (TankAct == "1")
            {
                TankAction.GuardAll(Monster, Tank);
            }
            else if (TankAct == "2")
            {
                TankAction.Provoke(Monster, Tank);
            }
            else
            {
                Console.WriteLine($"You must select an action for {Tank.Name} to continue.");
                goto Start;
            }
            Console.WriteLine($"Would you like to continue to {StatSupport.Name}'s turn? Type yes to continue.");
        Start2:
            var ContTTurn = Console.ReadLine();
            if (ContTTurn != "yes")
            {
                Console.WriteLine("You must select yes to continue.");
                goto Start2;
            }

        }
        public void StatSupportActions(Character Monster, Character Tank, Character StatSupport, Character CloseRangeDPS, Character LongRangeDPS, Character Healer)
        {
            Console.WriteLine("");
            Console.WriteLine($"It's {StatSupport.Name}'s turn. Select {StatSupport.Name}'s abilites by using the corresponding number below.");
            Console.WriteLine("Raise Physical Attack and Magical Attack by 50% = 1");
            Console.WriteLine("Raise Physical Defense and Magical Defense by 50% = 2");
            Console.WriteLine($"Debuff {Monster.Name} Physical Attack and Magical Attack by 50% = 3");
            Console.WriteLine($"Debuff {Monster.Name} Physical Defense and Magical Defense by 50% = 4");

            StatSupport StatSupportAction = new StatSupport();
        Start:
            StatSupportAct = Console.ReadLine();
            if (StatSupportAct == "1")
            {
                StatSupportAction.RaiseAttandMag(Tank, StatSupport, CloseRangeDPS, LongRangeDPS, Healer);
            }
            else if (StatSupportAct == "2")
            {
                StatSupportAction.RaiseDefandMagDef(Tank, StatSupport, CloseRangeDPS, LongRangeDPS, Healer);
            }
            else if (StatSupportAct == "3")
            {
                StatSupportAction.DebuffAttandMag(Monster, StatSupport);
            }
            else if (StatSupportAct == "4")
            {
                StatSupportAction.DebuffDefandMagDef(Monster, StatSupport);
            }
            else
            {
                Console.WriteLine($"You must select an action for {StatSupport.Name} to continue.");
                goto Start;
            }
            Console.WriteLine($"Would you like to continue to {CloseRangeDPS.Name}'s turn? Type yes to continue.");
        Start2:
            var ContTTurn = Console.ReadLine();
            if (ContTTurn != "yes")
            {
                Console.WriteLine("You must select yes to continue.");
                goto Start2;
            }
        }
        public void CloseRangeDPSActions(Character Monster, Character Tank, Character StatSupport, Character CloseRangeDPS, Character LongRangeDPS, Character Healer, Turns Catt)
        {
            Console.WriteLine("");
            Console.WriteLine($"It's {CloseRangeDPS.Name}'s turn. Select {CloseRangeDPS.Name}'s abilites by using the corresponding number below.");
            if (CloseRangeDPS.Class == "Assassin")
            {
                Console.WriteLine("Assassinate = 1");
                Console.WriteLine("Stealth = 2");
            }
            else if (CloseRangeDPS.Class == "Warrior")
            {
                Console.WriteLine("Charge Attack = 1");
                Console.WriteLine("Berserk = 2");
            }
            else if (CloseRangeDPS.Class == "Battle Mage")
            {
                Console.WriteLine("Burst Bomb = 1");
                Console.WriteLine("Bubble Shield = 2");
            }

            CloseRangeDPS CloseRangeDPSAction = new CloseRangeDPS();
        Start:
            CloseRangeDPSAct = Console.ReadLine();
            if (CloseRangeDPSAct == "1")
            {
                CloseRangeDPSAction.ChargeStrike(Monster, Tank, CloseRangeDPS, CloseRangeDPS, LongRangeDPS, Healer, Catt);
            }
            else if (CloseRangeDPSAct == "2")
            {
                CloseRangeDPSAction.DefensiveAbility(Monster, Tank, CloseRangeDPS, CloseRangeDPS, LongRangeDPS, Healer);
            }
            else
            {
                Console.WriteLine($"You must select an action for {CloseRangeDPS.Name} to continue.");
                goto Start;
            }
            Console.WriteLine($"Would you like to continue to {LongRangeDPS.Name}'s turn? Type yes to continue.");
        Start2:
            var ContTTurn = Console.ReadLine();
            if (ContTTurn != "yes")
            {
                Console.WriteLine("You must select yes to continue.");
                goto Start2;
            }

        }
        public void LongRangeDPSActions(Character Monster, Character Tank, Character StatSupport, Character CloseRangeDPS, Character LongRangeDPS, Character Healer)
        {
            Console.WriteLine("");
            Console.WriteLine($"It's {LongRangeDPS.Name}'s turn. Select {LongRangeDPS.Name}'s abilites by using the corresponding number below.");
            if (LongRangeDPS.Class == "Mage")
            {
                Console.WriteLine("Meteor = 1");
                Console.WriteLine("Holy= 2");
            }
            else if (LongRangeDPS.Class == "Archer")
            {
                Console.WriteLine("Arrow Rain = 1");
                Console.WriteLine("Full Pull Back = 2");
            }
            else if (LongRangeDPS.Class == "Knife Slinger")
            {
                Console.WriteLine("Knife Rain = 1");
                Console.WriteLine("Excaliber = 2");
            }
            LongRangeDPS LongRangeDPSAction = new LongRangeDPS();
        Start:
            LongRangeDPSAct = Console.ReadLine();
            if (LongRangeDPSAct == "1")
            {
                LongRangeDPSAction.AOEAttack(Monster, Tank, StatSupport, CloseRangeDPS, LongRangeDPS, Healer);
            }
            else if (LongRangeDPSAct == "2")
            {
                LongRangeDPSAction.SingleTarget(Monster, Tank, StatSupport, CloseRangeDPS, LongRangeDPS, Healer);
            }
            else
            {
                Console.WriteLine($"You must select an action for {LongRangeDPS.Name} to continue.");
                goto Start;
            }
            Console.WriteLine($"Would you like to continue to {Healer.Name}'s turn? Type yes to continue.");
        Start2:
            var ContTTurn = Console.ReadLine();
            if (ContTTurn != "yes")
            {
                Console.WriteLine("You must select yes to continue.");
                goto Start2;
            }

        }
        public void HealerActions(Character Monster, Character Tank, Character StatSupport, Character CloseRangeDPS, Character LongRangeDPS, Character Healer)
        {
            Console.WriteLine("");
            Console.WriteLine($"It's {Healer.Name}'s turn. Select {Healer.Name}'s abilites by using the corresponding number below.");
            Console.WriteLine("Heal all Allies = 1");
            Console.WriteLine("Raise an Ally = 2");

            Healer HealerAction = new Healer();
        Start:
            HealerAct = Console.ReadLine();
            if (HealerAct == "1")
            {
                HealerAction.HealAll(Tank, StatSupport, CloseRangeDPS, LongRangeDPS, Healer);
            }
            else if (HealerAct == "2")
            {
                HealerAction.RaiseAlly(Tank, StatSupport, CloseRangeDPS, LongRangeDPS, Healer);
            }
            else
            {
                Console.WriteLine($"You must select an action for {Healer.Name} to continue.");
                goto Start;
            }
            Console.WriteLine($"Would you like to continue to {Monster.Name}'s turn? Type yes to continue.");
        Start2:
            var ContTTurn = Console.ReadLine();
            if (ContTTurn != "yes")
            {
                Console.WriteLine("You must select yes to continue.");
                goto Start2;
            }
        }
        public void MonsterActions(Character Monster, Character Tank, Character StatSupport, Character CloseRangeDPS, Character LongRangeDPS, Character Healer, Turns Catt)
        {
            Monster MonsterAction = new Monster();
            if (Catt.CATT == 0 && CloseRangeDPSAct == "1")
            {
                Catt.CATT += 1;
            }
            else if (Catt.CATT == 1 && CloseRangeDPSAct == "2")
            {
                Catt.CATT -= 1;
            }
            else if (Catt.CATT == 1 && CloseRangeDPSAct != "2")
            {
                Catt.CATT -= 1;
            }
            MonsterAction.MonsterDamageSingleTarget(Monster, Tank, StatSupport, CloseRangeDPS, LongRangeDPS, Healer);
            if (CloseRangeDPSAct == "2" && CloseRangeDPS.Class == "Assassin")
            {
                MonsterAction.MonsterAttacksifStealth(Monster, Tank, StatSupport, CloseRangeDPS, LongRangeDPS, Healer);
            }
            if (TankAct == "1")
            {
                MonsterAction.MonsterAttacksifGuardAllies(Monster, Tank, StatSupport, CloseRangeDPS, LongRangeDPS, Healer);
            }
            else
            {
                MonsterAction.MonsterBigAttacks(Monster, Tank, StatSupport, CloseRangeDPS, LongRangeDPS, Healer);
            }

            Console.WriteLine("");
            Console.WriteLine($"{Tank.Name} {Tank.Class} HP:{Tank.Health}/{Tank.MaxHealth} MP:{Tank.ManaPool}/{Tank.MaxManaPool} " +
                $"PhyAtt:{Tank.PhysicalAttack} MagAtt:{Tank.MagicalAttack} PhyDef:{Tank.Defense} MagDef:{Tank.MagicalDefense}");

            Console.WriteLine($"{StatSupport.Name} {StatSupport.Class} HP:{StatSupport.Health}/{StatSupport.MaxHealth} MP:{StatSupport.ManaPool}/{StatSupport.MaxManaPool} " +
                $"PhyAtt:{StatSupport.PhysicalAttack} MagAtt:{StatSupport.MagicalAttack} PhyDef:{StatSupport.Defense} MagDef:{StatSupport.MagicalDefense}");

            Console.WriteLine($"{CloseRangeDPS.Name} {CloseRangeDPS.Class} HP:{CloseRangeDPS.Health}/{CloseRangeDPS.MaxHealth} MP:{CloseRangeDPS.ManaPool}/{CloseRangeDPS.MaxManaPool} " +
                $"PhyAtt:{CloseRangeDPS.PhysicalAttack} MagAtt:{CloseRangeDPS.MagicalAttack} PhyDef:{CloseRangeDPS.Defense} MagDef:{CloseRangeDPS.MagicalDefense}");

            Console.WriteLine($"{LongRangeDPS.Name} {LongRangeDPS.Class} HP:{LongRangeDPS.Health}/{LongRangeDPS.MaxHealth} MP:{LongRangeDPS.ManaPool}/{LongRangeDPS.MaxManaPool} " +
                $"PhyAtt:{LongRangeDPS.PhysicalAttack} MagAtt:{LongRangeDPS.MagicalAttack} PhyDef:{LongRangeDPS.Defense} MagDef:{LongRangeDPS.MagicalDefense}");

            Console.WriteLine($"{Healer.Name} {Healer.Class} HP:{Healer.Health}/{Healer.MaxHealth} MP:{Healer.ManaPool}/{Healer.MaxManaPool} " +
                $"PhyAtt:{Healer.PhysicalAttack} MagAtt:{Healer.MagicalAttack} PhyDef:{Healer.Defense} MagDef:{Healer.MagicalDefense}");
            Console.WriteLine("");

            Console.WriteLine($"{Monster.Name} {Monster.Class} HP:{Monster.Health}/{Monster.MaxHealth} MP:{Monster.ManaPool}/{Monster.MaxManaPool} " +
                 $"PhyAtt:{Monster.PhysicalAttack} MagAtt:{Monster.MagicalAttack} PhyDef:{Monster.Defense} MagDef:{Monster.MagicalDefense}");

            MonsterAction.MonsterDeath(Monster);
        }





    }
}
