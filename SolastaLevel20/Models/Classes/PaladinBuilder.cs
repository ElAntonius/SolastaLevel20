using System.Collections.Generic;
using SolastaModApi.Extensions;
using SolastaModApi.Infrastructure;
using SolastaLevel20.Models.Features;
using static SolastaModApi.DatabaseHelper.CharacterClassDefinitions;
using static SolastaModApi.DatabaseHelper.FeatureDefinitionCastSpells;
using static SolastaModApi.DatabaseHelper.FeatureDefinitionFeatureSets;
using static SolastaModApi.DatabaseHelper.SpellDefinitions;
using static SolastaModApi.DatabaseHelper.SpellListDefinitions;

namespace SolastaLevel20.Models.Classes
{
    internal static class PaladinBuilder
    {
        internal static void Load()
        {
            Paladin.FeatureUnlocks.AddRange(
                // TODO 14: Cleansing Touch
                new FeatureUnlockByLevel(FeatureSetAbilityScoreChoice, 16),
                new FeatureUnlockByLevel(PowerPaladinAuraOfCourage18Builder.Instance, 18),
                new FeatureUnlockByLevel(PowerPaladinAuraOfProtection18Builder.Instance, 18),
                new FeatureUnlockByLevel(FeatureSetAbilityScoreChoice, 19)
            );

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

            CastSpellPaladin.SetSpellCastingLevel(5);

            CastSpellPaladin.SlotsPerLevels.Clear();
            CastSpellPaladin.SlotsPerLevels.AddRange(SpellsHelper.HalfCastingSlots);

            CastSpellPaladin.ReplacedSpells.Clear();
            CastSpellPaladin.ReplacedSpells.AddRange(SpellsHelper.EmptyReplacedSpells);
        }
    }
}