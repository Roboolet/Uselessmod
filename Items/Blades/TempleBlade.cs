using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace Uselessmod.Items.Blades
{
	public class TempleBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Templar's Sword");
            Tooltip.SetDefault("Made out of materials that used to be indestructible");
		}
		public override void SetDefaults()
		{
			item.damage = 190;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 46;
			item.useAnimation = 46;
			item.useStyle = 1;
			item.knockBack = 15;
			item.value = 100000;
			item.rare = 7;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
            item.maxStack = 1;
            item.scale = 1.5f;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GreenBrick, 75);
            recipe.AddIngredient(ItemID.LihzahrdBrick, 75);
            recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BlueBrick, 75);
            recipe.AddIngredient(ItemID.LihzahrdBrick, 75);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();


            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PinkBrick, 75);
            recipe.AddIngredient(ItemID.LihzahrdBrick, 75);
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
