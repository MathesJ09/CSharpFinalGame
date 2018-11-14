using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace RPG.Game
{
    class Program 
    {
        

        static void Main()
        {
            string FolderAssembly = Assembly.GetExecutingAssembly().Location;
            string Folder = Path.GetDirectoryName(FolderAssembly);
            string MonsterPath = Folder + @"\Monster.Character.csv";
            string TankPath = Folder + @"\Tank.Character.csv";
            string StatSupportPath = Folder + @"\StatSupport.Character.csv";
            string CloseRangeDPSPath = Folder + @"\CloseRangeDPS.Character.csv";
            string LongRangeDPSPath = Folder + @"\LongRangeDPS.Character.csv";
            string HealerPath = Folder + @"\Healer.Character.csv";

            //Creates all the characters and allows you to rename the monster and characters
            string CreateorNo;
            string MonsterName;
            string MonsterClass;

            Console.WriteLine("Would you like to choose a new monster or use the previous/default one? Type yes to do so.");
            CreateorNo = Console.ReadLine();
            if (CreateorNo == "yes")
            {
                Console.WriteLine("Write your monster name and then your monster class. Monster Class must be Physical Monster or Magical Monster.");
                MonsterName = Console.ReadLine();
                Start:
                MonsterClass = Console.ReadLine();

                if(MonsterClass == "Physical Monster" || MonsterClass == "Magical Monster")
                    using (StreamWriter write = new StreamWriter(MonsterPath))
                    {
                        write.WriteLine(MonsterName + "," + MonsterClass + "," + "4500," + "4500," + "450," + "450," + "200," + "200," + "200," + "200," + "200," + "200," + "50," + "50");
                    }
                    else
                    {
                        Console.WriteLine("You need to choose Physical Monster or Magical Monster. Please enter one or the other.");
                        goto Start;
                    }
            }
            else if (CreateorNo != "yes")
            {
                Console.WriteLine("You choose to use the old/default monster.");
            }
            string RenameorNoTank;
            string TankName;
            Console.WriteLine("Would you like to rename your tank? Type yes to do so.");
            RenameorNoTank = Console.ReadLine();
            if (RenameorNoTank == "yes")
            {
                Console.WriteLine("Write your character name for your tank.");
                TankName = Console.ReadLine();

                using (StreamWriter write = new StreamWriter(TankPath))
                {
                    write.WriteLine(TankName + "," + "Physical Tank" + "," + "1000," + "1000," + "250," + "250," + "100," + "100," + "0," + "0," + "750," + "750," + "500," + "500");
                }
            }
            else if (RenameorNoTank != "yes")
            {
                Console.WriteLine("You choose to use the old/default tank name.");
            }

            string RenameorNoStatSupport;
            string StatSupportName;
            Console.WriteLine("Would you like to rename your stat support? Type yes to do so.");
            RenameorNoStatSupport = Console.ReadLine();
            if (RenameorNoStatSupport == "yes")
            {
                Console.WriteLine("Write your character name for your stat support.");
                StatSupportName = Console.ReadLine();

                using (StreamWriter write = new StreamWriter(StatSupportPath))
                {
                    write.WriteLine(StatSupportName + "," + "Stat Support" + "," + "600," + "600," + "300," + "300," + "150," + "150," + "0," + "0," + "350," + "350," + "350," + "350");
                }
            }
            else if (RenameorNoStatSupport != "yes")
            {
                Console.WriteLine("You choose to use the old/default stat support name.");
            }


            string CreateorNoCloseRDPS;
            string CloseRangeDPSName;
            string CloseRangeDPSClass;

            Console.WriteLine("Would you like to choose a new Close Range DPS or use the previous/default one? Type yes to do so.");
            CreateorNoCloseRDPS = Console.ReadLine();
            if (CreateorNo == "yes")
            {
                Console.WriteLine("Write your character name and then your character class. Close Range DPS Class must be an Assassin, Warrior, or Battle Mage.");
                CloseRangeDPSName = Console.ReadLine();
                Start:
                CloseRangeDPSClass = Console.ReadLine();
                if (CloseRangeDPSClass == "Assassin" || CloseRangeDPSClass == "Warrior" || CloseRangeDPSClass == "Battle Mage")
                    using (StreamWriter write = new StreamWriter(CloseRangeDPSPath))
                    {
                        write.WriteLine(CloseRangeDPSName + "," + CloseRangeDPSClass + "," + "500," + "500," + "250," + "250," + "850," + "850," + "850," + "850," + "200," + "200," + "300," + "300");
                    }
                    else
                    {
                        Console.WriteLine("You need to choose Assassin, Warrior or Battle Mage. Please enter one of those options.");
                        goto Start;
                    }
            }
            else if (CreateorNoCloseRDPS != "yes")
            {
                Console.WriteLine("You choose to use the old/default Close Range DPS.");
            }
            string CreateorNoLongRDPS;
            string LongRangeDPSName;
            string LongRangeDPSClass;

            Console.WriteLine("Would you like to choose a new Long Range DPS or use the previous/default one? Type yes to do so.");
            CreateorNoLongRDPS = Console.ReadLine();
            if (CreateorNo == "yes")
            {
                Console.WriteLine("Write your character name and then your character class. Long Range DPS Class must be a Mage, Archer, or Knife Slinger.");
                LongRangeDPSName = Console.ReadLine();
                Start:
                LongRangeDPSClass = Console.ReadLine();
                if(LongRangeDPSClass == "Mage" || LongRangeDPSClass == "Archer" || LongRangeDPSClass == "Knife Slinger")
                    using (StreamWriter write = new StreamWriter(LongRangeDPSPath))
                    {
                        write.WriteLine(LongRangeDPSName + "," + LongRangeDPSClass + "," + "450," + "450," + "850," + "850," + "700," + "700," + "700," + "700," + "200," + "200," + "350," + "350");
                    }
                    else
                    {
                        Console.WriteLine("You need to choose Mage, Archer or Knife Slinger. Please enter one of those options.");
                        goto Start;
                    }
            }
            else if (CreateorNoLongRDPS != "yes")
            {
                Console.WriteLine("You choose to use the old/default Long Range DPS.");
            }
            string RenameorNoHealer;
            string HealerName;
            Console.WriteLine("Would you like to rename your healer? Type yes to do so.");
            RenameorNoHealer = Console.ReadLine();
            if (RenameorNoHealer == "yes")
            {
                Console.WriteLine("Write your character name for your healer.");
                HealerName = Console.ReadLine();

                using (StreamWriter write = new StreamWriter(HealerPath))
                {
                    write.WriteLine(HealerName + "," + "Healer" + "," + "450," + "450," + "500," + "500," + "0," + "0," + "100," + "100," + "300," + "300," + "300," + "300");
                }
            }
            else if (RenameorNoHealer != "yes")
            {
                Console.WriteLine("You choose to use the old/default healer name.");
            }


            Turns Catt = new Turns()
                {
                    CATT = 0
                };
            Character Monster = ReadMonsterStats(MonsterPath);
            Character Tank = ReadTankStats(TankPath);
            Character StatSupport = ReadStatSupportStats(StatSupportPath);
            Character CloseRangeDPS = ReadCloseRangeDPSStats(CloseRangeDPSPath);
            Character LongRangeDPS = ReadLongRangeDPSStats(LongRangeDPSPath);
            Character Healer = ReadHealerStats(HealerPath);
           

            GameScript GameRun = new GameScript();
            

      
            

       
            //All the methods that run the actual game.
            GameRun.OpeningDialogue();
            GameRun.ShowCharacterStats(Monster, Tank, StatSupport, CloseRangeDPS, LongRangeDPS, Healer);
            //Loops until the monster dies
            do
            {
                GameRun.TankActions(Monster, Tank, StatSupport);
                GameRun.StatSupportActions(Monster, Tank, StatSupport, CloseRangeDPS, LongRangeDPS, Healer);
                GameRun.CloseRangeDPSActions(Monster, Tank, StatSupport, CloseRangeDPS, LongRangeDPS, Healer, Catt);
                GameRun.LongRangeDPSActions(Monster, Tank, StatSupport, CloseRangeDPS, LongRangeDPS, Healer);
                GameRun.HealerActions(Monster, Tank, StatSupport, CloseRangeDPS, LongRangeDPS, Healer);
                GameRun.MonsterActions(Monster, Tank, StatSupport, CloseRangeDPS, LongRangeDPS, Healer, Catt);
 
            } while (Monster.Health >= 0 || Tank.Health <= 0 && StatSupport.Health <= 0 && CloseRangeDPS.Health <= 0 && LongRangeDPS.Health <= 0 && Healer.Health <= 0);



        }
        
        //Stream Readers that get the stats from CSV files.
        public static Character ReadMonsterStats(string MonsterPath)
            {
                var MonsterStats = new Character();
                using (var reader = new StreamReader(MonsterPath))
                {
                    string line = "";
                  
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();
                        string[] values = line.Split(',');
                    Character Monster = new Character();
                    int Health;
                    int MaxHealth;
                    int ManaPool;
                    int MaxManaPool;
                    int PhysicalAttack;
                    int DefaultPhysicalAttack;
                    int MagicalAttack;
                    int DefaultMagicalAttack;
                    int Defense;
                    int DefaultDefense;
                    int MagicalDefense;
                    int DefaultMagicalDefense;

                    Monster.Name = values[0];
                    Monster.Class = values[1];
                    if (int.TryParse(values[2], out Health))
                    {
                        Monster.Health = Health;
                    }
                    if (int.TryParse(values[3], out MaxHealth))
                    {
                        Monster.MaxHealth = MaxHealth;
                    }
                    if (int.TryParse(values[4], out ManaPool))
                    {
                        Monster.ManaPool = ManaPool;
                    }
                    if (int.TryParse(values[5], out MaxManaPool))
                    {
                        Monster.MaxManaPool = ManaPool;
                    }
                    if (int.TryParse(values[6], out PhysicalAttack))
                    {
                        Monster.PhysicalAttack = PhysicalAttack;
                    }
                    if (int.TryParse(values[7], out DefaultPhysicalAttack))
                    {
                        Monster.DefaultPhysicalAttack = DefaultPhysicalAttack;
                    }
                    if (int.TryParse(values[8], out MagicalAttack))
                    {
                        Monster.MagicalAttack = MagicalAttack;
                    }
                    if (int.TryParse(values[9], out DefaultMagicalAttack))
                    {
                        Monster.DefaultMagicalAttack = DefaultMagicalAttack;
                    }
                    if (int.TryParse(values[10], out Defense))
                    {
                        Monster.Defense = Defense;
                    }
                    if (int.TryParse(values[11], out DefaultDefense))
                    {
                        Monster.DefaultDefense = DefaultDefense;
                    }
                    if (int.TryParse(values[12], out MagicalDefense))
                    {
                        Monster.MagicalDefense = MagicalDefense;
                    }
                    if (int.TryParse(values[13], out DefaultMagicalDefense))
                    {
                        Monster.DefaultMagicalDefense = DefaultMagicalDefense;
                    }                 
                    MonsterStats = Monster;
                    }
                }
                return MonsterStats;
            }
        public static Character ReadTankStats(string TankPath)
        {
            var TankStats = new Character();
            using (var reader = new StreamReader(TankPath))
            {
                string line = "";

                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    string[] values = line.Split(',');
                    Character Tank = new Character();

                    int Health;
                    int MaxHealth;
                    int ManaPool;
                    int MaxManaPool;
                    int PhysicalAttack;
                    int DefaultPhysicalAttack;
                    int MagicalAttack;
                    int DefaultMagicalAttack;
                    int Defense;
                    int DefaultDefense;
                    int MagicalDefense;
                    int DefaultMagicalDefense;

                    Tank.Name = values[0];
                    Tank.Class = values[1];
                    if (int.TryParse(values[2], out Health))
                    {
                        Tank.Health = Health;
                    }
                    if (int.TryParse(values[3], out MaxHealth))
                    {
                        Tank.MaxHealth = MaxHealth;
                    }
                    if (int.TryParse(values[4], out ManaPool))
                    {
                        Tank.ManaPool = ManaPool;
                    }
                    if (int.TryParse(values[5], out MaxManaPool))
                    {
                        Tank.MaxManaPool = ManaPool;
                    }
                    if (int.TryParse(values[6], out PhysicalAttack))
                    {
                        Tank.PhysicalAttack = PhysicalAttack;
                    }
                    if (int.TryParse(values[7], out DefaultPhysicalAttack))
                    {
                        Tank.DefaultPhysicalAttack = DefaultPhysicalAttack;
                    }
                    if (int.TryParse(values[8], out MagicalAttack))
                    {
                        Tank.MagicalAttack = MagicalAttack;
                    }
                    if (int.TryParse(values[9], out DefaultMagicalAttack))
                    {
                        Tank.DefaultMagicalAttack = DefaultMagicalAttack;
                    }
                    if (int.TryParse(values[10], out Defense))
                    {
                        Tank.Defense = Defense;
                    }
                    if (int.TryParse(values[11], out DefaultDefense))
                    {
                        Tank.DefaultDefense = DefaultDefense;
                    }
                    if (int.TryParse(values[12], out MagicalDefense))
                    {
                        Tank.MagicalDefense = MagicalDefense;
                    }
                    if (int.TryParse(values[13], out DefaultMagicalDefense))
                    {
                        Tank.DefaultMagicalDefense = DefaultMagicalDefense;
                    }
                    TankStats = Tank;
                }
            }
            return TankStats;
        }
        public static Character ReadStatSupportStats(string StatSupportPath)
        {
            var StatSupportStats = new Character();
            using (var reader = new StreamReader(StatSupportPath))
            {
                string line = "";

                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    string[] values = line.Split(',');
                    Character StatSupport = new Character();

                    int Health;
                    int MaxHealth;
                    int ManaPool;
                    int MaxManaPool;
                    int PhysicalAttack;
                    int DefaultPhysicalAttack;
                    int MagicalAttack;
                    int DefaultMagicalAttack;
                    int Defense;
                    int DefaultDefense;
                    int MagicalDefense;
                    int DefaultMagicalDefense;

                    StatSupport.Name = values[0];
                    StatSupport.Class = values[1];
                    if (int.TryParse(values[2], out Health))
                    {
                        StatSupport.Health = Health;
                    }
                    if (int.TryParse(values[3], out MaxHealth))
                    {
                        StatSupport.MaxHealth = MaxHealth;
                    }
                    if (int.TryParse(values[4], out ManaPool))
                    {
                        StatSupport.ManaPool = ManaPool;
                    }
                    if (int.TryParse(values[5], out MaxManaPool))
                    {
                        StatSupport.MaxManaPool = ManaPool;
                    }
                    if (int.TryParse(values[6], out PhysicalAttack))
                    {
                        StatSupport.PhysicalAttack = PhysicalAttack;
                    }
                    if (int.TryParse(values[7], out DefaultPhysicalAttack))
                    {
                        StatSupport.DefaultPhysicalAttack = DefaultPhysicalAttack;
                    }
                    if (int.TryParse(values[8], out MagicalAttack))
                    {
                        StatSupport.MagicalAttack = MagicalAttack;
                    }
                    if (int.TryParse(values[9], out DefaultMagicalAttack))
                    {
                        StatSupport.DefaultMagicalAttack = DefaultMagicalAttack;
                    }
                    if (int.TryParse(values[10], out Defense))
                    {
                        StatSupport.Defense = Defense;
                    }
                    if (int.TryParse(values[11], out DefaultDefense))
                    {
                        StatSupport.DefaultDefense = DefaultDefense;
                    }
                    if (int.TryParse(values[12], out MagicalDefense))
                    {
                        StatSupport.MagicalDefense = MagicalDefense;
                    }
                    if (int.TryParse(values[13], out DefaultMagicalDefense))
                    {
                        StatSupport.DefaultMagicalDefense = DefaultMagicalDefense;
                    }
                    StatSupportStats = StatSupport;
                }
            }
            return StatSupportStats;
        }
        public static Character ReadCloseRangeDPSStats(string CloseRangeDPSPath)
        {
            var CloseRangeDPSStats = new Character();
            using (var reader = new StreamReader(CloseRangeDPSPath))
            {
                string line = "";

                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    string[] values = line.Split(',');
                    Character CloseRangeDPS = new Character();

                    int Health;
                    int MaxHealth;
                    int ManaPool;
                    int MaxManaPool;
                    int PhysicalAttack;
                    int DefaultPhysicalAttack;
                    int MagicalAttack;
                    int DefaultMagicalAttack;
                    int Defense;
                    int DefaultDefense;
                    int MagicalDefense;
                    int DefaultMagicalDefense;

                    CloseRangeDPS.Name = values[0];
                    CloseRangeDPS.Class = values[1];
                    if (int.TryParse(values[2], out Health))
                    {
                        CloseRangeDPS.Health = Health;
                    }
                    if (int.TryParse(values[3], out MaxHealth))
                    {
                        CloseRangeDPS.MaxHealth = MaxHealth;
                    }
                    if (int.TryParse(values[4], out ManaPool))
                    {
                        CloseRangeDPS.ManaPool = ManaPool;
                    }
                    if (int.TryParse(values[5], out MaxManaPool))
                    {
                        CloseRangeDPS.MaxManaPool = ManaPool;
                    }
                    if (int.TryParse(values[6], out PhysicalAttack))
                    {
                        CloseRangeDPS.PhysicalAttack = PhysicalAttack;
                    }
                    if (int.TryParse(values[7], out DefaultPhysicalAttack))
                    {
                        CloseRangeDPS.DefaultPhysicalAttack = DefaultPhysicalAttack;
                    }
                    if (int.TryParse(values[8], out MagicalAttack))
                    {
                        CloseRangeDPS.MagicalAttack = MagicalAttack;
                    }
                    if (int.TryParse(values[9], out DefaultMagicalAttack))
                    {
                        CloseRangeDPS.DefaultMagicalAttack = DefaultMagicalAttack;
                    }
                    if (int.TryParse(values[10], out Defense))
                    {
                        CloseRangeDPS.Defense = Defense;
                    }
                    if (int.TryParse(values[11], out DefaultDefense))
                    {
                        CloseRangeDPS.DefaultDefense = DefaultDefense;
                    }
                    if (int.TryParse(values[12], out MagicalDefense))
                    {
                        CloseRangeDPS.MagicalDefense = MagicalDefense;
                    }
                    if (int.TryParse(values[13], out DefaultMagicalDefense))
                    {
                        CloseRangeDPS.DefaultMagicalDefense = DefaultMagicalDefense;
                    }
                    CloseRangeDPSStats = CloseRangeDPS;
                }
            }
            return CloseRangeDPSStats;
        }
        public static Character ReadLongRangeDPSStats(string LongRangeDPSPath)
        {
            var LongRangeDPSStats = new Character();
            using (var reader = new StreamReader(LongRangeDPSPath))
            {
                string line = "";

                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    string[] values = line.Split(',');
                    Character LongRangeDPS = new Character();


                    int Health;
                    int MaxHealth;
                    int ManaPool;
                    int MaxManaPool;
                    int PhysicalAttack;
                    int DefaultPhysicalAttack;
                    int MagicalAttack;
                    int DefaultMagicalAttack;
                    int Defense;
                    int DefaultDefense;
                    int MagicalDefense;
                    int DefaultMagicalDefense;

                    LongRangeDPS.Name = values[0];
                    LongRangeDPS.Class = values[1];
                    if (int.TryParse(values[2], out Health))
                    {
                        LongRangeDPS.Health = Health;
                    }
                    if (int.TryParse(values[3], out MaxHealth))
                    {
                        LongRangeDPS.MaxHealth = MaxHealth;
                    }
                    if (int.TryParse(values[4], out ManaPool))
                    {
                        LongRangeDPS.ManaPool = ManaPool;
                    }
                    if (int.TryParse(values[5], out MaxManaPool))
                    {
                        LongRangeDPS.MaxManaPool = ManaPool;
                    }
                    if (int.TryParse(values[6], out PhysicalAttack))
                    {
                        LongRangeDPS.PhysicalAttack = PhysicalAttack;
                    }
                    if (int.TryParse(values[7], out DefaultPhysicalAttack))
                    {
                        LongRangeDPS.DefaultPhysicalAttack = DefaultPhysicalAttack;
                    }
                    if (int.TryParse(values[8], out MagicalAttack))
                    {
                        LongRangeDPS.MagicalAttack = MagicalAttack;
                    }
                    if (int.TryParse(values[9], out DefaultMagicalAttack))
                    {
                        LongRangeDPS.DefaultMagicalAttack = DefaultMagicalAttack;
                    }
                    if (int.TryParse(values[10], out Defense))
                    {
                        LongRangeDPS.Defense = Defense;
                    }
                    if (int.TryParse(values[11], out DefaultDefense))
                    {
                        LongRangeDPS.DefaultDefense = DefaultDefense;
                    }
                    if (int.TryParse(values[12], out MagicalDefense))
                    {
                        LongRangeDPS.MagicalDefense = MagicalDefense;
                    }
                    if (int.TryParse(values[13], out DefaultMagicalDefense))
                    {
                        LongRangeDPS.DefaultMagicalDefense = DefaultMagicalDefense;
                    }
                    LongRangeDPSStats = LongRangeDPS;
                }
            }
            return LongRangeDPSStats;
        }
        public static Character ReadHealerStats(string HealerPath)
        {
            var HealerStats = new Character();
            using (var reader = new StreamReader(HealerPath))
            {
                string line = "";

                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    string[] values = line.Split(',');
                    Character Healer = new Character();

                    int Health;
                    int MaxHealth;
                    int ManaPool;
                    int MaxManaPool;
                    int PhysicalAttack;
                    int DefaultPhysicalAttack;
                    int MagicalAttack;
                    int DefaultMagicalAttack;
                    int Defense;
                    int DefaultDefense;
                    int MagicalDefense;
                    int DefaultMagicalDefense;

                    Healer.Name = values[0];
                    Healer.Class = values[1];
                    if (int.TryParse(values[2], out Health))
                    {
                        Healer.Health = Health;
                    }
                    if (int.TryParse(values[3], out MaxHealth))
                    {
                        Healer.MaxHealth = MaxHealth;
                    }
                    if (int.TryParse(values[4], out ManaPool))
                    {
                        Healer.ManaPool = ManaPool;
                    }
                    if (int.TryParse(values[5], out MaxManaPool))
                    {
                        Healer.MaxManaPool = ManaPool;
                    }
                    if (int.TryParse(values[6], out PhysicalAttack))
                    {
                        Healer.PhysicalAttack = PhysicalAttack;
                    }
                    if (int.TryParse(values[7], out DefaultPhysicalAttack))
                    {
                        Healer.DefaultPhysicalAttack = DefaultPhysicalAttack;
                    }
                    if (int.TryParse(values[8], out MagicalAttack))
                    {
                        Healer.MagicalAttack = MagicalAttack;
                    }
                    if (int.TryParse(values[9], out DefaultMagicalAttack))
                    {
                        Healer.DefaultMagicalAttack = DefaultMagicalAttack;
                    }
                    if (int.TryParse(values[10], out Defense))
                    {
                        Healer.Defense = Defense;
                    }
                    if (int.TryParse(values[11], out DefaultDefense))
                    {
                        Healer.DefaultDefense = DefaultDefense;
                    }
                    if (int.TryParse(values[12], out MagicalDefense))
                    {
                        Healer.MagicalDefense = MagicalDefense;
                    }
                    if (int.TryParse(values[13], out DefaultMagicalDefense))
                    {
                        Healer.DefaultMagicalDefense = DefaultMagicalDefense;
                    }
                    HealerStats = Healer;
                }
            }
            return HealerStats;
        }
    




    }
}
