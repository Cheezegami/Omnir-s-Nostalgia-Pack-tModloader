using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items.Armors
{
    public class OmnirsBrassArmor : ModItem
	{

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Body);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Brass Armor";
            item.width = 20;
            item.height = 20;
            item.value = 360;
            item.rare = 1;
            item.defense = 3;
        }
	}
}