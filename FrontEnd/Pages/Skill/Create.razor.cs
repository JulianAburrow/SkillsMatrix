namespace FrontEnd.Pages.Skill;

public partial class Create
{
	private async Task CreateSkill()
	{
		CopyDisplayModelToModel();

		await SkillDb.CreateSkill(SkillModel);

		NavigationManager.NavigateTo("/skills/index");
	}
}
