using System.Collections.Generic;
using SolastaModApi.Infrastructure;
using SolastaLevel20.Models.Features;
using static SolastaModApi.DatabaseHelper.CharacterClassDefinitions;
using static SolastaModApi.DatabaseHelper.FeatureDefinitionFeatureSets;
using static SolastaModApi.DatabaseHelper.SpellDefinitions;
using static SolastaModApi.DatabaseHelper.SpellListDefinitions;

namespace SolastaLevel20.Models.Classes
{
    public static class PaladinBuilder
    {
        public static void Load()
        {
            Paladin.FeatureUnlocks.AddRange(
                // TODO 14: Cleansing Touch
                // TODO 15: Sacred Oath Feature
                new FeatureUnlockByLevel(FeatureSetAbilityScoreChoice, 16),
                new FeatureUnlockByLevel(PowerPaladinAuraOfCourage18Builder.Instance, 18),
                new FeatureUnlockByLevel(PowerPaladinAuraOfProtection18Builder.Instance, 18),
                new FeatureUnlockByLevel(FeatureSetAbilityScoreChoice, 19)
                // TODO 20: Sacred Oath Feature
            );

            // recreate 4th level spells
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