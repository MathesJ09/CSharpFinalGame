using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Game
{
    class Healer
    {
        public void HealAll(Character Tank, Character StatSupport, Character CloseRangeDPS, Character LongRangeDPS, Character Healer)
        {
            if (Tank.Health <= Tank.MaxHealth && Tank.Health > 0 && Tank.Health <= Tank.Health - (decimal)200)
            {
                Console.WriteLine($"{Tank.Name} had 200 health restored.");
                Tank.Health += 200;
                Healer.ManaPool -= 35;
            }
            else if (Tank.Health == Tank.MaxHealth)
            {
                Console.WriteLine($"{ Tank.Name } is already at max health.");
            }
            else if (Tank.Health == 0)
            {
                Console.WriteLine($"{ Tank.Name } is currently dead. Please use raise to revive your ally.");
            }
            else if (Tank.Health > Tank.MaxHealth - (decimal)200)
            {
                var DiffinHealth1 = Tank.MaxHealth - Tank.Health;
                Tank.Health += DiffinHealth1;
                Healer.ManaPool -= 35;
                Console.WriteLine($"{Tank.Name} had {DiffinHealth1} health restored.");
            }

            //Stat Support Heal

            if (StatSupport.Health <= StatSupport.MaxHealth && StatSupport.Health > 0 && StatSupport.Health <= StatSupport.Health - (decimal)200)
            {
                Console.WriteLine($"{StatSupport.Name} had 200 health restored.");
                StatSupport.Health += 200;
                Healer.ManaPool -= 35;
            }
            else if (StatSupport.Health == StatSupport.MaxHealth)
            {
                Console.WriteLine($"{ StatSupport.Name } is already at max health.");
            }
            else if (StatSupport.Health == 0)
            {
                Console.WriteLine($"{ StatSupport.Name } is currently dead. Please use raise to revive your ally.");
            }
            else if (StatSupport.Health > StatSupport.MaxHealth - (decimal)200)
            {
                var DiffinHealth2 = StatSupport.MaxHealth - StatSupport.Health;
                StatSupport.Health += DiffinHealth2;
                Healer.ManaPool -= 35;
                Console.WriteLine($"{StatSupport.Name} had {DiffinHealth2} health restored.");
            }

            //Close Ranged DPS Heal

            if (CloseRangeDPS.Health <= CloseRangeDPS.MaxHealth && CloseRangeDPS.Health > 0 && CloseRangeDPS.Health <= CloseRangeDPS.Health - (decimal)200)
            {
                Console.WriteLine($"{CloseRangeDPS.Name} had 200 health restored.");
                CloseRangeDPS.Health += 200;
                Healer.ManaPool -= 35;
            }
            else if (CloseRangeDPS.Health == CloseRangeDPS.MaxHealth)
            {
                Console.WriteLine($"{ CloseRangeDPS.Name } is already at max health.");
            }
            else if (CloseRangeDPS.Health == 0)
            {
                Console.WriteLine($"{ CloseRangeDPS.Name } is currently dead. Please use raise to revive your ally.");
            }
            else if (CloseRangeDPS.Health > CloseRangeDPS.MaxHealth - (decimal)200)
            {
                var DiffinHealth3 = CloseRangeDPS.MaxHealth - CloseRangeDPS.Health;
                CloseRangeDPS.Health += DiffinHealth3;
                Healer.ManaPool -= 35;
                Console.WriteLine($"{CloseRangeDPS.Name} had {DiffinHealth3} health restored.");
            }

            //Long Range DPS Heal

            if (LongRangeDPS.Health <= LongRangeDPS.MaxHealth && LongRangeDPS.Health > 0 && LongRangeDPS.Health <= LongRangeDPS.Health - (decimal)200)
            {
                Console.WriteLine($"{LongRangeDPS.Name} had 200 health restored.");
                LongRangeDPS.Health += 200;
                Healer.ManaPool -= 35;
            }
            else if (LongRangeDPS.Health == LongRangeDPS.MaxHealth)
            {
                Console.WriteLine($"{ LongRangeDPS.Name } is already at max health.");
            }
            else if (LongRangeDPS.Health == 0)
            {
                Console.WriteLine($"{ LongRangeDPS.Name } is currently dead. Please use raise to revive your ally.");
            }
            else if (LongRangeDPS.Health > LongRangeDPS.MaxHealth - (decimal)200)
            {
                var DiffinHealth4 = LongRangeDPS.MaxHealth - LongRangeDPS.Health;
                LongRangeDPS.Health += DiffinHealth4;
                Healer.ManaPool -= 35;
                Console.WriteLine($"{LongRangeDPS.Name} had {DiffinHealth4} health restored.");
            }

            //Healer Heal

            if (Healer.Health <= Healer.MaxHealth && Healer.Health > 0 && Healer.Health <= Healer.Health - (decimal)200)
            {
                Console.WriteLine($"{Healer.Name} had 200 health restored.");
                Healer.Health += 200;
                Healer.ManaPool -= 35;
            }
            else if (Healer.Health == Healer.MaxHealth)
            {
                Console.WriteLine($"{ Healer.Name } is already at max health.");
            }
            else if (Healer.Health == 0)
            {
                Console.WriteLine($"{ Healer.Name } is currently dead. Please use raise to revive your ally.");
            }
            else if (Healer.Health > Healer.MaxHealth - (decimal)200)
            {
                var DiffinHealth5 = Healer.MaxHealth - Healer.Health;
                Healer.Health += DiffinHealth5;
                Healer.ManaPool -= 35;
                Console.WriteLine($"{Healer.Name} had {DiffinHealth5} health restored.");
            }

        }
        public void RaiseAlly(Character Tank, Character StatSupport, Character CloseRangeDPS, Character LongRangeDPS, Character Healer)
        {
            Console.WriteLine("Select the ally to revive by typing in their name.");
            var TargetRaise = Console.ReadLine();

            //Tank KO
            if (Tank.Health <= 0 && TargetRaise == Tank.Name)
            {
                Console.WriteLine($"{Tank.Name} was revived.");
                Tank.Health += Tank.MaxHealth * (decimal)0.5;
                Healer.ManaPool -= 50;
            }
            else if (Tank.Health > 0 && TargetRaise == Tank.Name)
            {
                Console.WriteLine($"{Tank.Name} is still alive.");
            }
            //StatSupport KO
            if (StatSupport.Health <= 0 && TargetRaise == StatSupport.Name)
            {
                Console.WriteLine($"{StatSupport.Name} was revived.");
                StatSupport.Health += StatSupport.MaxHealth * (decimal)0.5;
                Healer.ManaPool -= 50;
            }
            else if (StatSupport.Health > 0 && TargetRaise == StatSupport.Name)
            {
                Console.WriteLine($"{StatSupport.Name} is still alive.");
            }
            //CloseRangeDPS KO
            if (CloseRangeDPS.Health <= 0 && TargetRaise == CloseRangeDPS.Name)
            {
                Console.WriteLine($"{CloseRangeDPS.Name} was revived.");
                CloseRangeDPS.Health += CloseRangeDPS.MaxHealth * (decimal)0.5;
                Healer.ManaPool -= 50;
            }
            else if (CloseRangeDPS.Health > 0 && TargetRaise == CloseRangeDPS.Name)
            {
                Console.WriteLine($"{CloseRangeDPS.Name} is still alive.");
            }
            //LongRangeDPS KO
            if (LongRangeDPS.Health <= 0 && TargetRaise == LongRangeDPS.Name)
            {
                Console.WriteLine($"{LongRangeDPS.Name} was revived.");
                LongRangeDPS.Health += LongRangeDPS.MaxHealth * (decimal)0.5;
                Healer.ManaPool -= 50;
            }
            else if (LongRangeDPS.Health > 0 && TargetRaise == LongRangeDPS.Name)
            {
                Console.WriteLine($"{LongRangeDPS.Name} is still alive.");
            }
            //Healer KO
            if (Healer.Health <= 0 && TargetRaise == Healer.Name)
            {
                Console.WriteLine($"{Healer.Name} was revived.");
                Healer.Health += Healer.MaxHealth * (decimal)0.5;
                Healer.ManaPool -= 50;
            }
            else if (Healer.Health > 0 && TargetRaise == Healer.Name)
            {
                Console.WriteLine($"{Healer.Name} is still alive.");
            }


        }

    }
}
