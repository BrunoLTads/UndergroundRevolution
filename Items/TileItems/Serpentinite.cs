using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UndergroundRevolution.Items.TileItems
{
    public class Serpentinite : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
        }

        public override void SetDefaults()
        {
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.maxStack = 999;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.SerpentiniteGem>();
            Item.width = 14;
            Item.height = 16;
            Item.value = 1000;
            //SoundType = SoundID.Tink;
            //SoundStyle = 1; Essas merdas não funcionam
        }
    }
}