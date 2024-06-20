namespace FrontEnd.Pages.Skill;

public partial class Index
{
	private List<SkillModel> Skills { get; set; }

	protected override async Task OnInitializedAsync()
	{
		Skills = await SkillDb.GetSkills();
	}
}
