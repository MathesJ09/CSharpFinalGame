using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Game
{
    class GameScript
    {
        public void OpeningDialogue()
        {
            Console.WriteLine("Welcome to the game! The rules are simple. Use your companions below to defeat your enemies! Below is a list of characters including a tank, healer, ranged dps, close range dps, and a stat buffer. Your first enemy will be a giant. He is weak to magic but be careful as he hits incredibly hard on the physical side! Good luck!");
        }
        public void ShowCharacterStats(int[] PhysicalTank, int[] Healer, int[] Mage, int[] Assassin, int[] StatBuffer)
        {
            int TankHealth = PhysicalTank[0];
            int TankMaxHealth = PhysicalTank[1];
            int TankManaPool = PhysicalTank[2];
            int TankMaxManaPool = PhysicalTank[3];
            int TankPhysicalAttack = PhysicalTank[4];
            int TankMagicalAttack = PhysicalTank[5];
            int TankPhysicalDefense = PhysicalTank[6];
            int TankMagicalDefense = PhysicalTank[7];

            int HealerHealth = Healer[0];
            int HealerMaxHealth = Healer[1];
            int HealerManaPool = Healer[2];
            int HealerMaxManaPool = Healer[3];
            int HealerPhysicalAttack = Healer[4];
            int HealerMagicalAttack = Healer[5];
            int HealerPhysicalDefense = Healer[6];
            int HealerMagicalDefense = Healer[7];

            int MageHealth = Mage[0];
            int MageMaxHealth = Mage[1];
            int MageManaPool = Mage[2];
            int MageMaxManaPool = Mage[3];
            int MagePhysicalAttack = Mage[4];
            int MageMagicalAttack = Mage[5];
            int MagePhysicalDefense = Mage[6];
            int MageMagicalDefense = Mage[7];

            int AssassinHealth = Assassin[0];
            int AssassinMaxHealth = Assassin[1];
            int AssassinManaPool = Assassin[2];
            int AssassinMaxManaPool = Assassin[3];
            int AssassinPhysicalAttack = Assassin[4];
            int AssassinMagicalAttack = Assassin[5];
            int AssassinPhysicalDefense = Assassin[6];
            int AssassinMagicalDefense = Assassin[7];

            int StatBufferHealth = StatBuffer[0];
            int StatBufferMaxHealth = StatBuffer[1];
            int StatBufferManaPool = StatBuffer[2];
            int StatBufferMaxManaPool = StatBuffer[3];
            int StatBufferPhysicalAttack = StatBuffer[4];
            int StatBufferMagicalAttack = StatBuffer[5];
            int StatBufferPhysicalDefense = StatBuffer[6];
            int StatBufferMagicalDefense = StatBuffer[7];

            Console.WriteLine("Your tank stats: " + 
                "HP: " + TankHealth + "/" + 
                 TankMaxHealth + " " +
                "MP: " + TankManaPool + "/" +
                TankMaxManaPool + " " +
                "Phys.Att: "  + TankPhysicalAttack + " " +
                "Mag.Att: " + TankMagicalAttack + " " +
                "Phys.Def: " + TankPhysicalDefense + " " +
                "Mag.Def: " + TankMagicalDefense + ".");

                Console.WriteLine("Your Healer stats: " + 
                "HP: " + HealerHealth + "/" + 
                HealerMaxHealth + " " +
                "MP: " + HealerManaPool + "/" +
                HealerMaxManaPool + " " +
                "Phys.Att: "  + HealerPhysicalAttack + " " +
                "Mag.Att: " + HealerMagicalAttack + " " +
                "Phys.Def: " + HealerPhysicalDefense + " " +
                "Mag.Def: " + HealerMagicalDefense + ".");

                Console.WriteLine("Your Mage stats: " + 
                "HP: " + MageHealth + "/" + 
                MageMaxHealth + " " +
                "MP: " + MageManaPool + "/" +
                MageMaxManaPool + " " +
                "Phys.Att: "  + MagePhysicalAttack + " " +
                "Mag.Att: " + MageMagicalAttack + " " +
                "Phys.Def: " + MagePhysicalDefense + " " +
                "Mag.Def: " + MageMagicalDefense + ".");

                Console.WriteLine("Your Assassin stats: " + 
                "HP: " + AssassinHealth + "/" + 
                AssassinMaxHealth + " " +
                "MP: " + AssassinManaPool + "/" +
                AssassinMaxManaPool + " " +
                "Phys.Att: "  + AssassinPhysicalAttack + " " +
                "Mag.Att: " + AssassinMagicalAttack + " " +
                "Phys.Def: " + AssassinPhysicalDefense + " " +
                "Mag.Def: " + AssassinMagicalDefense + ".");

                Console.WriteLine("Your StatBuffer stats: " + 
                "HP: " + StatBufferHealth + "/" + 
                StatBufferMaxHealth + " " +
                "MP: " + StatBufferManaPool + "/" +
                StatBufferMaxManaPool + " " +
                "Phys.Att: "  + StatBufferPhysicalAttack + " " +
                "Mag.Att: " + StatBufferMagicalAttack + " " +
                "Phys.Def: " + StatBufferPhysicalDefense + " " +
                "Mag.Def: " + StatBufferMagicalDefense + ".");
        }
        public void GiantArrives(int[] Giant)
        {
            int GiantHealth = Giant[0];
            int GiantMaxHealth = Giant[1];
            int GiantManaPool = Giant[2];
            int GiantMaxManaPool = Giant[3];
            int GiantAttack = Giant[4];
            int GiantMagicalAttack = Giant[5];
            int GiantDefense = Giant[6];
            int GiantMagicalDefense = Giant[7];

             Console.WriteLine("Your Giant stats: " + 
             "HP: " + GiantHealth + "/" + 
             GiantMaxHealth + " " +
             "MP: " + GiantManaPool + "/" +
             GiantMaxManaPool + " " +
             "Phys.Att: "  + GiantAttack + " " +
             "Mag.Att: " + GiantMagicalAttack + " " +
             "Phys.Def: " + GiantDefense + " " +
             "Mag.Def: " + GiantMagicalDefense + ".");


        }
        //Show your character Stats
        //Show your opponent / Giant
        //Begin Fight Turn Class ++1
        //Characters Get Turns in order of Tank, Close Ranged DPS, Ranged DPS, Buffer, Healer
        // Opponent Turn

    }
}
