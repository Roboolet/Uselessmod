using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Uselessmod.Items.Souls
{
    public class CopperSoul : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soul of Copper");
            Tooltip.SetDefault("The collective spirits of copper shortswords");
            // ticksperframe, frameCount
            Main.RegisterItemAnimation(item.type, new Terraria.DataStructures.DrawAnimationVertical(5, 4));
            ItemID.Sets.AnimatesAsSoul[item.type] = true;
            ItemID.Sets.ItemIconPulse[item.type] = true;
            ItemID.Sets.ItemNoGravity[item.type] = true;
        }

        public override void SetDefaults()
        {
            Item refItem = new Item();
            refItem.SetDefaults(ItemID.SoulofSight);
            item.width = refItem.width;
            item.height = refItem.height;
            item.rare = 1;
            item.value = 50;
            item.maxStack = 999;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CopperShortsword);
            recipe.AddIngredient(ItemID.CopperShortsword);
            recipe.AddIngredient(ItemID.CopperBar, 2);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}