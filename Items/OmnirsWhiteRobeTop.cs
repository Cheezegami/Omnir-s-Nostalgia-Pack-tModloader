using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsWhiteRobeTop : ModItem
	{

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Body);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "White Robe Top";
            item.width = 20;
            item.height = 20;
            AddTooltip("Robe made for those who use white magic.");
            AddTooltip2("-20% mana cost.");
            item.value = 9000000;
            item.rare = 10;
            item.defense = 13;
        }

        public override void UpdateEquip(Player player)
        {
            player.manaCost -= 0.20f;
        }
	}
}