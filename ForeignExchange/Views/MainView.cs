using System;

using Xamarin.Forms;

namespace ForeignExchange.Views
{
    public class MainView : ContentPage
    {
        public MainView()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

