using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BuscaCEP.ViewModel
{
    class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /*protected void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            if (PropertyChanged is null)
                return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }*/

        protected void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            if (PropertyChanged is null)
                return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
