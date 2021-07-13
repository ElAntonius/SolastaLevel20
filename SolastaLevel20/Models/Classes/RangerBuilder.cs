using System.Collections.Generic;
using static SolastaModApi.DatabaseHelper.CharacterClassDefinitions;
using static SolastaModApi.DatabaseHelper.FeatureDefinitionCastSpells;
using static SolastaModApi.DatabaseHelper.FeatureDefinitionFeatureSets;
using static SolastaLevel20.Models.Features.ActionAffinityRangerVanishActionBuilder;

namespace SolastaLevel20.Models.Classes
{
    public static class RangerBuilder
    {
        private static readonly List<List<int>> Slots = new List<List<int>>
        {
            new List<int> {0,0,0,0,0},
            new List<int> {2,0,0,0,0},
            new List<int> {3,0,0,0,0},
            new List<int> {3,0,0,0,0},
            new List<int> {4,2,0,0,0},
            new List<int> {4,2,0,0,0},
            new List<int> {4,3,0,0,0},
            new List<int> {4,3,0,0,0},
            new List<int> {4,3,2,0,0},
            new List<int> {4,3,2,0,0},
            new List<int> {4,3,3,0,0},
            new List<int> {4,3,3,0,0},
            new List<int> {4,3,3,1,0},
            new List<int> {4,3,3,1,0},
            new List<int> {4,3,3,2,0},
            new List<int> {4,3,3,2,0},
            new List<int> {4,3,3,3,1},
            new List<int> {4,3,3,3,1},
            new List<int> {4,3,3,3,2},
            new List<int> {4,3,3,3,2},
        };

        public static void Load()
        {
            Ranger.FeatureUnlocks.AddRange(new List<FeatureUnlockByLevel> {
                new FeatureUnlockByLevel(AdditionalDamageRangerFavoredEnemyChoice, 14),
                new FeatureUnlockByLevel(ActionAffinityRangerVanishAction, 14),
                new FeatureUnlockByLevel(FeatureSetAbilityScoreChoice, 16),
                // TODO 18: Feral Senses
                new FeatureUnlockByLevel(FeatureSetAbilityScoreChoice, 19),
                // TODO 20: Foe Slayer
            });

            // add missing spell slots
            foreach (var slot in CastSpellRanger.SlotsPerLevels)
            {
                slot.Slots = Slots[slot.Level - 1];
            }
        }
    }
}