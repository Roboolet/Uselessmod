using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Uselessmod.Items
{
    public class CastFlare : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Virtual Flare");
            Tooltip.SetDefault("A spell to cast a flare.");
        }

        public override void SetDefaults()
        {
            item.damage = 14;
            item.magic = true;                     //this make the item do magic damage
            item.width = 24;
            item.height = 28;
            item.useTime = 7;
            item.useAnimation = 7;
            item.useStyle = 5;        //this is how the item is holded
            item.noMelee = true;
            item.knockBack = 1;
            item.value = 250000;
            item.rare = 2;
            item.mana = 4;             //mana use
            item.UseSound = SoundID.Item21;            //this is the sound when you use the item
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("NapalmFlareProj");  //this make the item shoot your projectile
            item.shootSpeed = 20f;    //projectile speed when shoot
            item.crit = 10;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Flare, 50);
            recipe.AddIngredient(ItemID.Book);
            recipe.AddIngredient(ItemID.Ruby, 10);
            recipe.AddIngredient(ItemID.Torch, 25);
            recipe.AddIngredient(ItemID.FlareGun);
            recipe.AddTile(TileID.Bookcases);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}