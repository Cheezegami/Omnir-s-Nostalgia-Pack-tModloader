using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsSecondAgeElvenHelmet : ModItem
	{
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Head);
			return true;
		}

		public override void SetDefaults()
		{
            item.name = "Elven Greaves of the Second Age";
			item.width = 20;
			item.height = 26;
            item.toolTip = "Elven greaves present at Sauron's downfall.";
            AddTooltip2("Allows firewalking, +30% movement speed.");
			item.value = 500000;
			item.rare = 9;
			item.defense = 8;
		}

        public override void UpdateEquip(Player player)
        {
            player.rangedCrit += 20;
            player.meleeCrit += 20;
            player.magicCrit += 20;
        }

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
            return body.type == mod.ItemType("OmnirsSecondAgeElvenArmor") && legs.type == mod.ItemType("OmnirsSecondAgeElvenGreaves");
		}

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+40% damage";
            player.meleeDamage += 0.4f;
            player.magicDamage += 0.4f;
            player.rangedDamage += 0.4f;
        }
	}
}