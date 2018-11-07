using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RPG.Game
{
    interface ICharacter
    {

        void BasicAttack();
        void Defend();
        void UseItem();
    
    }
}
