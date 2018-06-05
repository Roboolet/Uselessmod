using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Uselessmod.Items
{
    public class FamilyFlareloom : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Family Flareloom");
            Tooltip.SetDefault("Makes you immune to the On Fire! debuff");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 22;
            item.accessory = true;
            item.rare = 2;
            item.value = 100000;
            item.maxStack = 1;
            item.defense = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Chain, 2);
            recipe.AddIngredient(mod.ItemType("FlareSoul"), 5);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.buffImmune[BuffID.OnFire] = true;
        }
    }
}