using System;
using System.Collections.Generic;
using System.Text;
using DungeonMan.Items;

namespace DungeonMan.Entity
{
    class Player : Entity
    {

        //int[] inventory = new int[3];

        // public SortedList<string, int> inv = new SortedList<string, int>();
        public List<Items.Item> inv = new List<Items.Item>();
         //public SortedList<Items.Item, int> inv = new SortedList<Items.Item, int>();

        public int weaponSelected = 0;
       int curWeaponDamage;

        //Define Weapons
        


        public Player()
        {

            health = 100;
            attack = 15 + curWeaponDamage;
            defense = 5;

            //inv.Add("Fist", 0);
            //inv.Add("Basic Sword", 10);
            //inv.Add("Advanced Sword", 20);
            inv.Add(new Items.Weapons.Fist());
            inv.Add(new Items.Weapons.Basic_Sword());
            //inv.Add(new Items.Weapons.Advanced_Sword());
            /*
            inventory[0] = 0;
            inventory[1] = 10;
            inventory[2] = 20;

    */
            GetCurrentWeapon();

            Console.WriteLine(curWeaponDamage);

           
        }


        /*
         * A method that cycles through the inv list and get whatever value that was of the weapon ID that was selected.
         */

        public void GetCurrentWeapon()
        {
            //Remake

            foreach (var slots in inv)
            {
                if (slots.ID == weaponSelected)
                {
                    //Sets the damage to the correct weapon and print out the name and damage
                    curWeaponDamage = slots.attackStat;
                    Console.WriteLine();
                    Console.WriteLine("what");
                    Console.WriteLine("The selected weapon is {0}  and you do maximum of {1} Damage", slots.Name, GetMaxDamage());
                    break;
                } 
            }

            

            Console.WriteLine(curWeaponDamage);

        }


        /*
         * A method to list the inventory on the screen 
         */
        public void listInventory()
        {
            foreach (var slots in inv)
            {

                Console.Write("* ");
                //Console.Write(slots.Key);
                Console.Write(slots.Name);
                Console.Write("  *");
                Console.WriteLine();
                //Console.WriteLine(slots.Value);
                for (int i = 0; i < slots.Name.Length; i++)
                {
                    
                    Console.Write("*");
                    
                }
               
                Console.Write("*****");
                Console.WriteLine();
               // Console.WriteLine(slots.ID);
                //Console.WriteLine(slots.Name);
                //Console.WriteLine(slots.BASEPRICE);
                
              //  Console.WriteLine(slots.Key);
            }
        }

        /*
         * Returns the maximum damage of the player
         */
        public int GetMaxDamage()
        {
            return attack + curWeaponDamage;
        }

    }
}
