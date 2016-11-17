using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsCrystalArmor : ModItem
	{

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Body);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Crystal Armor";
            item.width = 20;
            item.height = 20;
            AddTooltip("Dazzling armor cut from crystal");
            AddTooltip2("+30% melee speed.");
            item.value = 9000000;
            item.rare = 10;
            item.defense = 20;
        }

        public override void UpdateEquip(Player player)
        {
            player.meleeSpeed += 0.30f;
        }
	}
}