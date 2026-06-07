using BaseLib.Abstracts;
using MegaCrit.Sts2.Core.Localization;

namespace RelicDraft.RelicDraftCode.modifier;

public class RelicDrafting : CustomModifierModel
{
    public override LocString Title => new("modifiers", Id.Entry + ".title");

    public override LocString Description => new("modifiers", Id.Entry + ".description");

    public override ModifierAlignment Alignment => ModifierAlignment.Good;

    // negative value makes our mod show up at the top of the modifiers list for easier access
    public override int SortOrder => -1;
}
