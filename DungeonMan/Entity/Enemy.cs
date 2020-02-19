using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonMan.Entity
{
    class Enemy : Entity
    {
        private OverWorld.OverWorld OverWorld;

       
       

        public Enemy()
        {
            health = 150;
            attack = 5;
            defense = 5;
        }


        public override int damageTaken(int attack)
        {

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
     
            return health -= attack;
        }


        public void EnemyDead()
        {
            OverWorld = new OverWorld.OverWorld();
        }


    }
}
