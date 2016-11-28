using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items.Armors
{
    public class OmnirsBeholderHelmet : ModItem
	{
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Head);
			return true;
		}

		public override void SetDefaults()
		{
            item.name = "Beholder Helmet";
			item.width = 20;
			item.height = 26;
            item.toolTip = "+2 Critical Chance";
            AddTooltip2("Can be used with the crown armor and legs.");
			item.value = 300000;
			item.rare = 3;
			item.defense = 7;
		}

        public override void UpdateEquip(Player player)
        {
            player.rangedCrit += 2;
            player.meleeCrit += 2;
            player.magicCrit += 2;
        }

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
            return body.type == mod.ItemType("OmnirsCrownArmor") && legs.type == mod.ItemType("OmnirsCrownGreaves");
		}

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+15% melee damage";
            player.meleeDamage *= 1.15f;
        }
	}
}