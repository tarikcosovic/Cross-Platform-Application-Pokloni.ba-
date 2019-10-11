using Pokloni.ba.Model.Requests.Proizvodi;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp.ViewModels
{
    public class PokloniDetailsViewModel : BaseViewModel
    {

        string _naziv = String.Empty;
        public string Naziv
        {
            get { return _naziv; }
            set { SetProperty(ref _naziv, value); }
        }

        string _opis = String.Empty;
        public string Opis
        {
            get { return _opis; }
            set { SetProperty(ref _opis, value); }
        }

        byte[] _slika = null;
        public byte[] Slika
        {
            get { return _slika; }
            set { SetProperty(ref _slika, value); }
        }

        decimal _cijena = decimal.Zero;
        public decimal Cijena
        {
            get { return _cijena; }
            set { SetProperty(ref _cijena, value); }
        }

        public PokloniDetailsViewModel(ProizvodVM proizvod)
        {
            _naziv = proizvod.Naziv;
            _opis = proizvod.Opis;
            _slika = proizvod.Slika;
            _cijena = proizvod.Cijena;
        }
    }
}
