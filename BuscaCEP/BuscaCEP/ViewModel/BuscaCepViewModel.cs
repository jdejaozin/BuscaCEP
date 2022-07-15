using System;
using System.Collections.Generic;
using System.Text;

namespace BuscaCEP.ViewModel
{
    class BuscaCepViewModel : ViewModelBase
    {
        private string _CEP;
        public string CEP
        {
            get => _CEP;
            set
            {
                _CEP = value;
                OnPropertyChanged();
            }
        }
    }
}
