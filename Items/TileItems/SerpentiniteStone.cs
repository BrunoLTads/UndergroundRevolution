using Terraria;
using Terraria.Audio;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;


namespace UndergroundRevolution.Items.TileItems
{
    public class SerpentiniteStone : ModItem
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
            Item.createTile = ModContent.TileType<Tiles.SerpentiniteStone>();
            Item.width = 12;
            Item.height = 12;
            Item.value = 1000;
            //SoundType = SoundID.Tink;
            //SoundStyle = 1; Essas merdas não funcionam
        }
    }
}