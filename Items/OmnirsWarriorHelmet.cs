using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsWarriorHelmet : ModItem
	{
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Head);
			return true;
		}

		public override void SetDefaults()
		{
            item.name = "Warrior Helmet";
			item.width = 20;
			item.height = 26;
			item.value = 5000;
			item.rare = 3;
			item.defense = 5;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
            return body.type == mod.ItemType("OmnirsKnightArmor") && legs.type == mod.ItemType("OmnirsKnightGreaves");
		}

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+5% damage and movement speed";
            player.moveSpeed += 0.05f;
            player.meleeDamage += 0.05f;
            player.magicDamage += 0.05f;
            player.rangedDamage += 0.05f;
        }
	}
}