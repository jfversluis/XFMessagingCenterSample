using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFMessagingCenterSample
{
    public partial class SenderPage : ContentPage
    {
        public SenderPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            MessagingCenter.Send<Page, DateTime>(this, "tick", DateTime.Now);
        }

        async void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
