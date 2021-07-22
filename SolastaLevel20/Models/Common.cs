using System.Collections.Generic;
using static FeatureDefinitionCastSpell;

namespace SolastaLevel20.Models
{
    internal static class Common
    {
        internal static readonly List<SlotsByLevelDuplet> FullCastingSlots = new List<SlotsByLevelDuplet>()
        {
            new SlotsByLevelDuplet() { Slots = new List<int> {0,0,0,0,0,0,0,0,0,0}, Level = 0 },
            new SlotsByLevelDuplet() { Slots = new List<int> {2,0,0,0,0,0,0,0,0,0}, Level = 1 },
            new SlotsByLevelDuplet() { Slots = new List<int> {3,0,0,0,0,0,0,0,0,0}, Level = 2 },
            new SlotsByLevelDuplet() { Slots = new List<int> {4,2,0,0,0,0,0,0,0,0}, Level = 3 },
            new SlotsByLevelDuplet() { Slots = new List<int> {4,3,0,0,0,0,0,0,0,0}, Level = 4 },
            new SlotsByLevelDuplet() { Slots = new List<int> {4,3,2,0,0,0,0,0,0,0}, Level = 5 },
            new SlotsByLevelDuplet() { Slots = new List<int> {4,3,3,0,0,0,0,0,0,0}, Level = 6 },
            new SlotsByLevelDuplet() { Slots = new List<int> {4,3,3,1,0,0,0,0,0,0}, Level = 7 },
            new SlotsByLevelDuplet() { Slots = new List<int> {4,3,3,2,0,0,0,0,0,0}, Level = 8 },
            new SlotsByLevelDuplet() { Slots = new List<int> {4,3,3,3,1,0,0,0,0,0}, Level = 9 },
            new SlotsByLevelDuplet() { Slots = new List<int> {4,3,3,3,2,0,0,0,0,0}, Level = 10 },
            new SlotsByLevelDuplet() { Slots = new List<int> {4,3,3,3,2,1,0,0,0,0}, Level = 11 },
            new SlotsByLevelDuplet() { Slots = new List<int> {4,3,3,3,2,1,0,0,0,0}, Level = 12 },
            new SlotsByLevelDuplet() { Slots = new List<int> {4,3,3,3,2,1,0,0,0,0}, Level = 13 },
            new SlotsByLevelDuplet() { Slots = new List<int> {4,3,3,3,2,1,0,0,0,0}, Level = 14 },
            new SlotsByLevelDuplet() { Slots = new List<int> {4,3,3,3,2,1,0,0,0,0}, Level = 15 },
            new SlotsByLevelDuplet() { Slots = new List<int> {4,3,3,3,2,1,0,0,0,0}, Level = 16 },
            new SlotsByLevelDuplet() { Slots = new List<int> {4,3,3,3,2,1,0,0,0,0}, Level = 17 },
            new SlotsByLevelDuplet() { Slots = new List<int> {4,3,3,3,3,1,0,0,0,0}, Level = 18 },
            new SlotsByLevelDuplet() { Slots = new List<int> {4,3,3,3,3,2,0,0,0,0}, Level = 19 },
            new SlotsByLevelDuplet() { Slots = new List<int> {4,3,3,3,3,2,0,0,0,0}, Level = 20 },
        };

        internal static readonly List<SlotsByLevelDuplet> HalfCastingSlots = new List<SlotsByLevelDuplet>()
        {
            new SlotsByLevelDuplet() { Slots = new List<int> {0,0,0,0,0,0,0,0,0,0}, Level = 0 },
            new SlotsByLevelDuplet() { Slots = new List<int> {0,0,0,0,0,0,0,0,0,0}, Level = 1 },
            new SlotsByLevelDuplet() { Slots = new List<int> {2,0,0,0,0,0,0,0,0,0}, Level = 2 },
            new SlotsByLevelDuplet() { Slots = new List<int> {3,0,0,0,0,0,0,0,0,0}, Level = 3 },
            new SlotsByLevelDuplet() { Slots = new List<int> {3,0,0,0,0,0,0,0,0,0}, Level = 4 },
            new SlotsByLevelDuplet() { Slots = new List<int> {4,2,0,0,0,0,0,0,0,0}, Level = 5 },
            new SlotsByLevelDuplet() { Slots = new List<int> {4,2,0,0,0,0,0,0,0,0}, Level = 6 },
            new SlotsByLevelDuplet() { Slots = new List<int> {4,3,0,0,0,0,0,0,0,0}, Level = 7 },
            new SlotsByLevelDuplet() { Slots = new List<int> {4,3,0,0,0,0,0,0,0,0}, Level = 8 },
            new SlotsByLevelDuplet() { Slots = new List<int> {4,3,2,0,0,0,0,0,0,0}, Level = 9 },
            new SlotsByLevelDuplet() { Slots = new List<int> {4,3,2,0,0,0,0,0,0,0}, Level = 10 },
            new SlotsByLevelDuplet() { Slots = new List<int> {4,3,3,0,0,0,0,0,0,0}, Level = 11 },
            new SlotsByLevelDuplet() { Slots = new List<int> {4,3,3,0,0,0,0,0,0,0}, Level = 12 },
            new SlotsByLevelDuplet() { Slots = new List<int> {4,3,3,1,0,0,0,0,0,0}, Level = 13 },
            new SlotsByLevelDuplet() { Slots = new List<int> {4,3,3,1,0,0,0,0,0,0}, Level = 14 },
            new SlotsByLevelDuplet() { Slots = new List<int> {4,3,3,2,0,0,0,0,0,0}, Level = 15 },
            new SlotsByLevelDuplet() { Slots = new List<int> {4,3,3,2,0,0,0,0,0,0}, Level = 16 },
            new SlotsByLevelDuplet() { Slots = new List<int> {4,3,3,3,1,0,0,0,0,0}, Level = 17 },
            new SlotsByLevelDuplet() { Slots = new List<int> {4,3,3,3,1,0,0,0,0,0}, Level = 18 },
            new SlotsByLevelDuplet() { Slots = new List<int> {4,3,3,3,2,0,0,0,0,0}, Level = 19 },
            new SlotsByLevelDuplet() { Slots = new List<int> {4,3,3,3,2,0,0,0,0,0}, Level = 20 },
        };
    }
}