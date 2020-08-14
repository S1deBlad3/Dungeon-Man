using System;
namespace DungeonManMacEdition.Main.Items
{
    public class Items
    {

        public int cost;
        public int damage;
        public float rarity;
        public int defense;
        public String Name;
        public int ID;
        public int Amount;



        public Items(int cost)
        {
            this.cost = cost;
        }

        public Items(int cost, int damage){

            this.cost = cost;
            this.damage = damage;


        }
		public Items(int cost, int damage, int rarity)
		{

			this.cost = cost;
			this.damage = damage;
            this.rarity = rarity;


		}
		public Items(int cost, int damage, int rarity, int defense)
		{

			this.cost = cost;
            this.damage = damage;
            this.rarity = rarity;
            this.defense = defense;

		}
		public Items()
		{

		}


        public virtual void Use(){
            
        }


        public int getDamage(){
            return damage;
        }

        public int getCost(){
            return cost;
        }


    }


}
