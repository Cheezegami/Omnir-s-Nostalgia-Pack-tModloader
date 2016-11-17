using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
	public class OmnirsFathersMask : ModItem
	{
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Head);
			return true;
		}

		public override void SetDefaults()
		{
            item.name = "Father's Mask";
			item.width = 20;
			item.height = 26;
            item.toolTip = "Best looking mask in the game.";
            AddTooltip2("23% increased movement speed");
			item.value = 100000;
			item.rare = 8;
			item.defense = 9;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
            return body.type == mod.ItemType("OmnirsGiantArmor") && legs.type == mod.ItemType("OmnirsGiantGreaves");
		}

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+15% melee damage";
            player.meleeDamage *= 0.15f;
        }
	}
}