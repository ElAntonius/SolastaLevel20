using System.Collections.Generic;
using SolastaModApi.Extensions;
using static SolastaModApi.DatabaseHelper.CharacterClassDefinitions;
using static SolastaModApi.DatabaseHelper.FeatureDefinitionAttributeModifiers;
using static SolastaModApi.DatabaseHelper.FeatureDefinitionCastSpells;
using static SolastaModApi.DatabaseHelper.FeatureDefinitionFeatureSets;
using static SolastaModApi.DatabaseHelper.SpellListDefinitions;
using static SolastaLevel20.Models.Features.PowerClericTurnUndeadBuilder;

namespace SolastaLevel20.Models.Classes
{
    internal static class ClericBuilder
    {
        internal static void Load()
        {
            // add missing progression
            Cleric.FeatureUnlocks.AddRange(new List<FeatureUnlockByLevel> {
                new FeatureUnlockByLevel(PowerClericTurnUndead14, 14),
                new FeatureUnlockByLevel(FeatureSetAbilityScoreChoice, 16),
                new FeatureUnlockByLevel(PowerClericTurnUndead17, 17),
                new FeatureUnlockByLevel(AttributeModifierClericChannelDivinityAdd, 18),
                new FeatureUnlockByLevel(FeatureSetAbilityScoreChoice, 19)
                // TODO 20: Divine Intervention Improvement
            });

            var maxSpellLevel = 9;
            var accountForCantrips = SpellListCleric.HasCantrips ? 1 : 0;

            SpellListCleric.SetMaxSpellLevel(maxSpellLevel);

            while (SpellListCleric.SpellsByLevel.Count < maxSpellLevel + accountForCantrips)
            {
                SpellListCleric.SpellsByLevel.Add(new SpellListDefinition.SpellsByLevelDuplet() { Level = SpellListCleric.SpellsByLevel.Count + 1, Spells = new List<SpellDefinition>() });
            }
            

            CastSpellCleric.SetSpellCastingLevel(-1);

            CastSpellCleric.SlotsPerLevels.Clear();
            CastSpellCleric.SlotsPerLevels.AddRange(Common.FullCastingSlots);

            CastSpellCleric.ReplacedSpells.Clear();
            CastSpellCleric.ReplacedSpells.AddRange(Common.EmptyReplacedSpells);
        }
    }
}