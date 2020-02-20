using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonMan.Entity
{
    class Enemy : Entity
    {
        private OverWorld.OverWorld OverWorld;

       
       //sets standard values

        public Enemy()
        {
            health = 150;
            attack = 5;
            defense = 5;
        }

        /*
       * Override the entity method and takes the damage that comes from battlemap
       */
        public override int damageTaken(int attack)
        {
            //Outdated method, got moved
            if(this.health <= 0)
            {
                /*
                Battle.BattleMap.score++;
                //debug code
                int dropedMoney = Items.Misc.Money.EnemyDropMoney();
                Items.Misc.Money.amountInWallet += dropedMoney;

                Console.WriteLine("Enemy dropped {0} gold and you have {1} in your wallet", dropedMoney, Items.Misc.Money.amountInWallet);

                dropedMoney = 0;
                EnemyDead();
                return 0;
                */
            }
            //gets the health left after the damage
            return health -= attack;
        }

        //creates a new instance of overWorld
        public void EnemyDead()
        {
            OverWorld = new OverWorld.OverWorld();
        }


    }
}
