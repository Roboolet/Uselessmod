using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace Uselessmod.Items.Blades
{
	public class CopperGiant : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Copper Doomblade");
            Tooltip.SetDefault("The definition of irony");
		}
		public override void SetDefaults()
		{
			item.damage = 125;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 35;
			item.useAnimation = 30;
			item.useStyle = 3;
			item.knockBack = 100;
			item.value = 100000;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
            item.maxStack = 1;
            item.scale = 1.3f;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddTile(TileID.Anvils);
            recipe.AddIngredient(mod.ItemType("CopperSoul"), 15);
            recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}
