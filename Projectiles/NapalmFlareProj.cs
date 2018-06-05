using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace Uselessmod.Projectiles
{
    public class NapalmFlareProj : ModProjectile //needs to be ModItem for AddRecipes() to work
    {

        public override void SetDefaults()
        {
            projectile.damage = 6;
            projectile.width = 4;
            projectile.height = 8;
            projectile.knockBack = 1.5f;
            projectile.aiStyle = 33; //id 33 = flare
            projectile.penetrate = -1;
            projectile.netImportant = true;
            projectile.friendly = true;
            projectile.timeLeft = 1000;
            aiType = ProjectileID.Flare;
            //223 = good dust
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 180);
        }
    }
}
