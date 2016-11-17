using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsGenjiHelmet : ModItem
	{
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Head);
			return true;
		}

		public override void SetDefaults()
		{
            item.name = "Genji Helmet";
			item.width = 20;
			item.height = 26;
            item.toolTip = "Armor from the East.";
            AddTooltip2("+15% melee critical chance.");
			item.value = 900000;
			item.rare = 7;
			item.defense = 15;
		}

        public override void UpdateEquip(Player player)
        {
            player.meleeCrit += 15;
        }

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
            return body.type == mod.ItemType("OmnirsGenjiGreaves") && legs.type == mod.ItemType("OmnirsGenjiArmor");
		}

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+25% melee damage";
            player.meleeDamage += 0.25f;
        }
	}
}