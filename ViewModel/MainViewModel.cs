using System.ComponentModel;

namespace CellBank.ViewModel
{
    class MainViewModel 
    {
        private DonorViewModel _currentDonorVM = new DonorViewModel();

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
