using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsGoldenHelmet : ModItem
	{
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Head);
			return true;
		}

		public override void SetDefaults()
		{
            item.name = "Golden Helmet";
			item.width = 20;
			item.height = 26;
            item.toolTip = "It is the famous Helmet of the Stars.";
            AddTooltip2("+5% ranged and melee critical chance.");
			item.value = 300000;
			item.rare = 8;
			item.defense = 12;
		}

        public override void UpdateEquip(Player player)
        {
            player.rangedCrit += 5;
            player.meleeCrit += 5;
        }

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
            return body.type == mod.ItemType("OmnirsGoldenArmor") && legs.type == mod.ItemType("OmnirsGoldenGreaves");
		}

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+5% melee and ranged damage";
            player.meleeDamage += 0.05f;
            player.rangedDamage += 0.05f;
        }
	}
}