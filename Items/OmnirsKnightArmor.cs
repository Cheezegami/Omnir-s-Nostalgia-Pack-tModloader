using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsKnightArmor : ModItem
	{

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Body);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Knight Armor";
            item.width = 20;
            item.height = 20;
            item.value = 4000;
            item.rare = 2;
            item.defense = 6;
        }
	}
}