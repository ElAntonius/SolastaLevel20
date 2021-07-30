using static SolastaModApi.DatabaseHelper.FeatureDefinitionCastSpells;

namespace SolastaLevel20.Models.Classes
{
    internal static class ElfHighBuilder
    {
        internal static void Load()
        {
            CastSpellElfHigh.ReplacedSpells.Clear();
            CastSpellElfHigh.ReplacedSpells.AddRange(SpellsHelper.EmptyReplacedSpells);
        }
    }
}