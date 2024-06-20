namespace FrontEnd.Shared.BasePageClasses;

public class UserBasePageClass : BasePageClass
{
    [Inject] protected IUserData UserDb { get; set; }

    [Inject] protected IUserStatusData UserStatusDb { get; set; }

    [Inject] protected ISkillData SkillDb { get; set; }

    protected UserModel UserModel { get; set; } = new();

    protected UserDisplayModel UserDisplayModel = new();

    protected List<UserStatusModel> UserStatuses { get; set; }

    protected List<SkillModel> Skills = new();

    [Parameter] public int UserId { get; set; }


    protected void CopyDisplayModelToModel()
    {
        UserModel.FirstName = UserDisplayModel.FirstName;
        UserModel.LastName = UserDisplayModel.LastName;
        UserModel.StatusId = UserDisplayModel.StatusId;
        //UserModel.UserSkill = new List<UserSkillModel>();
        //for (var i = 0; i < UserDisplayModel.UserSkill.Count; i++)
        //{
        //    UserModel.UserSkill.Add(new UserSkillModel
        //    {
        //        UserSkillId = UserDisplayModel.UserSkill[i].UserSkillId,
        //        UserSkillScore = UserDisplayModel.UserSkill[i].UserSkillScore,
        //    });
        //}
    }
}
