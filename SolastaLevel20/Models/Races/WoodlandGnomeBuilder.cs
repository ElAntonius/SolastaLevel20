namespace SolastaLevel20.Models.Classes
{
    internal static class WoodlandGnomeBuilder
    {
        internal static void Load()
        {
            DatabaseRepository.GetDatabase<FeatureDefinitionCastSpell>().TryGetElement("NaturalIllusionistSpellList", out FeatureDefinitionCastSpell gnomeNaturalIllusionist);

            if (gnomeNaturalIllusionist != null)
            {
                gnomeNaturalIllusionist.ReplacedSpells.Clear();
                gnomeNaturalIllusionist.ReplacedSpells.AddRange(SpellsHelper.EmptyReplacedSpells);
            }
        }
    }
}