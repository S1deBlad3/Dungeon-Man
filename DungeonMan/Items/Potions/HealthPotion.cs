using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonMan.Items.Potions
{
    class HealthPotion : Item
    {
        public static int InStore = 0;
        public static int AmountInInv = 0;
        int healthBoost = 15;

        public HealthPotion()
        {
            ID = 4;
            Name = "Health Potion";
            attackStat = 0;
            defendStat = 0;
            BASEPRICE = 8;
            rarity = 0.8f;
              

        }


        public void Use(HealthPotion potion, Entity.Player player)
        {
            player.health += potion.healthBoost;

            Console.WriteLine("You have healed {0} you now have {1}", healthBoost, player.health);
        }


    }
}
