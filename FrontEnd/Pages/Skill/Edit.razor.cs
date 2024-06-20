namespace FrontEnd.Pages.Skill
{
    public partial class Edit
    {

        protected override async Task OnInitializedAsync()
        {
            SkillModel = await SkillDb.GetSkill(SkillId);
            SkillDisplayModel.SkillName = SkillModel.SkillName;
        }

        private async Task UpdateSkill()
        {
            CopyDisplayModelToModel();

            await SkillDb.UpdateSkill(SkillModel);

            NavigationManager.NavigateTo($"/skill/view/{SkillId}");
        }
    }
}
