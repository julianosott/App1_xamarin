using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace AppAula1
{
    public partial class FilmeViewModel : BindableObject
    {
        private ObservableCollection<Filme> items = new ObservableCollection<Filme>();

        public ObservableCollection<Filme> Items
        {
            get => items;
            set { items = value; OnPropertyChanged(); }
        }
        public FilmeViewModel()
        {
            Items = new ObservableCollection<Filme>(
                new List<Filme>
                {
                    new Filme {Nome = "Liga da Justiça", Nota = 6},
                    new Filme {Nome = "Vingadores", Nota = 8}
                });
        }
    }
}