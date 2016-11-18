using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsDragonScaleMail : ModItem
	{

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Body);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Dragon Scale Mail";
            item.width = 20;
            item.height = 20;
            AddTooltip("Of the oldest known chestpieces.");
            AddTooltip2("+9% melee speed, -9% mana cost, 20% not to consume ammo.");
            item.value = 640000;
            item.rare = 7;
            item.defense = 15;
        }

        public override void UpdateEquip(Player player)
        {
            player.meleeSpeed += 0.09f;
            player.manaCost -= 0.09f;
            player.ammoCost80 = true;
        }
	}
}