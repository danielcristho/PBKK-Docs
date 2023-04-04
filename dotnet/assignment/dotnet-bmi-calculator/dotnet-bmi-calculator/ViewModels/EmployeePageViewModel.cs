using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace dotnet_bmi_calculator.ViewModels
{
    public partial class EmployeePageViewModel :ObservableObject
    {
        [ObservableProperty]
        public string _empName;

        [ICommand]
        public void Save()
        {

        }
    }
}
