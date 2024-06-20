namespace FrontEnd.Shared.BasePageClasses;

public class SkillBasePageClass : BasePageClass
{
    [Inject] protected ISkillData SkillDb { get; set; }

    [Parameter] public int SkillId { get; set; }

    protected SkillModel SkillModel = new();

    protected SkillDisplayModel SkillDisplayModel = new();

    protected void CopyDisplayModelToModel()
    {
        SkillModel.SkillName = SkillDisplayModel.SkillName;
    }
}
