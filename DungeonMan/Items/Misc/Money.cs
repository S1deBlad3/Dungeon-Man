using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonMan.Items.Misc
{
    class Money : Item


    {

        public static float amountInWallet;
        public const int VALUEOFMONEY = 1;

        //Objects
        static Random random;


        public Money()
        {
            ID = 3;
            BASEPRICE = VALUEOFMONEY;
            rarity = 1f;
        }


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
