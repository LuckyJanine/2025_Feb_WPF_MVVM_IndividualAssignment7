using CellBank.Enums;
using System.Collections.ObjectModel;

namespace CellBank.ViewModel
{
    class MainViewModel 
    {
        public ObservableCollection<BloodType> BloodTypes { get; }

        private DonorViewModel _currentDonorVM = new DonorViewModel();

        public MainViewModel()
        {
            BloodTypes = new ObservableCollection<BloodType>(
                (BloodType[])Enum.GetValues(typeof(BloodType)));
        }

        public DonorViewModel CurrentDonor
        {
            get => _currentDonorVM;
            set
            {
                _currentDonorVM = value;
            }
        }
    }
}
