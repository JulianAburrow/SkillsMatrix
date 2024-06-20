namespace FrontEnd.Pages.User;

public partial class View
{
    protected override async Task OnInitializedAsync()
    {
        UserModel = await UserDb.GetUser(UserId);
    }
}
