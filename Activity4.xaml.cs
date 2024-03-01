using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Activity4 : ContentPage
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        public ObservableCollection<Employee> Employees { get { return employees; } }
        public Activity4()
        {
            InitializeComponent();

            EmployeeView.ItemsSource = employees;

            employees.Add(new Employee
            {
                DisplayName = "Juan Dela Cruz",
                Position = "President",
                Image = "https://media.tenor.com/notUnAjgm8UAAAAM/beluga-cat-meme.gif"
            });

            employees.Add(new Employee
            {
                DisplayName = "John Doe",
                Position = "Vice President",
                Image = "https://media.tenor.com/notUnAjgm8UAAAAM/beluga-cat-meme.gif"
            });

            employees.Add(new Employee
            {
                DisplayName = "Peter Doe",
                Position = "Secretary",
                Image = "https://media.tenor.com/notUnAjgm8UAAAAM/beluga-cat-meme.gif"
            });

            employees.Add(new Employee
            {
                DisplayName = "Mark Cruz",
                Position = "Supervisor",
                Image = "https://media.tenor.com/notUnAjgm8UAAAAM/beluga-cat-meme.gif"
            });

            employees.Add(new Employee
            {
                DisplayName = "Juan Dela Cruz",
                Position = "Manager",
                Image = "https://media.tenor.com/notUnAjgm8UAAAAM/beluga-cat-meme.gif"
            });

        }

        private void displayMessage(object sender, ToggledEventArgs e)
        {
            SwitchCell switchCell = (SwitchCell) sender;
            bool isToggledOn = e.Value;

            if (isToggledOn)
            {
                DisplayAlert("Switch Toggled On", "The switch is now turned on!", "OK");
            }
            else
            {
                DisplayAlert("Switch Toggled Off", "The switch is now turned off!", "OK");
            }
        }
    }
}