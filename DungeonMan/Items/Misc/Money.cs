using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonMan.Items.Misc
{
    class Money : Item


    {
        //sets the standard variables like what 1 gold is worth
        public static float amountInWallet = 800f;
        public const int VALUEOFMONEY = 1;
        public float ShopMoney;

        //Objects
        static Random random;

        //sets the values
        public Money()
        {
            ID = 3;
            BASEPRICE = VALUEOFMONEY;
            rarity = 1f;
        }

        //calculates what amount of money the enemy drops after death
        public static int EnemyDropMoney()
        {
            random = new Random();
            double fix = random.NextDouble();
            int cointDrop = random.Next(0, 20);
            double coin = cointDrop * fix;

            Console.WriteLine(fix);
            Console.WriteLine(cointDrop);
            Console.WriteLine(coin);


            return Convert.ToInt32(coin);



        }

    }
}
