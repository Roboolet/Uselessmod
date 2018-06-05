using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Uselessmod.NPCs
{
    public class MerchantShop : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            switch (type)
            {
                case NPCID.Merchant:  //change Dryad whith what NPC you want

                    if (Main.hardMode) //if it's hardmode the NPC will sell this
                    {
                    }
                    else
                    {    //This make that the npc will always sell this
                        shop.item[nextSlot].SetDefaults(ItemID.FlareGun);        //this is an example of how to add a terraria item
                        nextSlot++;
                    }
                    break;
            }
        }
    }
}
