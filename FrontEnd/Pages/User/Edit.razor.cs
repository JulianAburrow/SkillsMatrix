namespace FrontEnd.Pages.User;

public partial class Edit
{
    protected override async Task OnInitializedAsync()
    {
        UserModel = await UserDb.GetUser(UserId);

        UserDisplayModel.FirstName = UserModel.FirstName;
        UserDisplayModel.LastName = UserModel.LastName;
        UserDisplayModel.StatusId = UserModel.StatusId;

        UserStatuses = await UserStatusDb.GetUserStatuses();
    }

    private async Task UpdateUser()
    {
        CopyDisplayModelToModel();

        await UserDb.UpdateUser(UserModel);

        NavigationManager.NavigateTo($"/user/view/{UserId}");
    }
}
