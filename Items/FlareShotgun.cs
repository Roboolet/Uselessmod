using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Uselessmod.Items

{
    public class FlareShotgun : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Flare Shotgun");
            Tooltip.SetDefault("A Flare gun modified to shoot multiple flares.");
        }
        public override void SetDefaults()
        {
            item.damage = 12;
            item.ranged = true;
            item.width = 40;
            item.height = 20;
            item.useTime = 38;
            item.useAnimation = 38;
            item.useStyle = 5;
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 7;
            item.value = 200000;
            item.rare = 1;
            item.autoReuse = false;
            item.shoot = 163; //flare id is 163
            item.shootSpeed = 14f;
            item.useAmmo = AmmoID.Flare;
            item.UseSound = SoundID.Item11;
            item.maxStack = 1;
        }
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(5, 0);
        }

        public override void AddRecipes()  //How to craft this gun
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FlareGun, 2);   //you need 1 DirtBlock
            recipe.AddTile(TileID.WorkBenches);   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();

        }

        public static Vector2[] randomSpread(float speedX, float speedY, int angle, int num)
        {
            var posArray = new Vector2[num];
            float spread = (float)(angle * 0.175);
            float baseSpeed = (float)System.Math.Sqrt(speedX * speedX + speedY * speedY);
            double baseAngle = System.Math.Atan2(speedX, speedY);
            double randomAngle;
            for (int i = 0; i < num; ++i)
            {
                randomAngle = baseAngle + (Main.rand.NextFloat() - 0.5f) * spread;
                posArray[i] = new Vector2(baseSpeed * (float)System.Math.Sin(randomAngle), baseSpeed * (float)System.Math.Cos(randomAngle));
            }
            return (Vector2[])posArray;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Vector2[] speeds = randomSpread(speedX, speedY, 8, 6);
            for (int i = 0; i < 5; ++i)
            {
                Projectile.NewProjectile(position.X, position.Y, speeds[i].X, speeds[i].Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }

    }
}