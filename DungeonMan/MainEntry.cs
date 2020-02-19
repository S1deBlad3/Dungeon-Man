using DungeonMan.Battle;
using DungeonMan.Entity;
using DungeonMan.OverWorld;
using System;


namespace DungeonMan
{
    class MainEntry
    {
        //Variables for Debug alignment
        public static int originalLineTop;
        public static int originalLineLeft;
        public static int offsideLineTop = 20;
        public static int offSideLineLeft = 80;



        //Constructor to start the application and setup the console
        public MainEntry()
        {
            setupConsole();

        }

        //Setup for the console. Set the title, color, with and height
        public void setupConsole()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorVisible = true;
            Console.Title = "Dungeon Man";
            //Console.SetBufferSize(120, 100);
            //Console.SetWindowSize(120, 40);
            Console.WriteLine("Console Height :  " +  Console.BufferHeight + "  Console Width  :   " +  Console.BufferWidth);
            Console.WriteLine("Console Window Height :  " + Console.WindowHeight + "  Console Window Width  :   " + Console.WindowWidth);
            Console.WriteLine("Console Position Left :  " + Console.WindowLeft + "  Console Position Top  :   " + Console.WindowTop);


            //Sets the original alignment (might delete in the future)
           originalLineTop =  Console.CursorTop;
            originalLineLeft = Console.CursorLeft;

        



        }


        // A debug text to see and keep track of variables
        public static void updateDebug()
        {
            //Console.SetCursorPosition(offSideLineLeft, offsideLineTop);
            Console.Write("\n \n");
            Console.WriteLine("*************************");
            Console.WriteLine("Debug : Score {0}", BattleMap.turns);
            Console.WriteLine("Cursor left :" + Console.CursorLeft);
            Console.WriteLine("Cursor top : " + Console.CursorTop);
            Console.WriteLine("*************************");
            

            //Console.SetCursorPosition(++originalLineLeft, ++originalLineTop);
        }

        /*
         * Various console commands:
         * change the color
         * clear the color from ^
         * clear the window - takes away everything on the screen
         */

        public static void changeColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        public static void ClearColor()
        {
            Console.ResetColor();
        }

        public static void ClearWindow()
        {
            Console.Clear();
        }

        // Main Metod were we create a new instance of the MainEntry and setup the World (Game Loop)
        static void Main(string[] args)
        {
            

           
           
            new MainEntry();

            OverWorld.OverWorld world = new OverWorld.OverWorld();

        

            
          

            //BattleMap battle = new BattleMap();
            //battle.nextMove();
            //Console.ReadLine();



        }

   
        
       



    }
}
