using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsRedHood : ModItem
	{
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Head);
			return true;
		}

		public override void SetDefaults()
		{
            item.name = "Red Hood";
			item.width = 20;
			item.height = 26;
            item.toolTip = "Red Equipment made from the strongest leather.";
            AddTooltip2("+20% ranged critical chance.");
			item.value = 7000000;
			item.rare = 10;
			item.defense = 13;
		}

        public override void UpdateEquip(Player player)
        {
            player.rangedCrit += 20;
        }

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
            return body.type == mod.ItemType("OmnirsRedJacket") && legs.type == mod.ItemType("OmnirsRedLeggings");
		}

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+30% ranged damage";
            player.rangedDamage += 0.30f;
        }
	}
}