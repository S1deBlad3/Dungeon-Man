using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonMan.Entity
{
     class Entity
    {

        public int health { get; set; }
        public int attack;
        public int defense;


         public virtual int damageTaken(int attack)
        {
            return health -= attack;
        }

        public int attackTarget(int attack)
        {

            Random random = new Random();

            return random.Next(0, attack);

        }



    }
}
