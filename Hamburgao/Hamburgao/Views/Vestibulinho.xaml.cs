using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hamburgao.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Vestibulinho : ContentPage
    {
        public Vestibulinho()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Device.OpenUri(new Uri("htt´://www.vestibulinhoetec.com.br"));
            }
            catch (Exception ex)
            {
                await DisplayAlert("IXI", ex.Message, "OK");
            }
        }
    }
}