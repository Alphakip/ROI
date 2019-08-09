﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace ROI.Items.Placeable.Wasteland
{
    class Wasteland_Rock : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Eradied rock");
            Tooltip.SetDefault("\"Is it even safe to touch it?\"");
        }

        public override void SetDefaults()
        {
            item.maxStack = 9999;
            item.consumable = true;
            item.width = 16;
            item.height = 16;
            item.useAnimation = 15;
            item.autoReuse = true;
            item.useTime = 10;
            item.useStyle = 1;
            item.useTurn = true;
            item.createTile = mod.TileType("Wasteland_Rock");
        }
    }
}
