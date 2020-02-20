using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonMan.Items.Weapons
{
    class Advanced_Sword : Item
    {
        public static int InStore = 0;
        //sets standar values
        public Advanced_Sword()
        {
            ID = 2;
            Name = "Advanced Sword";
            attackStat = 15;
            defendStat = 5;
            BASEPRICE = 15.0f;
            rarity = 0.9f;

            
        }

    }
}
