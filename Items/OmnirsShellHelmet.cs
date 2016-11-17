using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsShellHelmet : ModItem
	{
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Head);
			return true;
		}

		public override void SetDefaults()
		{
            item.name = "Shell Helmet";
			item.width = 20;
			item.height = 26;
            item.toolTip = "Armor made from the shell of a legenadry creature.";
            AddTooltip2("+15% ranged critical chance.");
			item.value = 900000;
			item.rare = 7;
			item.defense = 10;
		}

        public override void UpdateEquip(Player player)
        {
            player.rangedCrit += 15;
        }

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
            return body.type == mod.ItemType("OmnirsShellArmor") && legs.type == mod.ItemType("OmnirsShellGreaves");
		}

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+20% ranged damage";
            player.rangedDamage += 0.20f;
        }
	}
}