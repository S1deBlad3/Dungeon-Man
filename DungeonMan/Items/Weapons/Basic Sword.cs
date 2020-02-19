using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonMan.Items.Weapons
{
    class Basic_Sword : Item
    {

        public Basic_Sword()
        {
            ID = 1;
            Name = "Basic Sword";
            attackStat = 15;
            defendStat = 5;
            BASEPRICE = 10.0f;
            rarity = 1.0f;
        }


    }
}
