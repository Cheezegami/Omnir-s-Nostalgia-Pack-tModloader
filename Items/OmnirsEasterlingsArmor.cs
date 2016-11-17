using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsEasterlingsArmor : ModItem
	{

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Body);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Armor of the Easterlings";
            item.width = 20;
            item.height = 20;
            AddTooltip("Enchanted armor of the Easterlings.");
            AddTooltip2("Melee speed increased by 2%");
            item.value = 4000;
            item.rare = 1;
            item.defense = 6;
        }

        public override void UpdateEquip(Player player)
        {
            player.meleeSpeed += 0.02f;
        }
	}
}