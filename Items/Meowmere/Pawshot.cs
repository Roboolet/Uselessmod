using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace Uselessmod.Items.Meowmere
{
	public class Pawshot : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Paw Shot");
            Tooltip.SetDefault("Turns arrows into cats");
		}
		public override void SetDefaults()
		{
            item.damage = 135;
            item.ranged = true;
            item.width = 40;
            item.height = 20;
            item.useTime = 13;
            item.useAnimation = 13;
            item.useStyle = 5;
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 4;
            item.value = 10000;
            item.rare = 11;
            item.UseSound = SoundID.Item37;
            item.autoReuse = true;
            item.shoot = ProjectileID.Meowmere; //idk why but all the guns in the vanilla source have this
            item.shootSpeed = 24f;
            item.useAmmo = AmmoID.Arrow;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 4;
            float rotation = MathHelper.ToRadians(15);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;

            type = ProjectileID.Meowmere;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage, knockBack, player.whoAmI);
            }
            return true;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Meowmere);
            recipe.AddIngredient(ItemID.StarWrath);
            recipe.AddIngredient(ItemID.LunarBar, 25);
            recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();

        }
    }
}
