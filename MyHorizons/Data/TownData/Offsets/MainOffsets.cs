﻿using System;

namespace MyHorizons.Data.TownData.Offsets
{
    public abstract class MainOffsets
    {
        public abstract int Offset_Vilagers { get; }

        #region VILLAGERS
        public abstract int Villager_Size { get; }
        public abstract int Villager_Species { get; }
        public abstract int Villager_Variant { get; }
        public abstract int Villager_Personality { get; }
        public abstract int Villager_Catchphrase { get; }
        public abstract int Villager_Furniture { get; }

        // Sizes
        public virtual int Villager_CatchphraseLength { get; } = 12;
        public virtual int Villager_FurnitureCount { get; } = 16;
        public virtual int Villager_SpeciesMax { get; } = 0x23;
        #endregion

        public static MainOffsets GetOffsets(int rev) =>
            rev switch
            {
                0 => new MainOffsetsV0(),
                1 => new MainOffsetsV1(),
                _ => throw new IndexOutOfRangeException("Unknown Save Revision!")
            };
    }
}