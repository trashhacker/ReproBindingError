using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReproBindingError.ViewModels
{
    public partial class DetailViewModel : ObservableObject
    {

        public IEnumerable<MaterialsViewModel> Materials => materials;

        [ObservableProperty]
        private string title;
        [ObservableProperty]
        private string name;
        [ObservableProperty]
        private string lastname;

        private readonly ObservableCollection<MaterialsViewModel> materials = new ObservableCollection<MaterialsViewModel>();
        public DetailViewModel(string title, string name, string lastname)
        {
            Title = title;
            Name = name;
            Lastname = lastname;

            materials.Add(new MaterialsViewModel("material 1", "Just for Fun"));
            materials.Add(new MaterialsViewModel("material 2", "couse i can"));
            materials.Add(new MaterialsViewModel("material 3", "its time"));
            materials.Add(new MaterialsViewModel("material 4", "to leave"));
        }
    }
}
