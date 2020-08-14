using System;
namespace DungeonManMacEdition.Main.Entity.Enemy
{
    public class HardEnemy : Entity
    {
        public HardEnemy(int health, int damage, int defense) : base(health, damage, defense)
        {
            base.health = health;
            base.attack = damage;
            base.defense = defense;

            base.name = "Hard Enemy";

			base.xp = 50;
			base.gold = 10;


        }
    }
}
