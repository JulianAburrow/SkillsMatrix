namespace FrontEnd.Pages.Skill
{
    public partial class View
    {

        protected override async Task OnInitializedAsync()
        {
            SkillModel = await SkillDb.GetSkill(SkillId);
        }
    }
}
