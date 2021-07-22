using System.Collections.Generic;
using static SolastaModApi.DatabaseHelper.CharacterClassDefinitions;
using static SolastaModApi.DatabaseHelper.FeatureDefinitionCastSpells;
using static SolastaModApi.DatabaseHelper.FeatureDefinitionFeatureSets;

namespace SolastaLevel20.Models.Classes
{
    public static class WizardBuilder
    {
        private static readonly List<List<int>> Slots = new List<List<int>>
        {
            new List<int> {2,0,0,0,0,0,0,0,0},
            new List<int> {3,0,0,0,0,0,0,0,0},
            new List<int> {4,2,0,0,0,0,0,0,0},
            new List<int> {4,3,0,0,0,0,0,0,0},
            new List<int> {4,3,2,0,0,0,0,0,0},
            new List<int> {4,3,3,0,0,0,0,0,0},
            new List<int> {4,3,3,1,0,0,0,0,0},
            new List<int> {4,3,3,2,0,0,0,0,0},
            new List<int> {4,3,3,3,1,0,0,0,0},
            new List<int> {4,3,3,3,2,0,0,0,0},
            new List<int> {4,3,3,3,2,1,0,0,0},
            new List<int> {4,3,3,3,2,1,0,0,0},
            new List<int> {4,3,3,3,2,1,1,0,0},
            new List<int> {4,3,3,3,2,1,1,0,0},
            new List<int> {4,3,3,3,2,1,1,1,0},
            new List<int> {4,3,3,3,2,1,1,1,0},
            new List<int> {4,3,3,3,2,1,1,1,1},
            new List<int> {4,3,3,3,3,1,1,1,1},
            new List<int> {4,3,3,3,3,2,1,1,1},
            new List<int> {4,3,3,3,3,2,2,1,1},
        };

        public static void Load()
        {
            // add missing progression
            Wizard.FeatureUnlocks.AddRange(new List<FeatureUnlockByLevel> {
                // TODO 14: Overchannel
                new FeatureUnlockByLevel(FeatureSetAbilityScoreChoice, 16),
                // TODO 18: Spell Mastery
                new FeatureUnlockByLevel(FeatureSetAbilityScoreChoice, 19)
                // TODO 20: Signature Spells
            });

            // add missing spell slots
            foreach (var slot in CastSpellWizard.SlotsPerLevels)
            {
                slot.Slots = Slots[slot.Level - 1];
            }
        }
    }
}