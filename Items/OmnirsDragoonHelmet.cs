using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsDragoonHelmet : ModItem
	{
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Head);
			return true;
		}

		public override void SetDefaults()
		{
            item.name = "Dragoon Helmet";
			item.width = 20;
			item.height = 26;
            item.toolTip = "Dragon armor that the Dragoons wear.";
            AddTooltip2("+10% melee critical chance.");
			item.value = 350000;
			item.rare = 5;
			item.defense = 7;
		}

        public override void UpdateEquip(Player player)
        {
            player.meleeCrit += 10;
        }

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
            return body.type == mod.ItemType("OmnirsDragoonGreaves") && legs.type == mod.ItemType("OmnirsDragoonArmor");
		}

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+15% melee damage, +10 defense.";
            player.meleeDamage += 0.15f;
            player.statDefense += 10;
        }
	}
}