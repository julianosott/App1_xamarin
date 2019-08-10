using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppAula1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaLista : ContentPage
    {

        public PaginaLista()
        {
            InitializeComponent();
            var vm = new FilmeViewModel();

            BindingContext = vm;
        }
    }
}