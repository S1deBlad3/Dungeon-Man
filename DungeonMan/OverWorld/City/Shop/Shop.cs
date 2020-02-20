using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonMan.OverWorld.City.Shop
{
    class Shop
    {

        Entity.Player player;
        City city;
        //Item class and amount in store
        //SortedList<Items.Item, int> items = new SortedList<Items.Item, int>();
        List<Items.Item> shopinv = new List<Items.Item>();
        Items.Misc.Money money = new Items.Misc.Money();
        
        bool inShop = false;

        //All the buyable objects
        Items.Weapons.Basic_Sword basicSword = new Items.Weapons.Basic_Sword();
        Items.Weapons.Advanced_Sword advancedSword = new Items.Weapons.Advanced_Sword();
        Items.Potions.HealthPotion potion = new Items.Potions.HealthPotion();
        



        public Shop(ref Entity.Player player)
        {
            this.player = player;

            //Whatever goes in here
            Items.Weapons.Advanced_Sword.InStore = 5;
            Items.Weapons.Basic_Sword.InStore = 2;
            Items.Potions.HealthPotion.InStore = 40;
            
            
            //add basic items
            //items.Add(advancedSword = new Items.Weapons.Advanced_Sword(), Items.Weapons.Advanced_Sword.InStore);
            //items.Add(money = new Items.Misc.Money(), 250);
            shopinv.Add(advancedSword);
            shopinv.Add(basicSword);
            shopinv.Add(potion);
            money.ShopMoney = 250f;
            


            //

            inShop = true;
            ShopMove();
        }


        public void ShopMove()
        {
            while (inShop)
            {

                Console.WriteLine("Buy or Sell");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "buy":

                        loopInventory();

                        Console.WriteLine("We have {0} money to trade with", money.ShopMoney);

                        string buyOrder = Console.ReadLine();

                        switch (buyOrder)
                        {
                            case "advanced":
                                if(Items.Misc.Money.amountInWallet >= advancedSword.BASEPRICE)
                                {

                                    Console.WriteLine(Items.Weapons.Advanced_Sword.InStore);

                                    player.inv.Add(advancedSword);
                                    Items.Misc.Money.amountInWallet -= advancedSword.BASEPRICE;
                                    money.ShopMoney += advancedSword.BASEPRICE;
                                    shopinv.Remove(advancedSword);
                                    shopinv.Add(advancedSword);
                                    Items.Weapons.Advanced_Sword.InStore--;


                                    Console.WriteLine(Items.Weapons.Advanced_Sword.InStore);
                                } else
                                {
                                    Console.WriteLine("You aint got ze muneys");
                                }
                                break;

                            case "basic":


                                if (Items.Misc.Money.amountInWallet >= basicSword.BASEPRICE)
                                {

                                    Console.WriteLine(Items.Weapons.Advanced_Sword.InStore);

                                    player.inv.Add(basicSword);
                                    Items.Misc.Money.amountInWallet -= basicSword.BASEPRICE;
                                    money.ShopMoney += basicSword.BASEPRICE;
                                    shopinv.Remove(basicSword);
                                    shopinv.Add(basicSword);
                                    Items.Weapons.Basic_Sword.InStore--;


                                    Console.WriteLine(Items.Weapons.Basic_Sword.InStore);
                                }
                                else
                                {
                                    Console.WriteLine("You aint got ze muneys");
                                }

                                break;

                            case "potion":


                                if (Items.Misc.Money.amountInWallet >= potion.BASEPRICE)
                                {

                                    Console.WriteLine("How many?");
                                    Console.WriteLine("You can buy a max of : " + Math.Floor(Items.Misc.Money.amountInWallet / potion.BASEPRICE));
                                    string amount = Console.ReadLine();

                                    if(Convert.ToInt32(amount) > Items.Potions.HealthPotion.InStore){
                                        Console.WriteLine("cant buy more than we have");
                                    }


                                    Console.WriteLine(Items.Potions.HealthPotion.InStore);

                                    player.inv.Add(potion);
                                    Items.Potions.HealthPotion.AmountInInv += Convert.ToInt32(amount);
                                    Items.Misc.Money.amountInWallet -= potion.BASEPRICE * Convert.ToInt32(amount);
                                    money.ShopMoney += potion.BASEPRICE * Convert.ToInt32(amount);
                                    shopinv.Remove(potion);
                                    shopinv.Add(potion);
                                    Items.Potions.HealthPotion.InStore -= Convert.ToInt32(amount);


                                    Console.WriteLine(Items.Potions.HealthPotion.InStore);
                                }
                                else
                                {
                                    Console.WriteLine("You aint got ze muneys");
                                }

                                break;

                        }

                        break;


                    case "sell":

                        player.listInventory();

                        string sellOrder = Console.ReadLine();

                        switch (sellOrder)
                        {
                            case "advanced":
                                if (money.ShopMoney >= advancedSword.BASEPRICE && player.inv.Contains(advancedSword))
                                {

                                    Console.WriteLine("The amount of items at the start of the stock {0}", Items.Weapons.Advanced_Sword.InStore);

                                    player.inv.Remove(advancedSword);
                                    Items.Misc.Money.amountInWallet += advancedSword.BASEPRICE;
                                    money.ShopMoney -= advancedSword.BASEPRICE;

                                    shopinv.Remove(advancedSword);
                                    shopinv.Add(advancedSword);
                                    Items.Weapons.Advanced_Sword.InStore += 1;

                                    Console.WriteLine("The amount of items left in stock {0}", Items.Weapons.Advanced_Sword.InStore);
                                }
                                else
                                {
                                    Console.WriteLine("We aint got ze muneys");
                                }
                                break;


                            case "potion":


                                if ((money.ShopMoney >= potion.BASEPRICE && player.inv.Contains(potion)))
                                {


                                    Console.WriteLine("how many?");

                                    MainEntry.ShowCoins();

                                    string amount = Console.ReadLine();



                                    if (Convert.ToInt32(amount) > Items.Potions.HealthPotion.AmountInInv)
                                    {
                                        Console.WriteLine("You cant sell more than what you have");
                                        continue;
                                    }
                                    else
                                    {

                                        Console.WriteLine(Items.Potions.HealthPotion.InStore);
                                        


                                        player.inv.Remove(potion);
                                        Items.Potions.HealthPotion.AmountInInv -= Convert.ToInt32(amount);
                                        Items.Misc.Money.amountInWallet += potion.BASEPRICE * Convert.ToInt32(amount);
                                        money.ShopMoney -= potion.BASEPRICE * Convert.ToInt32(amount);
                                        shopinv.Remove(potion);
                                        shopinv.Add(potion);
                                        Items.Potions.HealthPotion.InStore += Convert.ToInt32(amount);


                                        Console.WriteLine(Items.Potions.HealthPotion.InStore);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You aint got ze muneys");
                                }

                                break;


                        }


                        break;

                    case "back":
                        city = new City(ref player);
                        break;


                    default:
                        continue;
                }
            }
        }


        public void loopInventory()
        {
            foreach (var slots in shopinv)
            {
                Console.WriteLine(slots.Name);
                



                
            }
        }




    }
}
