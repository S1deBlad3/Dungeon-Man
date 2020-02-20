using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonMan.Entity
{
     class Entity
    {
        //Standard variables
        public int health { get; set; }
        public int attack;
        public int defense;

        //The abstract method of damagetaken
         public virtual int damageTaken(int attack)
        {
            return health -= attack;
        }
        //the abstract method of attacking
        public int attackTarget(int attack)
        {

            Random random = new Random();

            return random.Next(0, attack);

        }



    }
}
