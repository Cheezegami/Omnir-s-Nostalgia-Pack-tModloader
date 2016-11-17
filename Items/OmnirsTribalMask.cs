using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsTribalMask : ModItem
	{
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Head);
			return true;
		}

		public override void SetDefaults()
		{
            item.name = "Tribal Mask";
			item.width = 20;
			item.height = 26;
			item.value = 2500;
			item.rare = 3;
			item.defense = 1;
		}
        public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
        {
            drawAltHair = true;
        }
	}
}