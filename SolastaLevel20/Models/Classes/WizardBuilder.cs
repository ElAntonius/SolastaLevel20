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

            SpellListWizard.SetMaxSpellLevel(Common.FullCastingSlots[0].Slots.Count);
            SpellListWizardGreenmage.SetMaxSpellLevel(Common.FullCastingSlots[0].Slots.Count);

            CastSpellWizard.SetSpellCastingLevel(-1);

            CastSpellWizard.SlotsPerLevels.Clear();
            CastSpellWizard.SlotsPerLevels.AddRange(Common.FullCastingSlots);

            CastSpellWizard.ReplacedSpells.Clear();
            CastSpellWizard.ReplacedSpells.AddRange(Common.EmptyReplacedSpells);
        }
    }
}