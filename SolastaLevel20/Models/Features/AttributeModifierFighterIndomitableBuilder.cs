﻿using SolastaModApi;
using SolastaModApi.Extensions;
using static SolastaModApi.DatabaseHelper.FeatureDefinitionAttributeModifiers;

namespace SolastaLevel20.Models.Features
{
    internal class AttributeModifierFighterIndomitableBuilder : BaseDefinitionBuilder<FeatureDefinitionAttributeModifier>
    {
        const string AttributeModifierFighterIndomitableAddName = "ZSAttributeModifierFighterIndomitableAdd";
        const string AttributeModifierFighterIndomitableAddGuid = "8a2f09cafd7b47d886cb0ce098c4f477";

        protected AttributeModifierFighterIndomitableBuilder(string name, string guid) : base(AttributeModifierFighterIndomitable, name, guid)
        {
            Definition.GuiPresentation.Title = "Feature/&IndomitableResistanceAddTitle";
            Definition.GuiPresentation.Description = "Feature/&IndomitableResistanceAddDescription";
            Definition.SetModifierType2(FeatureDefinitionAttributeModifier.AttributeModifierOperation.Additive);
        }

        private static FeatureDefinitionAttributeModifier CreateAndAddToDB(string name, string guid)
            => new AttributeModifierFighterIndomitableBuilder(name, guid).AddToDB();

        public static readonly FeatureDefinitionAttributeModifier AttributeModifierFighterIndomitableAdd = 
            CreateAndAddToDB(AttributeModifierFighterIndomitableAddName, AttributeModifierFighterIndomitableAddGuid);
    }
}