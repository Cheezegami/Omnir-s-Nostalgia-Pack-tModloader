using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsMagicPlateArmor : ModItem
	{

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Body);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Magic Plate Armor";
            item.width = 20;
            item.height = 20;
            AddTooltip("Fueled by a magical gem in the chest.\n+20% melee speed\n-20% mana cost\n20% not to consume ammo.");
            item.value = 4000000;
            item.rare = 9;
            item.defense = 15;
        }

        public override void UpdateEquip(Player player)
        {
            player.meleeSpeed += 0.20f;
            player.manaCost -= 0.20f;
            player.ammoCost80 = true;
        }
	}
}