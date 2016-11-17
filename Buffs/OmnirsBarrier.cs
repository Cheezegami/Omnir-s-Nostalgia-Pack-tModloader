using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OmnirsNosPak.Buffs
{
    public class OmnirsBarrier : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffName[this.Type] = "Barrier Spell";
            Main.buffTip[this.Type] = "Spell adds 16 to defense";
            Main.debuff[Type] = false;
            Main.pvpBuff[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense += 16;
            player.buffTime[buffIndex] = 10;
        }
    }
}