using System.Collections.Generic;
using static SolastaModApi.DatabaseHelper.CharacterClassDefinitions;
using static SolastaModApi.DatabaseHelper.FeatureDefinitionCastSpells;
using static SolastaModApi.DatabaseHelper.FeatureDefinitionFeatureSets;
using static SolastaModApi.DatabaseHelper.FeatureDefinitionPointPools;

namespace SolastaLevel20.Models.Classes
{
    public static class SorcererBuilder
    {
        private static readonly List<List<int>> Slots = new List<List<int>>
        {
            new List<int> {2,0,0,0,0,0,0},
            new List<int> {3,0,0,0,0,0,0},
            new List<int> {4,2,0,0,0,0,0},
            new List<int> {4,3,0,0,0,0,0},
            new List<int> {4,3,2,0,0,0,0},
            new List<int> {4,3,3,0,0,0,0},
            new List<int> {4,3,3,1,0,0,0},
            new List<int> {4,3,3,2,0,0,0},
            new List<int> {4,3,3,3,1,0,0},
            new List<int> {4,3,3,3,2,0,0},
            new List<int> {4,3,3,3,2,1,0},
            new List<int> {4,3,3,3,2,1,0},
            new List<int> {4,3,3,3,2,1,1},
            new List<int> {4,3,3,3,2,1,1},
            new List<int> {4,3,3,3,2,1,1},
            new List<int> {4,3,3,3,2,1,1},
            new List<int> {4,3,3,3,2,1,1},
            new List<int> {4,3,3,3,3,1,1},
            new List<int> {4,3,3,3,3,2,1},
            new List<int> {4,3,3,3,3,2,2},
        };

        public static void Load()
        {
            // add missing progression
            Sorcerer.FeatureUnlocks.AddRange(new List<FeatureUnlockByLevel> {
                new FeatureUnlockByLevel(FeatureSetAbilityScoreChoice, 12),
                new FeatureUnlockByLevel(FeatureSetAbilityScoreChoice, 16),
                new FeatureUnlockByLevel(PointPoolSorcererAdditionalMetamagic, 17),
                new FeatureUnlockByLevel(FeatureSetAbilityScoreChoice, 19),
                // TODO: Sorcerous Restoration
            });

            // add missing spell slots
            foreach (var slot in CastSpellSorcerer.SlotsPerLevels)
            {
                slot.Slots = Slots[slot.Level - 1];
            }
        }
    }
}