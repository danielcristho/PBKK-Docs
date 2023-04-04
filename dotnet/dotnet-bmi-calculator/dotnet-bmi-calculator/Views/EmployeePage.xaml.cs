using dotnet_bmi_calculator.ViewModels;
// using Java.Security;
using Microsoft.Toolkit.Mvvm.Input;


namespace dotnet_bmi_calculator.Views;

public partial class EmployeePage : ContentPage
{
	public EmployeePage()
	{
		InitializeComponent();
		this.BindingContext = new EmployeePageViewModel();

	}
}