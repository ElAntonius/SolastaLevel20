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

            SpellListWizardGreenmage.SetMaxSpellLevel(6);
            SpellListWizard.SetMaxSpellLevel(6);

            CastSpellWizard.SetSpellCastingLevel(-1);
            CastSpellWizard.SlotsPerLevels.Clear();
            CastSpellWizard.SlotsPerLevels.AddRange(Common.FullCastingSlots);
        }
    }
}