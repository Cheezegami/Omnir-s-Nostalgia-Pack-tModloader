using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items // Code modified from Zero-Exodus's code :)
{
    public class OmnirsSunBlade : ModItem
	{
		public override void SetDefaults() 
		{
            item.name = "Sun Blade";
			item.width = 36;
			item.height = 36;
			item.damage = 43;
			item.knockBack = 9;
            item.toolTip = "A sword used to kill the undead.";
            item.scale = 1;
			item.rare = 7;
			item.value = 160000;
			item.useSound = 1;
			item.useStyle = 1;
			item.useTime = 21;
			item.useAnimation = 23;
			item.melee = true;
		}
        /* public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
         {
              if (npc.type == 3 || npc.type == 21 || npc.type == 31 || npc.type == 32 || npc.type == 34 || npc.type == 35 || npc.type == 36 || npc.type == 44 || npc.type == 45 || npc.type == 52 || npc.type == 53 || npc.type == 68 ||
                  npc.type == 77 || npc.type == 78 || npc.type == 79 || npc.type == 80 || npc.type == 82 || npc.type == 110 || npc.type == 132 || npc.type == 140 || npc.type == 158 || npc.type == 159 || npc.type == 161 || npc.type == 162 ||
                  npc.type == 167 || npc.type == 172 || npc.type == 186 || npc.type == 187 || npc.type == 188 || npc.type == 189 || npc.type == 197 || npc.type == 200 || npc.type == 201 || npc.type == 202 || npc.type == 203 || npc.type == 223 ||
                  npc.type == 251 || npc.type == 254 || npc.type == 255 || npc.type == 269 || npc.type == 270 || npc.type == 270 || npc.type == 271 || npc.type == 272 || npc.type == 273 || npc.type == 274 || npc.type == 275 || npc.type == 276 ||
                  npc.type == 277 || npc.type == 278 || npc.type == 279 || npc.type == 280 || npc.type == 281 || npc.type == 282 || npc.type == 283 || npc.type == 284 || npc.type == 285 || npc.type == 286 || npc.type == 287 || npc.type == 288 ||
                  npc.type == 289 || npc.type == 290 || npc.type == 291 || npc.type == 292 || npc.type == 293 || npc.type == 294 || npc.type == 295 || npc.type == 296 || npc.type == 316 || npc.type == 319 || npc.type == 320 || npc.type == 321 ||
                  npc.type == 322 || npc.type == 323 || npc.type == 324 || npc.type == 330 || npc.type == 331 || npc.type == 332 || npc.type == 338 || npc.type == 339 || npc.type == 340 ||
                  (NPC.AnyNPCs(NPCDef.byName["OmnirsNosPak:OmnirsCryptShambler"].type)) || (NPC.AnyNPCs(NPCDef.byName["OmnirsNosPak:OmnirsTheEarthFiendLich"].type)) || (NPC.AnyNPCs(NPCDef.byName["OmnirsNosPak:OmnirsRottingGhoul"].type))
                ) damage *= 4;
          }*/
    }
}