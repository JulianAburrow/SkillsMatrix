namespace FrontEnd.Pages.User;

public partial class Delete
{

    protected override async Task OnInitializedAsync()
    {
        UserModel = await UserDb.GetUser(UserId);
    }

    private async Task DeleteUser()
    {
        await UserDb.DeleteUser(UserId);

        NavigationManager.NavigateTo("/users/index");
    }
}
