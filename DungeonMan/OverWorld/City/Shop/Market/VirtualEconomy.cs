using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonMan.OverWorld.City.Shop.Market
{

    
   
    class VirtualEconomy
    {

        //Objects and refrences

        
        Items.Item item = new Items.Item();
        Entity.Player player;


        //extra varibales

        int baseAmount;
        int newBase;



        public VirtualEconomy(ref Entity.Player player)
        {

            this.player = player;
            





        }



        public int SupplyCurvePotions(Items.Item item, int amount)
        {

            baseAmount = Items.Potions.HealthPotion.InStore;
            int expectedAmount = baseAmount / 10;
            int purchasedAmount = amount;
            
            int newPrice;
            int m = 0;
            m = (int)((item.rarity * baseAmount) / 100 * purchasedAmount);
            Console.WriteLine("M = {0}", m);

            newPrice = (int)Math.Ceiling(item.BASEPRICE + m);
            
            Console.WriteLine("The regular price is = {0}", newPrice);





            return 0;
        }

        public int SupplyCurvePotionsRegular(Items.Item item)
        {

            baseAmount = Items.Potions.HealthPotion.InStore;
            int expectedAmount = baseAmount / 10;
            int newPrice;
            int m = 0;
            newPrice = (int)(((item.rarity * baseAmount) / 100 * baseAmount) + item.BASEPRICE);
            Console.WriteLine("The regular price is = {0}", newPrice);





            return 0;
        }




    }
}
