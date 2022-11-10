using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UndergroundRevolution.NPCs
{
    public class BurningZombie : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Burning Zombie");
            Main.npcFrameCount[NPC.type] = Main.npcFrameCount[3];
        }

        public override void SetDefaults()
        {
            NPC.width = 17;
            NPC.height = 25;
            NPC.damage = 10;
            NPC.defense = 1;
            NPC.lifeMax = 100;
            NPC.value = 100f;
            NPC.aiStyle = 3;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            AIType = NPCID.Zombie;
            AnimationType = NPCID.Zombie;
            NPC.AddBuff(24, 9999);
        }

        public override void OnHitPlayer(Player target, int damage, bool crit)
        {
            target.AddBuff(24, 600);
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(24, 600);
        }

        public override void AI()
        {
            NPC.velocity.X += NPC.velocity.X * ((NPC.lifeMax - NPC.life) * 0.005f); //Doesnt work as wanted. I'll prob have to make a custom AI based on fighter, but with only x vector changing from hp loss.
            //if(NPC.velocity.X >= 8f)
            //{
            //    NPC.velocity.X = NPC.velocity.X / 2;
            //}

            if (NPC.velocity.Y != 0)
            {
                NPC.velocity.X = NPC.velocity.X / 1.2f;
            }
        }

    }
}