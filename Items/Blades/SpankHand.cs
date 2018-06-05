using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace Uselessmod.Items.Blades
{
	public class SpankHand : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spank Hand");
            Tooltip.SetDefault("Because just slapping wasn't enough");
		}
		public override void SetDefaults()
		{
			item.damage = 2;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 23;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 50;
			item.value = 50000;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.maxStack = 1;
            item.scale = 1.2f;
            item.crit = 96;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SlapHand);
            recipe.AddIngredient(ItemID.TitanGlove);
            recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}
