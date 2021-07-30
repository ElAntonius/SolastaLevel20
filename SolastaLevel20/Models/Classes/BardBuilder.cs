﻿using SolastaModApi.Extensions;

namespace SolastaLevel20.Models.Classes
{
    internal static class BardBuilder
    {
        internal static void Load()
        {
            DatabaseRepository.GetDatabase<FeatureDefinitionCastSpell>().TryGetElement("BardClassSpellcasting", out FeatureDefinitionCastSpell featureDefinitionCastSpell);

            if (featureDefinitionCastSpell != null)
            {
                featureDefinitionCastSpell.SetSpellCastingLevel(9);

                featureDefinitionCastSpell.SlotsPerLevels.Clear();
                featureDefinitionCastSpell.SlotsPerLevels.AddRange(SpellsHelper.FullCastingSlots);

                featureDefinitionCastSpell.ReplacedSpells.Clear();
                featureDefinitionCastSpell.ReplacedSpells.AddRange(SpellsHelper.FullCasterReplacedSpells);
            }
        }
    }
}