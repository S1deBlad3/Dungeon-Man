using DungeonMan.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonMan.Battle
{
    class BattleMap
    {

        Player player;
        Enemy enemy;

        public static int turns { get; set; }
        public static int score { get; set; }

        public static bool auto = false;

        public BattleMap(ref Player player, Enemy enemy)
        {
            this.player = player;
            this.enemy = enemy;
            init();
            
        }

       public void init()
        {
            //Init
           

            //Sets score, gold and turn


            Console.WriteLine("Please decide what to do");
            nextMove();
        }
        /*
         * A game over that ends the application and displays the score
         */
        public static void gameOver()
        {
            Console.WriteLine("Game Over you lasted : {0} turns, earned {1} gold and had a score of {2}", turns, Items.Misc.Money.amountInWallet, score);

            Environment.Exit(0);
        }

        /*
        * The main battle loop
        */

        public void nextMove()
        {

            int damageDone = 0;
            int damageTaken = 0;


            string order1 = "attack";
            string[] order2 = { "Switch weapon", "switch", "weapon", "switch weapon" };

            //Main loop for battle, here the player can decide actions

            while (player.health >= 1)
            {
                Console.Write("\n Attack" + " or " + "Switch weapon \n" );

                

                string input = Console.ReadLine();
                Console.WriteLine();

                //checks wheter the input of the player matches the ones that are allowed
                if (input.Equals(order1))
                {
                    //debug code for auto run
                    if (auto)
                    {
                        while (enemy.health >= 0)
                        {
                            //debug code

                            damageDone = player.attackTarget(player.attack);
                            enemy.damageTaken(damageDone);
                            WriteAttackToScreen(damageDone);

                            //An attack classes as a turn
                            turns++;

                            damageTaken = enemy.attackTarget(enemy.attack);
                            player.damageTaken(damageTaken);
                            WriteAttackToScreenToPlayer(damageTaken);

                            if (enemy.health <= 0)
                            {

                                Battle.BattleMap.score++;
                                //debug code
                                int dropedMoney = Items.Misc.Money.EnemyDropMoney();
                                Items.Misc.Money.amountInWallet += dropedMoney;

                                Console.WriteLine("Enemy dropped {0} gold and you have {1} in your wallet", dropedMoney, Items.Misc.Money.amountInWallet);

                                dropedMoney = 0;
                                enemy.EnemyDead();

                            }

                        }
                    }
                    else
                    {


                        //Sends the damage done by the player to the enemy
                        damageDone = player.attackTarget(player.attack);
                        enemy.damageTaken(damageDone);
                        WriteAttackToScreen(damageDone);

                        //An attack classes as a turn
                        turns++;
                        //Gets the amount of damage the enemy has gotten
                        damageTaken = enemy.attackTarget(enemy.attack);
                        player.damageTaken(damageTaken);
                        WriteAttackToScreenToPlayer(damageTaken);

                        //When the enemy has less or = to 0 health it will end the encounter
                        if(enemy.health <= 0)
                        {


                            Battle.BattleMap.score++;
                            //debug code
                            int dropedMoney = Items.Misc.Money.EnemyDropMoney();
                            Items.Misc.Money.amountInWallet += dropedMoney;

                            Console.WriteLine("Enemy dropped {0} gold and you have {1} in your wallet", dropedMoney, Items.Misc.Money.amountInWallet);

                            dropedMoney = 0;
                            Console.WriteLine();
                            enemy.EnemyDead();


                        }


                    }

                }
                //Debug Code
                else if (input.Contains("kill"))
                {
                    player.damageTaken(100);
                }
                else if (input.Contains("enemydie"))
                {
                    damageDone = player.attackTarget(300);
                    enemy.damageTaken(damageDone);
                    WriteAttackToScreen(damageDone);

                    
                }
                else if (input.Contains("auto"))
                {
                    auto = (!auto) ? true : false;
                    Console.WriteLine("Auto attack activated or deactivated {0}", auto);
                    
                }

                /*
                * This loop is used to display and get what item to use. The variable selected weapon turns to ID that gets sent to player.class 
                */
                foreach (string order in order2)
                {
                    
                        
                        

                        if (input.Contains(order))
                        {
                            player.listInventory();

                            string selectedWeapon = Console.ReadLine();


                            switch (selectedWeapon)
                            {
                                case "Basic Sword":
                                case "basic":
                                case "Basic sword":
                                case "basic sword":
                                    player.weaponSelected = 1;
                                    player.GetCurrentWeapon();
                                    Console.WriteLine("You have selected {0} \n", player.weaponSelected);
                                    break;

                                case "Fist":
                                case "fist":
                                    player.weaponSelected = 0;
                                    player.GetCurrentWeapon();
                                    break;
                                case "Advanced Sword":
                                case "advanced sword":
                                case "advanced":
                                    player.weaponSelected = 2;
                                    player.GetCurrentWeapon();
                                    Console.WriteLine("You have seleted {0}", player.weaponSelected);
                                    break;


                                case "exit":
                                    nextMove();
                                    break;

                                default:
                                    Console.WriteLine("You did not select anything. Must have done something wrong.");
                                    nextMove();
                                    break;

                            }


                        }
                    break;


                }
                    
                


             
                

            }
            //If the player dies it's game over
            gameOver();

        }

        /*
       * Method for printing out the attack to the enemy
       */
        public void WriteAttackToScreen(int damage)
        {

            
            Console.Write("Damage done to monster: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("{0}", damage);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" It has ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("{0}", enemy.health);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" left");
            
        }

        /*
       * Method for printing out the attack done to the player by the enemy
       */
        public void WriteAttackToScreenToPlayer(int damage)
        {

            Console.WriteLine();
            Console.Write("Damage Taken from monster: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("{0}", damage);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" You Have ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("{0}", player.health);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" left \n");

            Console.BufferHeight += 20;



        }


    }
}

