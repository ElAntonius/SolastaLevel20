﻿using System.Collections.Generic;
using SolastaModApi.Extensions;
using static SolastaModApi.DatabaseHelper.CharacterClassDefinitions;
using static SolastaModApi.DatabaseHelper.FeatureDefinitionCastSpells;
using static SolastaModApi.DatabaseHelper.FeatureDefinitionFeatureSets;
using static SolastaModApi.DatabaseHelper.SpellListDefinitions;
using static SolastaLevel20.Models.Features.ActionAffinityRangerVanishActionBuilder;

namespace SolastaLevel20.Models.Classes
{
    internal static class RangerBuilder
    {
        internal static void Load()
        {
            Ranger.FeatureUnlocks.AddRange(new List<FeatureUnlockByLevel> {
                new FeatureUnlockByLevel(AdditionalDamageRangerFavoredEnemyChoice, 14),
                new FeatureUnlockByLevel(ActionAffinityRangerVanishAction, 14),
                new FeatureUnlockByLevel(FeatureSetAbilityScoreChoice, 16),
                // TODO 18: Feral Senses
                new FeatureUnlockByLevel(FeatureSetAbilityScoreChoice, 19),
                // TODO 20: Foe Slayer
            });

            var maxSpellLevel = 5;
            var accountForCantrips = SpellListRanger.HasCantrips ? 1 : 0;

            SpellListRanger.SetMaxSpellLevel(maxSpellLevel);

            while (SpellListRanger.SpellsByLevel.Count < maxSpellLevel + accountForCantrips)
            {
                SpellListRanger.SpellsByLevel.Add(new SpellListDefinition.SpellsByLevelDuplet() { Level = SpellListRanger.SpellsByLevel.Count + 1, Spells = new List<SpellDefinition>() });
            }

            CastSpellRanger.SetSpellCastingLevel(-1);

            CastSpellRanger.SlotsPerLevels.Clear();
            CastSpellRanger.SlotsPerLevels.AddRange(Common.HalfCastingSlots);

            CastSpellRanger.ReplacedSpells.Clear();
            CastSpellRanger.ReplacedSpells.AddRange(Common.HalfCasterReplacedSpells);
        }
    }
}