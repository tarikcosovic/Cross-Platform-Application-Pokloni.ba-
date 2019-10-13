using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp.ViewModels
{
    public class FeedbackViewModel : BaseViewModel
    {
        int _ocjena = 3;
        public int Ocjena
        {
            get { return _ocjena; }
            set { SetProperty(ref _ocjena, value); }
        }

        string _komentar = String.Empty;
        public string Komentar
        {
            get { return _komentar; }
            set { SetProperty(ref _komentar, value); }
        }

    }
}
