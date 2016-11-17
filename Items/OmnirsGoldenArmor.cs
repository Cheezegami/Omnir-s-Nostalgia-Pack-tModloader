using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsGoldenArmor : ModItem
	{

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Body);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Golden Armor";
            item.width = 20;
            item.height = 20;
            AddTooltip("A lost prince's armor.");
            AddTooltip2("+7% melee speed, 20% not to consume ammo.");
            item.value = 240000;
            item.rare = 7;
            item.defense = 14;
        }

        public override void UpdateEquip(Player player)
        {
            player.meleeSpeed += 0.07f;
            player.ammoCost80 = true;
        }
	}
}