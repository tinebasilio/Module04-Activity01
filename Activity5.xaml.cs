using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Activity5 : ContentPage
    {
        public Activity5()
        {
            InitializeComponent();
        }

        void OnSubmitEntry(object sender, EventArgs e)
        {
            string entry1Text = fname.Text;
            string entry2Text = lname.Text;
            string entry3Text = myEmail.Text;
            DisplayAlert("Entered values",
                $"First Name: {entry1Text}\n" +
                $"Last Name: {entry2Text}\n" +
                $"Email: {entry3Text}\n" +
                $"Are you sure you want to submit?", "OK", "Cancel");
     
        }
    }
}