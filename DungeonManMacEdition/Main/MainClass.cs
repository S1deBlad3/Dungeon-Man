using System;
using System.IO;
using DungeonManMacEdition.Main;
using DungeonManMacEdition.Main.Entity;
namespace DungeonManMacEdition
{
    class MainClass
    {

        public static String path = "/Users/mariusdaldorffpedersen/Projects/DungeonManMacEdition/DungeonManMacEdition/Main/Text.txt";

        public OverWorld ov;
        public Player player;


        public MainClass(){

            player = new Player(100, 15, 0);

            setup();


        }

        public void setup(){

            ov = new OverWorld(player);
        }



        public static void space(){
            Console.WriteLine();
            Console.WriteLine();
        }





























        public static void Main(string[] args)
        {
            new MainClass();

        }
    }
}
