using System.Collections.Generic;
using SolastaModApi.Extensions;
using static SolastaModApi.DatabaseHelper.CharacterClassDefinitions;
using static SolastaModApi.DatabaseHelper.FeatureDefinitionCastSpells;
using static SolastaModApi.DatabaseHelper.FeatureDefinitionFeatureSets;
using static SolastaModApi.DatabaseHelper.FeatureDefinitionPointPools;
using static SolastaModApi.DatabaseHelper.SpellListDefinitions;

namespace SolastaLevel20.Models.Classes
{
    internal static class SorcererBuilder
    {
        private static readonly List<int> KnownSpells = new List<int> 
        {
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10,
            11,
            12,
            12,
            13,
            13,
            14,
            14,
            15,
            15,
            15,
            15,
        };

        internal static void Load()
        {
            // add missing progression
            Sorcerer.FeatureUnlocks.AddRange(new List<FeatureUnlockByLevel> {
                new FeatureUnlockByLevel(FeatureSetAbilityScoreChoice, 12),
                new FeatureUnlockByLevel(FeatureSetAbilityScoreChoice, 16),
                new FeatureUnlockByLevel(PointPoolSorcererAdditionalMetamagic, 17),
                new FeatureUnlockByLevel(FeatureSetAbilityScoreChoice, 19),
                // TODO: Sorcerous Restoration
            });

            SpellListSorcerer.SetMaxSpellLevel(Common.FullCastingSlots[0].Slots.Count);

            CastSpellSorcerer.SetSpellCastingLevel(-1);

            CastSpellSorcerer.SlotsPerLevels.Clear();
            CastSpellSorcerer.SlotsPerLevels.AddRange(Common.FullCastingSlots);

            CastSpellSorcerer.KnownSpells.Clear();
            CastSpellSorcerer.KnownSpells.AddRange(KnownSpells);

            CastSpellSorcerer.ReplacedSpells.Clear();
            CastSpellSorcerer.ReplacedSpells.AddRange(Common.FullCasterReplacedSpells);
        }
    }
}