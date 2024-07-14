using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReproBindingError.ViewModels
{
    public partial class MaterialsViewModel : ObservableObject
    {
        [ObservableProperty]
        private string identifier;
        [ObservableProperty]
        private string description;

        public MaterialsViewModel(string identifier, string description)
        {
            this.identifier = identifier;
            this.description = description;
        }
    }
}
