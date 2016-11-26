using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OmnirsNosPak.NPCs
{
    public class OmnirsTibianSwampTroll : ModNPC
    {
        float customAi1;
        int OTimeLeft = 2000;
        bool walkAndShoot = false;

        bool canDrown = true;
        int drownTimerMax = 1200;
        int drownTimer = 1200;
        int drowningRisk = 500;

        float npcAcSPD = 0.02f; //How fast they accelerate.
        float npcSPD = 0.8f; //Max speed

        bool tooBig = false;
        bool lavaJumping = false;

        #region Spawn
        public override float CanSpawn(NPCSpawnInfo spawnInfo)
        {
            Tile tile = Main.tile[spawnInfo.spawnTileX, spawnInfo.spawnTileY];
            return (!spawnInfo.desertCave) ? 0.5f : 0f;
        }
        #endregion
        //Spawns on the Surface and Underground in the Jungle. Does not spawn in Hardmode, if Town NPCs are nearby, or if Player reaches more than 140 health.


        public override void SetDefaults()
        {
            npc.name = "Swamp Troll";
            npc.lifeMax = 35;
            npc.damage = 8;
            npc.defense = 3;
            npc.knockBackResist = 0.5f;
            npc.width = 20;
            npc.height = 40;
            npc.aiStyle = 3; // Copied Zombie AI to get behavior.
            npc.soundHit = 1;
            npc.soundKilled = 1;
            npc.value = Item.buyPrice(0, 0, 0, 10);
            npc.buffImmune[BuffID.Poisoned] = true;
            npc.buffImmune[BuffID.Venom] = true;
            Main.npcFrameCount[npc.type] = 15;
            animationType = 21;
            //banner = npc.type;
            //bannerItem = mod.ItemType("Swamp Troll");
        }

        public override void AI()
        {
            npc.noGravity = false;
            npc.spriteDirection = npc.direction;
            #region shoot and walk
            if (walkAndShoot && Main.netMode != 1 && !Main.player[npc.target].dead) // can generalize this section to moving+projectile code // can generalize this section to moving+projectile code
            {
            }
            #endregion
            #region drown // code by Omnir
            if (canDrown)
            {
                if (!npc.wet)
                {
                    npc.TargetClosest(true);
                    drownTimer = drownTimerMax;
                }
                if (npc.wet)
                {
                    drownTimer--;
                }
                if (npc.wet && drownTimer > drowningRisk)
                {
                    npc.TargetClosest(true);
                }
                else if (npc.wet && drownTimer <= drowningRisk)
                {
                    npc.TargetClosest(false);
                    if (npc.timeLeft > 10)
                    {
                        npc.timeLeft = 10;
                    }
                    npc.directionY = -1;
                    if (npc.velocity.Y > 0f)
                    {
                        npc.direction = 1;
                    }
                    npc.direction = -1;
                    if (npc.velocity.X > 0f)
                    {
                        npc.direction = 1;
                    }
                }
                if (drownTimer <= 0)
                {
                    npc.life--;
                    if (npc.life <= 0)
                    {
                        Main.PlaySound(4, (int)npc.position.X, (int)npc.position.Y, 1);
                        npc.NPCLoot();
                        npc.netUpdate = true;
                    }
                }
            }
            #endregion
            #region Too Big and Lava Jumping
            if (tooBig)
            {
                if (npc.velocity.Y == 0f && (npc.velocity.X == 0f && npc.direction < 0))
                {
                    npc.velocity.Y -= 8f;
                    npc.velocity.X -= npcSPD;
                }
                else if (npc.velocity.Y == 0f && (npc.velocity.X == 0f && npc.direction > 0))
                {
                    npc.velocity.Y -= 8f;
                    npc.velocity.X += npcSPD;
                }
            }
            if (lavaJumping)
            {
                if (npc.lavaWet)
                {
                    npc.velocity.Y -= 2;
                }
            }
            #endregion
        }
        #region Gore
        public override void NPCLoot()
        {
            Color color = new Color();
            Rectangle rectangle = new Rectangle((int)npc.position.X, (int)(npc.position.Y + ((npc.height - npc.width) / 2)), npc.width, npc.width);
            int count = 30;
            for (int i = 1; i <= count; i++)
            {
                int dust = Dust.NewDust(npc.position, rectangle.Width, rectangle.Height, 6, 0, 0, 100, color, 1.5f);
                Main.dust[dust].noGravity = false;
            }
            //Gore.NewGore(npc.position, npc.velocity, "OmnirsNosPak:OmnirsTibianSwampTrollGore1", 1f, -1);
            //Gore.NewGore(npc.position, npc.velocity, "OmnirsNosPak:OmnirsTibianSwampTrollGore2", 1f, -1);
            //Gore.NewGore(npc.position, npc.velocity, "OmnirsNosPak:OmnirsTibianSwampTrollGore3", 1f, -1);
            //Gore.NewGore(npc.position, npc.velocity, "OmnirsNosPak:OmnirsTibianSwampTrollGore2", 1f, -1);
            //Gore.NewGore(npc.position, npc.velocity, "OmnirsNosPak:OmnirsTibianSwampTrollGore3", 1f, -1);
            if (Main.rand.Next(10) == 0)
            {
                //Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("OmnirsSabre"));
            }
            if (Main.expertMode)
            {
                //Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType(""));
            }
            else
            {

                if (Main.rand.Next(7) == 0)
                {
                    //Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType(""));
                }
                //Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("UltimaEssence"), Main.rand.Next(3, 9));
            }
        }


        

        #endregion
    }
}
