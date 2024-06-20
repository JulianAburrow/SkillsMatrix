namespace FrontEnd.Pages.User;

public partial class Create
{
    protected override async Task OnInitializedAsync()
    {
        UserDisplayModel.StatusId = CommonlyUsedValues.PleaseSelectValue;
        UserDisplayModel.UserSkill = new List<UserSkillDisplayModel>();

        UserStatuses = await UserStatusDb.GetUserStatuses();
        UserStatuses.Insert(0, new UserStatusModel
        {
            StatusId = CommonlyUsedValues.PleaseSelectValue,
            StatusName = CommonlyUsedValues.PleaseSelectText,
        });

        Skills = await SkillDb.GetSkills();

        for (var i = 0; i < Skills.Count; i++)
        {
            UserDisplayModel.UserSkill.Add(new UserSkillDisplayModel
            {
                SkillId = Skills[i].SkillId,
                UserSkillScore = 0,
            });
        }
    }

    private async Task CreateUser()
    {
        CopyDisplayModelToModel();

        try
        {
            await UserDb.CreateUser(UserModel);
            NavigationManager.NavigateTo("users/index");
        }
        catch
        {

        }
    }
}
