using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace Uselessmod.Items.Blades
{
	public class Grassblade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blade of seeds");
            Tooltip.SetDefault("A blade made out of the worlds grasses");
		}
		public override void SetDefaults()
		{
			item.damage = 15;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 12;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = 50000;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.maxStack = 1;
            item.scale = 1.1f;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GrassSeeds, 3);
            recipe.AddIngredient(ItemID.JungleGrassSeeds, 3);
            recipe.AddIngredient(ItemID.MushroomGrassSeeds, 3);
            recipe.AddIngredient(ItemID.HallowedSeeds, 3);
            recipe.AddIngredient(ItemID.CorruptSeeds, 3);
            recipe.AddIngredient(ItemID.Acorn, 20);
            recipe.AddIngredient(ItemID.Vine, 4);
            recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GrassSeeds, 3);
            recipe.AddIngredient(ItemID.JungleGrassSeeds, 3);
            recipe.AddIngredient(ItemID.MushroomGrassSeeds, 3);
            recipe.AddIngredient(ItemID.HallowedSeeds, 3);
            recipe.AddIngredient(ItemID.CrimsonSeeds, 3);
            recipe.AddIngredient(ItemID.Acorn, 20);
            recipe.AddIngredient(ItemID.Vine, 4);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            target.AddBuff(BuffID.Bleeding, 120);
        }
    }
}
