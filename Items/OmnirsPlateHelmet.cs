using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsPlateHelmet : ModItem
	{
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Head);
			return true;
		}

		public override void SetDefaults()
		{
            item.name = "Plate Helmet";
			item.width = 20;
			item.height = 26;
			item.value = 160;
			item.rare = 1;
			item.defense = 2;
		}
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("OmnirsPlateArmor") && legs.type == mod.ItemType("OmnirsPlateGreaves");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+3 Defense";
            player.statDefense += 3;
        }
	}
}