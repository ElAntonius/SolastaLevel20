using SolastaModApi.Extensions;

namespace SolastaLevel20.Models.Classes
{
    internal static class AlchemistBuilder
    {
        internal static void Load()
        {
            DatabaseRepository.GetDatabase<FeatureDefinitionCastSpell>().TryGetElement("AlchemistClassSpellcasting", out FeatureDefinitionCastSpell featureDefinitionCastSpell);

            if (featureDefinitionCastSpell != null)
            {
                featureDefinitionCastSpell.SetSpellCastingLevel(5);

                featureDefinitionCastSpell.SlotsPerLevels.Clear();
                featureDefinitionCastSpell.SlotsPerLevels.AddRange(SpellsHelper.TinkererCastingSlots);

                featureDefinitionCastSpell.ReplacedSpells.Clear();
                featureDefinitionCastSpell.ReplacedSpells.AddRange(SpellsHelper.FullCasterReplacedSpells);
            }
        }
    }
}