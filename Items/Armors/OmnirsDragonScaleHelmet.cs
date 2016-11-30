using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items.Armors
{
    public class OmnirsDragonScaleHelmet : ModItem
	{
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Head);
			return true;
		}

		public override void SetDefaults()
		{
            item.name = "Dragon Scale Helmet";
			item.width = 20;
			item.height = 26;
            item.toolTip = "It is made of dragon scales.";
            AddTooltip2("+8% critical chance.");
			item.value = 800000;
			item.rare = 7;
			item.defense = 9;
            
		}

        public override void UpdateEquip(Player player)
        {
            player.rangedCrit += 8;
            player.meleeCrit += 8;
            player.magicCrit += 8;
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