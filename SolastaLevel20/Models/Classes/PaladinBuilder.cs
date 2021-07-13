using System.Collections.Generic;
using SolastaModApi.Infrastructure;
using SolastaLevel20.Models.Features;
using static SolastaModApi.DatabaseHelper.CharacterClassDefinitions;
using static SolastaModApi.DatabaseHelper.FeatureDefinitionCastSpells;
using static SolastaModApi.DatabaseHelper.FeatureDefinitionFeatureSets;
using static SolastaModApi.DatabaseHelper.SpellDefinitions;
using static SolastaModApi.DatabaseHelper.SpellListDefinitions;

namespace SolastaLevel20.Models.Classes
{
    public static class PaladinBuilder
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
            Paladin.FeatureUnlocks.AddRange(
                // TODO 14: Cleansing Touch
                new FeatureUnlockByLevel(FeatureSetAbilityScoreChoice, 16),
                new FeatureUnlockByLevel(PowerPaladinAuraOfCourage18Builder.Instance, 18),
                new FeatureUnlockByLevel(PowerPaladinAuraOfProtection18Builder.Instance, 18),
                new FeatureUnlockByLevel(FeatureSetAbilityScoreChoice, 19)
            );

            // add missing spell slots
            foreach (var slot in CastSpellPaladin.SlotsPerLevels)
            {
                slot.Slots = Slots[slot.Level - 1];
            }

            // adds missing DeathWard spell to level 4
            SpellListPaladin.SpellsByLevel.RemoveAll(x => x.Level == 4);
            SpellListPaladin.SpellsByLevel.Add(new SpellListDefinition.SpellsByLevelDuplet
            {
                Level = 4,
                Spells = new List<SpellDefinition>
                {
                    Banishment,
                    DeathWard
                }
            });
        }
    }
}