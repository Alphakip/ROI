using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ROI.Items.Placeables.Wasteland
{
    //TODO: MP for this
    internal class WastelandGrassSeed : ModItem
    {
        public override void SetDefaults()
        {
            item.maxStack = 9999;
            item.consumable = true;
            item.width = 22;
            item.height = 18;
            item.useAnimation = 15;
            item.autoReuse = true;
            item.useTime = 10;
            item.useStyle = 1;
            item.useTurn = true;
        }

        public override bool UseItem(Player player)
        {
            if (Main.tile[Player.tileTargetX, Player.tileTargetY].type == ModContent.TileType<Tiles.Wasteland.WastelandDirt>())
            {
                Main.tile[Player.tileTargetX, Player.tileTargetY].type = (ushort)ModContent.TileType<Tiles.Wasteland.WastelandGrass>();
                WorldGen.TileFrame(Player.tileTargetX, Player.tileTargetY);
                Dust.NewDust(new Vector2(Player.tileTargetX, Player.tileTargetY), 5, 5, DustID.Grass, 0, 0.2f, 255, new Color(152, 208, 113), 1f);
                return true;
            }
            return false;
        }
    }
}