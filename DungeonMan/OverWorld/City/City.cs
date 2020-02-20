using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonMan.OverWorld.City
{
    class City
    {

        //Variables
        OverWorld overworld;
        Entity.Player player;


     public City(ref Entity.Player player)
        {
            this.player = player;
            MainEntry.ClearWindow();
            Console.WriteLine(player.health);
            CityMove();
        }


        public void CityMove()
        {
            while(player.health > 0)
            {
                

                Console.WriteLine("What do you want to do in the city? Go to the shop or exit");
                string input = Console.ReadLine();



                switch (input)
                {
                    case "shop":

                        //Shop scripts
                        new Shop.Shop(ref player);


                        break;
                    case "exit":
                        new OverWorld();
                        break;

                    default:
                        continue;


                }






            }
        }



    }
}
