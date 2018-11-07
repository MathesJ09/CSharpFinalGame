using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace RPG.Game
{
    class Character 
    {

        public string Name { get; set; }
        public string Class { get; set; }
        public decimal Health { get; set; }
        public decimal MaxHealth { get; set; }
        public decimal ManaPool { get; set; }
        public decimal MaxManaPool { get; set; }
        public decimal PhysicalAttack { get; set; }
        public decimal DefaultPhysicalAttack { get; set; }
        public decimal MagicalAttack { get; set; }
        public decimal DefaultMagicalAttack { get; set; }
        public decimal Defense { get; set; }
        public decimal DefaultDefense { get; set; }
        public decimal MagicalDefense { get; set; }
        public decimal DefaultMagicalDefense { get; set; }
       


    }

}
