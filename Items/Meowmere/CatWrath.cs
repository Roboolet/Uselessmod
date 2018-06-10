using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace Uselessmod.Items.Meowmere
{
	public class CatWrath : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cat Wrath");
            Tooltip.SetDefault("If you thought the Meowmere didnt shoot enough cats");
		}
		public override void SetDefaults()
		{
            item.melee = true;     //This defines if it does Melee damage and if its effected by Melee increasing Armor/Accessories.   //The size of the height of the hitbox in pixels.
            item.useTime = 12;   //How fast the Weapon is used.
            item.useAnimation = 10;     //How long the Weapon is used for.
            item.damage = 167;
            item.useStyle = 100;    //The way your Weapon will be used, 1 is the regular sword swing for example
            item.value = Item.buyPrice(0, 10, 0, 0); // How much the item is worth, in copper coins, when you sell it to a merchant. It costs 1/5th of this to buy it back from them. An easy way to remember the value is platinum, gold, silver, copper or PPGGSSCC (so this item price is 10gold)            
            item.shoot = ProjectileID.Meowmere;  //This defines what type of projectile this weapon will shoot  
            item.CloneDefaults(ItemID.Meowmere);
        }

        public override bool UseItemFrame(Player player)     //this defines what frame the player use when this weapon is used
        {
            player.bodyFrame.Y = 3 * player.bodyFrame.Height;
            return true;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {

            Vector2 target = Main.screenPosition + new Vector2((float)Main.mouseX, (float)Main.mouseY);
            float ceilingLimit = target.Y;
            if (ceilingLimit > player.Center.Y - 200f)
            {
                ceilingLimit = player.Center.Y - 200f;
            }
            for (int i = 0; i < 4; i++)
            {
                position = player.Center + new Vector2((-(float)Main.rand.Next(0, 401) * player.direction), -600f);
                position.Y -= (100 * i);
                Vector2 heading = target - position;
                if (heading.Y < 0f)
                {
                    heading.Y *= -1f;
                }
                if (heading.Y < 20f)
                {
                    heading.Y = 20f;
                }
                heading.Normalize();
                heading *= new Vector2(speedX, speedY).Length();
                speedX = heading.X;
                speedY = heading.Y + Main.rand.Next(-40, 41) * 0.02f;
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage * 2, knockBack, player.whoAmI, 0f);
            }
            return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
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
