using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace UndergroundRevolution.Tiles
{
    public class SerpentiniteStone : ModTile
    {
        public override void SetStaticDefaults()
        {
            TileID.Sets.Ore[Type] = true;
            Main.tileSpelunker[Type] = true;
            Main.tileOreFinderPriority[Type] = 410;
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileShine[Type] = 900;
            Main.tileShine2[Type] = true;
            
            AddMapEntry(new Color(7, 37, 8), CreateMapEntryName("SerpentiniteStone"));

            DustType = DustID.GemEmerald;
            ItemDrop = ModContent.ItemType<Items.TileItems.Serpentinite>();

            HitSound = SoundID.Tink;
            MineResist = 2f;
            MinPick = 80;
        }

    }
}