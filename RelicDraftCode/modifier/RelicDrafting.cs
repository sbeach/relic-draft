using BaseLib.Abstracts;

namespace RelicDraft.RelicDraftCode.modifier;

public class RelicDrafting : CustomModifierModel
{
    public override ModifierAlignment Alignment => ModifierAlignment.Good;

    // negative value makes our mod show up at the top of the modifiers list for easier access
    public override int SortOrder => -1;
}
