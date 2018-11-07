using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Game
{
    class Tank
    {
        
        public void GuardAll(Character Monster, Character Tank)
        {
            Console.WriteLine($"{Tank.Name} is now guarding all your allies! They will all now take reduced damage.");

            Tank.ManaPool -= 25;
        }
        public void Provoke(Character Monster, Character Tank)
        {
            Console.WriteLine($"{Tank.Name} is provoking the {Monster.Name}. {Tank.Name} will take increased damage but allies will not be hit.");

            Tank.ManaPool -= 15;
        }

       
            
     
       
    }
}
