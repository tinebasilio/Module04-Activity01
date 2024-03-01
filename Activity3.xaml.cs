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
    public partial class Activity3 : ContentPage
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        public ObservableCollection<Employee> Employees { get { return employees; } }

        public Activity3()
        {
            InitializeComponent();

            EmployeeView.ItemsSource = employees;

            employees.Add(new Employee 
            { 
                DisplayName = "Juan Dela Cruz", 
                Position = "President", 
                Image = "https://i.pinimg.com/736x/55/5f/a1/555fa11c239de61ab2a086972b95f523.jpg"
            });

            employees.Add(new Employee { 
                DisplayName = "John Doe", Position = "Vice President", 
                Image = "https://i.pinimg.com/736x/55/5f/a1/555fa11c239de61ab2a086972b95f523.jpg"
            });

            employees.Add(new Employee { 
                DisplayName = "Peter Doe", 
                Position = "Secretary", 
                Image = "https://i.pinimg.com/736x/55/5f/a1/555fa11c239de61ab2a086972b95f523.jpg"
            });

            employees.Add(new Employee { 
                DisplayName = "Mark Cruz", 
                Position = "Supervisor", 
                Image = "https://i.pinimg.com/736x/55/5f/a1/555fa11c239de61ab2a086972b95f523.jpg"
            });

            employees.Add(new Employee { 
                DisplayName = "Juan Dela Cruz", 
                Position = "Manager", 
                Image = "https://i.pinimg.com/736x/55/5f/a1/555fa11c239de61ab2a086972b95f523.jpg" 
            });

        }
    }
}