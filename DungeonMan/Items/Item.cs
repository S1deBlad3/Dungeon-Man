using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonMan.Items
{
    class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public  float BASEPRICE { get; set; }
        public int attackStat { get; set; }
        protected int defendStat { get; set; }
        public float rarity { get; set; }

        


        public virtual void Use(Item item)
        {
            
        }

        public virtual void Discard(Item item)
        {

        }




    }
}
