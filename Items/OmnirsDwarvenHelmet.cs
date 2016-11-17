using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsDwarvenHelmet : ModItem
	{
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Head);
			return true;
		}

		public override void SetDefaults()
		{
            item.name = "Dwarven Helmet";
			item.width = 20;
			item.height = 26;
			item.value = 40000;
			item.rare = 2;
			item.defense = 4;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
            return body.type == mod.ItemType("OmnirsDragonScaleGreaves") && legs.type == mod.ItemType("OmnirsDragonScaleMail");
		}

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+4 Defense";
            player.statDefense += 4;
        }
	}
}