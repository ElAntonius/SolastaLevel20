﻿using SolastaModApi;
using SolastaModApi.Infrastructure;
using System.Collections.Generic;
using static SolastaModApi.DatabaseHelper.CharacterClassDefinitions;
using static SolastaModApi.DatabaseHelper.FeatureDefinitionFeatureSets;
using static SolastaLevel20.Models.Features.ProficiencyRogueBlindSenseBuilder;
using static SolastaLevel20.Models.Features.ProficiencyRogueSlipperyMindBuilder;

namespace SolastaLevel20.Models.Classes
{
    class RogueBuilder
    {
        internal static void Load()
        {
            Rogue.FeatureUnlocks.AddRange(new List<FeatureUnlockByLevel> {
                new FeatureUnlockByLevel(ProficiencyRogueBlindSense, 14),
                new FeatureUnlockByLevel(ProficiencyRogueSlipperyMind, 15),
                new FeatureUnlockByLevel(FeatureSetAbilityScoreChoice, 16),
                // TODO 18: Elusive
                new FeatureUnlockByLevel(FeatureSetAbilityScoreChoice, 19)
                // TODO 20: Stroke of Luck
            });

            // In case TA adds levels 11-20 later on, clear them out. If that happens we can delete this section.
            DatabaseHelper.FeatureDefinitionAdditionalDamages.AdditionalDamageRogueSneakAttack.DiceByRankTable.RemoveAll(x => x.Rank > 10);
            DatabaseHelper.FeatureDefinitionAdditionalDamages.AdditionalDamageRogueSneakAttack.DiceByRankTable.AddRange(new List<DiceByRank>() {
                BuildDiceByRank(11, 6),
                BuildDiceByRank(12, 6),
                BuildDiceByRank(13, 7),
                BuildDiceByRank(14, 7),
                BuildDiceByRank(15, 8),
                BuildDiceByRank(16, 8),
                BuildDiceByRank(17, 9),
                BuildDiceByRank(18, 9),
                BuildDiceByRank(19, 10),
                BuildDiceByRank(20, 10),
            }); ;
        }
        private static DiceByRank BuildDiceByRank(int rank, int dice)
        {
            DiceByRank diceByRank = new DiceByRank();
            diceByRank.SetField("rank", rank);
            diceByRank.SetField("diceNumber", dice);
            return diceByRank;
        }
    }
}