using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Uselessmod.Items

{
    public class StormPistol : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Storm Cannon");
            Tooltip.SetDefault("Fires a flare alongside your bullets"
               + "\n50% chance to not consume ammo");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ChainGun);
            item.damage = 30;
            item.ranged = true;
            item.width = 40;
            item.height = 12;
            item.useTime = 4;
            item.useAnimation = 4;
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 2;
            item.value = 750000;
            item.rare = 8;
            item.autoReuse = true;
            item.shoot = ProjectileID.Bullet; //flare id is 163
            item.shootSpeed = 12f;
            item.useAmmo = AmmoID.Bullet;
            item.maxStack = 1;
        }
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(5, 0);
        }

        public override void AddRecipes()  //How to craft this gun
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FlareGun);
            recipe.AddIngredient(ItemID.ChainGun);
            recipe.AddIngredient(ItemID.ShroomiteBar, 10);
            recipe.AddIngredient(ItemID.CursedFlame, 25);
            recipe.AddIngredient(mod.ItemType("FlareSoul"), 25);
            recipe.AddTile(TileID.WorkBenches);   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FlareGun);
            recipe.AddIngredient(ItemID.ChainGun);
            recipe.AddIngredient(ItemID.ShroomiteBar, 10);
            recipe.AddIngredient(ItemID.Ichor, 25);
            recipe.AddIngredient(mod.ItemType("FlareSoul"), 25);
            recipe.AddTile(TileID.WorkBenches);   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();

        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(7));
            speedX = perturbedSpeed.X;
            speedY = perturbedSpeed.Y;

            // Here we manually spawn the 2nd projectile, manually specifying the projectile type that we wish to shoot.
            Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, mod.ProjectileType("StormPistolFlareProj"), 12, 10, player.whoAmI);
            // By returning true, the vanilla behavior will take place, which will shoot the 1st projectile, the one determined by the ammo.
            return true;
        }

        public override bool ConsumeAmmo(Player player)
        {
            return Main.rand.NextFloat() >= .50f;
        }
    }

    
}