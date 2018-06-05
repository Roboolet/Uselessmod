using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace Uselessmod.NPCs
{
    public class FlareSoulDrop : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == 60)  //hellbat
            {
                if (Main.rand.Next(100) < 31) //31 in 100 chance of dropping
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("FlareSoul"));
                }
            }
            if (npc.type == 59) //lava slime
            {
                if (Main.rand.Next(100) < 31) //31 in 100 chance of dropping
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("FlareSoul"));
                }
            }
            if (npc.type == 62) //demon
            {
                if (Main.rand.Next(100) < 31) 
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("FlareSoul"));
                }
            }
            if (npc.type == 66) //voodoo demon
            {
                if (Main.rand.Next(100) < 66) 
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("FlareSoul"));
                }
            }
            if (npc.type == 31) //meteor head
            {
                if (Main.rand.Next(100) < 15)
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("FlareSoul"));
                }
            }
            if (npc.type == 24) //fire imp
            {
                if (Main.rand.Next(100) < 31)
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("FlareSoul"));
                }
            }
            if (npc.type == 25) //fire imp projectile (burning sphere)
            {
                if (Main.rand.Next(100) < 1)
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("FlareSoul"));
                }
            }
            if (npc.type == 39) //bone serpent
            {
                if (Main.rand.Next(100) < 31)
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("FlareSoul"));
                }
            }
            if (npc.type == 62) //wall of flesh
            {
                Item.NewItem(npc.getRect(), mod.ItemType("FlareSoul"), (Main.rand.Next(3,7)));
            }
            if (npc.type == 151) //lava bat
            {
                if (Main.rand.Next(100) < 31)
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("FlareSoul"));
                }
            }
            if (npc.type == 277) //hell armored bones
            {
                if (Main.rand.Next(100) < 31)
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("FlareSoul"));
                }
            }
            if (npc.type == 278) //hell armored bones
            {
                if (Main.rand.Next(100) < 31)
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("FlareSoul"));
                }
            }
            if (npc.type == 279) //hell armored bones
            {
                if (Main.rand.Next(100) < 31)
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("FlareSoul"));
                }
            }
            if (npc.type == 280) //hell armored bones
            {
                if (Main.rand.Next(100) < 31)
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("FlareSoul"));
                }
            }
            if (npc.type == 421) //crawltipede
            {
                if (Main.rand.Next(100) < 31)
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("FlareSoul"));
                }
            }
            if (npc.type == 415) //darkomire
            {
                if (Main.rand.Next(100) < 31)
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("FlareSoul"));
                }
            }
            if (npc.type == 417) //sroller
            {
                if (Main.rand.Next(100) < 31)
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("FlareSoul"));
                }
            }
            if (npc.type == 418) //corite
            {
                if (Main.rand.Next(100) < 31)
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("FlareSoul"));
                }
            }
            if (npc.type == 419) //selenian
            {
                if (Main.rand.Next(100) < 31)
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("FlareSoul"));
                }
            }
            if (npc.type == 518) //drakanian
            {
                if (Main.rand.Next(100) < 31)
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("FlareSoul"));
                }
            }
            if (npc.type == 551) //betsy
            {
                Item.NewItem(npc.getRect(), mod.ItemType("FlareSoul"), (Main.rand.Next(4, 12)));
            }

        }
    }
}
