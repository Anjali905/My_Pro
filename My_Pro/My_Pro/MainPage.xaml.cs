using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace My_Pro
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        async void SaveButton_Clicked(object sender, EventArgs e)
        {
            bool resp = await DisplayAlert("Save ? ","Do you want to continue ? ", "yes", "No");
            Console.WriteLine("Save ?", resp);
        }
    }
}
