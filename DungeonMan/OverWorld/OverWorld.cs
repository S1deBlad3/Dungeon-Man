using System;
using System.Collections.Generic;
using System.Text;
using DungeonMan.Entity;
using DungeonMan.Battle;


namespace DungeonMan.OverWorld
{
    

    /*
     * Class for main GameLoop
     */


    class OverWorld { 
    //Variables for "OverWorld"
    
        Enemy enemy;
        BattleMap battle;
        Random random;
        public static Player player;





        //Instance of player, if not yet created it will create a new player

            //IMPORTANT TODO: ADD A CLASS THAT SAVES THE PLAYER SINCE IT GETS DESTROYED EVERY ENCOUNTER?
        public OverWorld()
        {

            if (player == null)
            {
                player = new Player();

            }
        
           
                //Console.WriteLine("This console dont like me :(");
                
            // Starts a new worldMove
                OverWorldMove();
          
        }



   

        /*
         * Main Game Loop
        */
        public void OverWorldMove() {
        
            // As long as the player has health then the game runs
        while (player.health >= 0)
            {

                Console.WriteLine("What do you want to do do?");
                Console.Write("Move, walk, explore or");
                MainEntry.changeColor(ConsoleColor.Red);
                Console.Write(" exit \n");
                MainEntry.ClearColor();
                Console.WriteLine("test");
                

                MainEntry.originalLineLeft = Console.CursorLeft;
                MainEntry.originalLineTop = Console.CursorTop;
                MainEntry.updateDebug();

                Console.BufferHeight += 20;

                //Gets the input
                string decision = Console.ReadLine();

                //See if the input matches any of the actions available
                switch (decision)
                {
                    case "walk":
                        random = new Random();
                        MainEntry.ClearWindow();
                        

                        //Debug code
                        bool enemyEncounter = true;
                        //Calculate a random number 50% chance for the player to be attacked
                        //bool enemyEncounter = (random.Next(0, 10) > 5) ? true : false;
                        Console.WriteLine("Procent Chance:: {0}", enemyEncounter);

                        if (enemyEncounter)
                        {
                            //Creates a new Instance of a enemy using the player as refrence (using player.class fields)
                            MainEntry.updateDebug();
                            battle = new BattleMap(ref player, new Enemy());

                            
                           
                        }
                        else
                        {
                            Console.WriteLine("Did not find anything \n");
                            //Debug
                            MainEntry.updateDebug();  
                            continue;

                        }
                        break;
                    
                    
                    case "move":
                        Console.WriteLine("Where do you want to go? The City, Your home, Explore, or Back");
                        string input = Console.ReadLine();

                        switch (input)
                        {
                            case "City":
                                City.City city = new City.City(ref player);
                                Console.WriteLine("City");
                                break;
                            case "Home":
                                break;
                            case "Explore":
                                break;
                            case "Back":
                                break;
                        }

                        break;


                    case "exit":
                        BattleMap.gameOver();
                        break;

                    default:
                        MainEntry.RightDebug();
                        continue;


                        
                }






                break;

            }

            

        }







    }
}
