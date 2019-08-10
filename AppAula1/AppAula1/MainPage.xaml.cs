using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace AppAula1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var vm = new FilmeViewModel();

            BindingContext = vm;
        }

        async void Navegar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaLista());

        }
    }
}
