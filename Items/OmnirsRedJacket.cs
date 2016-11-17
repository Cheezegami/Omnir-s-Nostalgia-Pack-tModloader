using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsRedJacket : ModItem
	{

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Body);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Red Jacket";
            item.width = 20;
            item.height = 20;
            AddTooltip("Red Equipment made from the strongest leather.");
            AddTooltip2("25% chance not to consume ammo.");
            item.value = 9000000;
            item.rare = 10;
            item.defense = 15;
        }

        public override void UpdateEquip(Player player)
        {
            player.ammoCost75 = true;
        }
	}
}