using MvvmBinding.ViewModel;

namespace MvvmBinding;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}

