using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsRoyalHelmet : ModItem
	{
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Head);
			return true;
		}

		public override void SetDefaults()
		{
            item.name = "Royal Helmet";
			item.width = 20;
			item.height = 26;
            item.toolTip = "An excellent masterpiece of a smith.";
            AddTooltip2("+4% critical chance.");
            AddTooltip3("Can be used with the golden armor and legs.");
			item.value = 300000;
			item.rare = 6;
			item.defense = 7;
		}

        public override void UpdateEquip(Player player)
        {
            player.rangedCrit += 4;
            player.meleeCrit += 4;
            player.magicCrit += 4;
        }

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
            return body.type == mod.ItemType("OmnirsDragonScaleGreaves") && legs.type == mod.ItemType("OmnirsDragonScaleMail");
		}

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+8% damage, +40 mana";
            player.meleeDamage += 0.08f;
            player.magicDamage += 0.08f;
            player.rangedDamage += 0.08f;
            player.statManaMax2 += 40;
        }
	}
}