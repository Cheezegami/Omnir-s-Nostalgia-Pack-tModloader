using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsSauronsArmor : ModItem
	{

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Body);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Armor of Sauron";
            item.width = 20;
            item.height = 20;
            AddTooltip("Crafted to withstand the greatest of weapons.");
            AddTooltip2("+25% melee speed.");
            item.value = 20000000;
            item.rare = 10;
            item.defense = 30;
        }

        public override void UpdateEquip(Player player)
        {
            player.meleeSpeed += 0.25f;
        }
	}
}