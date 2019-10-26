using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace MobileApp.ViewModels
{
    public class PocetnaViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName]string name = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
