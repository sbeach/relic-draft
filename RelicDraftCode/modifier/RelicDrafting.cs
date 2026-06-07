using BaseLib.Abstracts;

namespace RelicDraft.RelicDraftCode.modifier;

public class RelicDrafting : CustomModifierModel
{
    public override ModifierAlignment Alignment => ModifierAlignment.Good;

    public override int SortOrder => -1;
}
