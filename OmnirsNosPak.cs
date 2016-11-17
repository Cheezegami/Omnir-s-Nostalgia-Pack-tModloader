using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace OmnirsNosPak
{
	public class OmnirsNosPak : Mod //Code is from Zero-Exodus
	{
		public OmnirsNosPak()
		{
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
			};
		}
		public override void AddRecipes()
		{
			VanillaRecipes.Add(this);
		}
		public static bool HasEquipped(int type)
		{
			for (int f = 0; f < 11; f++)
			{
				if (type == Main.player[Main.myPlayer].armor[f].type)
				{
					return true;
				}
			}
			return false;
		}
	}
}