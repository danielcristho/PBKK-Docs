using BMICalculator.ViewModels;

namespace BMICalculator;

public partial class EmployeePage : ContentPage
{
	public EmployeePage()
	{
		InitializeComponent();
		this.BindingContext = new EmployeePageViewModel();
	}
}