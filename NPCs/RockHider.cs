using System;
using System.Drawing.Text;
using IL.Terraria.Cinematics;
using IL.Terraria.DataStructures;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using tModPorter;
using UndergroundRevolution.Projectiles;

namespace UndergroundRevolution.NPCs
{
    public class RockHider : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rock Hider");
            Main.npcFrameCount[NPC.type] = Main.npcFrameCount[3];
        }

        public override void SetDefaults()
        {
            NPC.width = 48;
            NPC.height = 30;
            NPC.damage = 25;
            NPC.defense = 5;
            NPC.lifeMax = 50;
            NPC.value = 100f;
            NPC.aiStyle = -1;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            AIType = NPCID.Zombie;
            AnimationType = NPCID.Zombie;
        }

        public override void AI()
        {
            NPC.TargetClosest(true);
            Vector2 targetPostion = Main.player[NPC.target].position;
            if (targetPostion.X < NPC.position.X && NPC.velocity.X < 2.00)
            {
                NPC.velocity.X += 0.25f;
            }
            if (targetPostion.X > NPC.position.X && NPC.velocity.X > -2.00)
            {
                NPC.velocity.X -= 0.25f;
            }
            if (Math.Abs(targetPostion.X) - NPC.position.X <= 150 && Math.Abs(targetPostion.X) - NPC.position.X >= -150)
            {
                NPC.velocity.X = 0f;
            }
            if (Math.Abs(targetPostion.X) - NPC.position.X >= 400 || Math.Abs(targetPostion.X) - NPC.position.X <= -400)
            {
                NPC.velocity.X = 0f;
                NPC.ai[1]++;
                if (NPC.ai[1] >= 90)
                {
                    if (NPC.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
                    {
                        var source = NPC.GetSource_FromAI();
                        Vector2 position = NPC.Center;
                        Vector2 targetPosition = Main.player[NPC.target].Center;
                        Vector2 direction = targetPosition - position;
                        direction.Normalize();
                        float speed = 8f;
                        int type = ModContent.ProjectileType<Projectiles.StoneFragmentProjectile>();
                        //int type = ProjectileID.PineNeedleHostile;
                        int damage = NPC.damage;
                        Projectile.NewProjectile(source, position, direction * speed, type, damage, 0f, Main.myPlayer);
                        NPC.ai[1] = 0;
                    }
                }

            
             //if (NPC.velocity.X != 0f)
               // {
                 //   NPC.ai[2]++;
                   // float NPCprevposition = NPC.position.X;
                   //
                //}
            }
            if (NPC.velocity.Y == 0)
            {
                NPC.velocity.Y -= 2f;
            }
        }

        
    }
}