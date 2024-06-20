namespace FrontEnd.Pages.User;

public partial class Index
{
    private List<UserModel> Users { get; set; }

    protected async override Task OnInitializedAsync()
    {
        Users = await UserDb.GetUsers();
    }        
}
