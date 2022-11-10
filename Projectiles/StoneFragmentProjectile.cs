using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UndergroundRevolution.Projectiles
{
    public class StoneFragmentProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stone Fragment Projectile");
            ProjectileID.Sets.TrailCacheLength[Projectile.type] = 5; //The length of old position to be recorded (Dont know what this does)
            ProjectileID.Sets.TrailingMode[Projectile.type] = 0;     //The recording mode (Dont know what this does)
        }

        public override void SetDefaults()
        {
            Projectile.width = 14;               //The width of projectile hitbox
            Projectile.height = 14;              //The height of projectile hitbox
            Projectile.aiStyle = -1;             //Thrown style (daggers, shuriken)
            Projectile.friendly = false;         //Can the projectile deal damage to enemies?
            Projectile.hostile = true;         //Can the projectile deal damage to the player?
            //Projectile.ranged = true;         Is the projectile shoot by a ranged weapon?
            Projectile.penetrate = 2;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
            Projectile.timeLeft = 600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
            Projectile.alpha = 1;             //The transparency of the projectile, 255 for completely transparent. (aiStyle 1 quickly fades the projectile in) Make sure to delete this if you aren't using an aiStyle that fades in. You'll wonder why your projectile is invisible.
            Projectile.light = 0.5f;            //How much light emit around the projectile
            Projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
            Projectile.tileCollide = true;          //Can the projectile collide with tiles?
            Projectile.extraUpdates = 1;            //Set to above 0 if you want the projectile to update multiple time in a frame
            //AIType = ProjectileID.SnowBallHostile;           //Act exactly like hostile PineNeedle
        }
    }
}