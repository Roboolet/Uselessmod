using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Uselessmod.Items.Souls
{
    public class FlareSoul : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soul of Flares");
            Tooltip.SetDefault("The essence of fiery creatures");
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
            item.value = 1000;
            item.rare = 1;
            item.maxStack = 999;
        }

    }
}