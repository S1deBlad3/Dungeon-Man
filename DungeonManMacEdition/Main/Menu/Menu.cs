using System;
namespace DungeonManMacEdition.Main.Menu
{
    public class Menu
    {


        //Variables for Menu

        public bool firstLaunch;
        public int selected;
        public bool enterEnterKey = false;
        public bool skipiteration = false;
        public int SizeOfRow;




		//Menu Characters
        public char outLine = '#';
        public string space = " ";
        public char cursor = '*';
        public int size;
        public string[] menuList;


     



        public  Menu()
        {

   


        }


        public virtual void ContextMenu(String[] menuItems, int SizeOfRow)
		{


			menuList = new string[menuItems.Length];

			for (int i = 0; i < menuItems.Length; i++)
			{
				menuList[i] = menuItems[i];
			}

			this.SizeOfRow = SizeOfRow;




			/*
             ############
             # Move #####
             * Attack ###
             * Items ####
             * */

			//Console.Clear();

			MainClass.space();


			Console.WriteLine("What would you like to do?");

            for (int i = 0; i < SizeOfRow; i++){
                Console.Write(outLine);
            }

            Console.WriteLine();

			//Console.WriteLine("#############");

			for (int i = 0; i < menuList.Length; i++)
			{
				Console.Write(outLine + space + space);

                //Implement own EventHandler

                if (i == 0 && selected == 0){
                    //Console.Write(cursor);

                }


				Console.Write(menuList[i]);

				size = menuList[i].Length;

				Console.Write(space);

                for (int padd = size; padd < (SizeOfRow - 4); padd++)
				{
					Console.Write(outLine);
				}


				Console.WriteLine();


				//Console.WriteLine("#############");

				

				size = 0;
			}

			for (int j = 0; j < SizeOfRow; j++)
			{
				Console.Write(outLine);
			}




            //keykontroll();



		}



    } //End Of class
}
