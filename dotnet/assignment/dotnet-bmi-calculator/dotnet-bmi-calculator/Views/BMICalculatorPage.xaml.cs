namespace dotnet_bmi_calculator.ViewModels;
using dotnet_bmi_calculator.Views;
public partial class BMICalculatorPage : ContentPage
{
	public BMICalculatorPage()
	{
		InitializeComponent();

		this.BindingContext = new BMICalculatorPageViewModel();
	}
}