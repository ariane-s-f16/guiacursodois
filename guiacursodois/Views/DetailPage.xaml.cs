
using Microsoft.Maui.Controls;

namespace guiacursodois.Views;

public partial class DetailPage : ContentPage
{
	public DetailPage()
	{
		InitializeComponent();
    }
    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {
        var parameters = Shell.Current.Navigation.NavigationStack[^1].Query ?? new Dictionary<string, string>();

        // Inicializando o ViewModel
        BindingContext = new DetailPageViewModel(parameters);
    }
}