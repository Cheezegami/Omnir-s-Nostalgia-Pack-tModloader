using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items.Armors
{
    public class OmnirsBlackRobeTop : ModItem
	{

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Body);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Black Robe Top";
            item.width = 20;
            item.height = 20;
            AddTooltip("Robe made for those who use black magic.");
            AddTooltip2("-15% mana cost, +5% magic damage.");
            item.value = 9000000;
            item.rare = 10;
            item.defense = 11;
        }

        public override void UpdateEquip(Player player)
        {
            player.manaCost *= 0.85f;
            player.magicDamage += 0.05f;
        }
	}
}