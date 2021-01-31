using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFMessagingCenterSample
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<string> MessagingItems { get; set; } = new ObservableCollection<string>();

        public MainPage()
        {
            InitializeComponent();

            BindingContext = this;
        }

        // Subscribe (also to my YouTube Channel ;-))
        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            MessagingCenter.Subscribe<Page, DateTime>(this, "tick", (p, datetime) =>
            {
                MessagingItems.Add($"Message received at {datetime}");
            });
        }

        // Go to page
        async void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new SenderPage());
        }
    }
}
