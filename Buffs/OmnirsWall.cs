using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OmnirsNosPak.Buffs
{
	public class OmnirsWall : ModBuff
	{
        public override void SetDefaults()
        {
            Main.buffName[this.Type] = "Wall Spell";
            Main.buffTip[this.Type] = "Spell adds 36 to defense";
            Main.debuff[Type] = false;
            Main.pvpBuff[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense += 36;
            player.buffTime[buffIndex] = 10;
        }
	}
}

