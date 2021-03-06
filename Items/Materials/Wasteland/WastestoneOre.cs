using Terraria.ModLoader;

namespace ROI.Items.Materials.Wasteland
{
    internal class WastestoneOre : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.maxStack = 999;
            item.consumable = true;
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.autoReuse = true;
            item.createTile = ModContent.TileType<Tiles.Wasteland.WastelandOre>();
        }
    }
}