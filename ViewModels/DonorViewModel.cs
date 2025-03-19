using System.ComponentModel;
using System.Text.RegularExpressions;

namespace CellBank.ViewModel
{
    class DonorViewModel : INotifyPropertyChanged, IDataErrorInfo
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public string Error => null;

        private string _gender;
        private bool _isGenderValid = true;

        private int _age;

        public string Gender
        {
            get => _gender;
            set
            {
                value.Trim();
                ValidateGender(value);
                _gender = value;
                OnPropertyChanged(nameof(Gender));
            }
        }

        public int Age
        {
            get => _age;
            set
            {
                _age = value;
                OnPropertyChanged(nameof(Age));
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void ValidateGender(string gender)
        {
            _isGenderValid = !string.IsNullOrEmpty(gender);
            var genderInput = gender.ToUpper();
            if (!Regex.IsMatch(genderInput, @"^[XY]+$"))
            {
                _isGenderValid = false;
            }
        }

        public virtual string this[string propName]
        {
            get
            {
                switch (propName)
                {
                    case nameof(Gender):
                        if (!_isGenderValid)
                        {
                            return "Please provide Gender info.";
                        }
                        break;
                    case nameof(Age):
                        if (Age < 0)
                        {
                            return "Age is positive number or zero.";
                        }
                        break;
                }
                return null;
            }
        }
    }
}
