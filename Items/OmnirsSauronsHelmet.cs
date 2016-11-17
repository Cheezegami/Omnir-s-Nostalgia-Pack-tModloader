using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsSauronsHelmet : ModItem
	{
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Head);
			return true;
		}

		public override void SetDefaults()
		{
            item.name = "Helmet of Sauron";
			item.width = 20;
			item.height = 26;
            item.toolTip = "Crafted by and for the Sauron";
            AddTooltip2("+10% Critical Chance.");
			item.value = 15000000;
			item.rare = 10;
			item.defense = 25;
		}

        public override void UpdateEquip(Player player)
        {
            player.rangedCrit += 10;
            player.meleeCrit += 10;
            player.magicCrit += 10;
        }

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
            return body.type == mod.ItemType("OmnirsDragonScaleGreaves") && legs.type == mod.ItemType("OmnirsDragonScaleMail");
		}

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+25% damage";
            player.meleeDamage += 0.25f;
            player.magicDamage += 0.25f;
            player.rangedDamage += 0.25f;
        }
	}
}