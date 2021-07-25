using System.Collections.Generic;
using SolastaModApi.Extensions;
using static SolastaModApi.DatabaseHelper.CharacterClassDefinitions;
using static SolastaModApi.DatabaseHelper.FeatureDefinitionCastSpells;
using static SolastaModApi.DatabaseHelper.FeatureDefinitionFeatureSets;
using static SolastaModApi.DatabaseHelper.SpellListDefinitions;

namespace SolastaLevel20.Models.Classes
{
    internal static class WizardBuilder
    {


        internal static void Load()
        {
            // add missing progression
            Wizard.FeatureUnlocks.AddRange(new List<FeatureUnlockByLevel> {
                // TODO 14: Overchannel
                new FeatureUnlockByLevel(FeatureSetAbilityScoreChoice, 16),
                // TODO 18: Spell Mastery
                new FeatureUnlockByLevel(FeatureSetAbilityScoreChoice, 19)
                // TODO 20: Signature Spells
            });

            var maxSpellLevel = 9;
            int accountForCantrips;

            accountForCantrips = SpellListWizard.HasCantrips ? 1 : 0;
            SpellListWizard.SetMaxSpellLevel(maxSpellLevel);

            while (SpellListWizard.SpellsByLevel.Count < maxSpellLevel + accountForCantrips)
            {
                SpellListWizard.SpellsByLevel.Add(new SpellListDefinition.SpellsByLevelDuplet() { Level = SpellListWizard.SpellsByLevel.Count + 1, Spells = new List<SpellDefinition>() });
            }

            accountForCantrips = SpellListWizardGreenmage.HasCantrips ? 1 : 0;
            SpellListWizardGreenmage.SetMaxSpellLevel(maxSpellLevel);

            while (SpellListWizardGreenmage.SpellsByLevel.Count < maxSpellLevel + accountForCantrips)
            {
                SpellListWizardGreenmage.SpellsByLevel.Add(new SpellListDefinition.SpellsByLevelDuplet() { Level = SpellListWizardGreenmage.SpellsByLevel.Count + 1, Spells = new List<SpellDefinition>() });
            }


            CastSpellWizard.SetSpellCastingLevel(-1);

            CastSpellWizard.SlotsPerLevels.Clear();
            CastSpellWizard.SlotsPerLevels.AddRange(Common.FullCastingSlots);

            CastSpellWizard.ReplacedSpells.Clear();
            CastSpellWizard.ReplacedSpells.AddRange(Common.EmptyReplacedSpells);
        }
    }
}