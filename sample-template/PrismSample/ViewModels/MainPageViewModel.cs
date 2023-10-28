namespace PrismSample.ViewModels;

public sealed class MainPageViewModel : BindableBase
{
    private string _title = "Prism Sample";
    public string Title
    {
        get => _title;
        set => SetProperty(ref _title, value);
    }
}