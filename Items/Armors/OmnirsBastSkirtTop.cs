using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items.Armors
{
    public class OmnirsBastSkirtTop : ModItem
	{

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Body);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Bast Shirt Top";
            item.width = 18;
            item.height = 18;

            item.value = 2060;
            item.rare = 3;
            item.defense = 1;
        }
	}
}