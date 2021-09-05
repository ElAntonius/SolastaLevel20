﻿using System.Collections.Generic;
using SolastaModApi.Extensions;
using static SolastaModApi.DatabaseHelper.CharacterClassDefinitions;
using static SolastaModApi.DatabaseHelper.FeatureDefinitionCastSpells;
using static SolastaModApi.DatabaseHelper.FeatureDefinitionFeatureSets;
using static SolastaLevel20.Models.Features.ActionAffinityRangerVanishActionBuilder;
using static SolastaLevel20.Models.Features.FeatureSetRangerFoeSlayerBuilder;

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
                new FeatureUnlockByLevel(FeatureSetRangerFoeSlayer, 20)
            });

            CastSpellRanger.SetSpellCastingLevel(5);

            CastSpellRanger.SlotsPerLevels.Clear();
            CastSpellRanger.SlotsPerLevels.AddRange(SpellsHelper.HalfCastingSlots);

            CastSpellRanger.ReplacedSpells.Clear();
            CastSpellRanger.ReplacedSpells.AddRange(SpellsHelper.HalfCasterReplacedSpells);
        }
    }
}