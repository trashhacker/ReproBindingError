using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace ReproBindingError.ViewModels
{
    public partial class ApplicationViewModel : ObservableObject
    {
        public IEnumerable<DetailViewModel> Details => details;

        private readonly ObservableCollection<DetailViewModel> details = new ObservableCollection<DetailViewModel>();

        public ApplicationViewModel()
        {
            details.Add(new DetailViewModel("Detail 1", "peter", "mavric"));
            details.Add(new DetailViewModel("Detail 2", "peter", "mavric"));
            details.Add(new DetailViewModel("Detail 3", "peter", "mavric"));
            details.Add(new DetailViewModel("Detail 4", "peter", "mavric"));
            details.Add(new DetailViewModel("Detail 5", "peter", "mavric"));
            details.Add(new DetailViewModel("Detail 6", "peter", "mavric"));
        }
    }
}
