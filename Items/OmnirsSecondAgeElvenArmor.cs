using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsSecondAgeElvenArmor : ModItem
	{

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Body);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Elven Armor of the Second Age";
            item.width = 20;
            item.height = 20;
            AddTooltip("Elven armor present at Sauron's downfall.");
            AddTooltip2("+40% melee speed.");
            item.value = 1000000;
            item.rare = 10;
            item.defense = 9;
        }

        public override void UpdateEquip(Player player)
        {
            player.meleeSpeed += 0.4f;
        }
	}
}