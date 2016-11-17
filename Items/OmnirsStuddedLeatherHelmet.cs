using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsStuddedLeatherHelmet : ModItem
	{
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Head);
			return true;
		}

		public override void SetDefaults()
		{
            item.name = "Studded Leather Helmet";
			item.width = 20;
			item.height = 26;
			item.value = 72;
		}
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("OmnirsStuddedLeatherArmor") && legs.type == mod.ItemType("OmnirsStuddedLeatherGreaves");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+2 Defense";
            player.statDefense += 2;
        }
	}
}