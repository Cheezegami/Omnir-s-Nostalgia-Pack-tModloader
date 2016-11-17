using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsShellArmor : ModItem
	{

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Body);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Shell Armor";
            item.width = 20;
            item.height = 20;
            AddTooltip("Armor made from the shell of a legenadry creature.");
            AddTooltip2("20% chance not to consume ammo.");
            item.value = 200000;
            item.rare = 7;
            item.defense = 11;
        }

        public override void UpdateEquip(Player player)
        {
            player.ammoCost80 = true;
        }
	}
}