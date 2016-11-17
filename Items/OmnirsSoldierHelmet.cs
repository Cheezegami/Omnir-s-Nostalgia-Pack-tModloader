using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsSoldierHelmet : ModItem
	{
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Head);
			return true;
		}

		public override void SetDefaults()
		{
            item.name = "Soldier Helmet";
			item.width = 20;
			item.height = 26;
            AddTooltip("Can be used with the chain armor and legs.");
			item.value = 160;
			item.defense = 2;
		}
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("OmnirsChainArmor") && legs.type == mod.ItemType("OmnirsChainGreaves");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+2 Defense";
            player.statDefense += 2;
        }
	}
}