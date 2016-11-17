using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsDwarvenArmor : ModItem
	{

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Body);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Omnirs Dwarven Armor";
            item.width = 20;
            item.height = 20;
            item.value = 32060;
            item.rare = 3;
            item.defense = 5;
        }

        public override void UpdateEquip(Player player)
        {
            player.setBonus = "+4 Defense";
            player.statDefense += 4;
        }
	}
}