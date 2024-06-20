namespace FrontEnd.Shared.BasePageClasses;

public class BasePageClass : ComponentBase
{
    [Inject] protected NavigationManager NavigationManager { get; set; }
}
