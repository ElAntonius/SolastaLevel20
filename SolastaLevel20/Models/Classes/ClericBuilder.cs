using System.Collections.Generic;
using static SolastaModApi.DatabaseHelper.CharacterClassDefinitions;
using static SolastaModApi.DatabaseHelper.FeatureDefinitionAttributeModifiers;
using static SolastaModApi.DatabaseHelper.FeatureDefinitionFeatureSets;
using static SolastaLevel20.Models.Features.PowerClericTurnUndeadBuilder;

namespace SolastaLevel20.Models.Classes
{
    public static class ClericBuilder
    {
        public static void Load()
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
        }
    }
}