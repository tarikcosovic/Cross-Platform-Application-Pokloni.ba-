using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace MobileApp.ViewModels
{
    public class PokloniViewModel
    {
        private readonly APIService _apiService = new APIService("Proizvodi");
        private IEnumerable<Proizvod> _listaProizvoda = null;
        public PokloniViewModel()
        {
            _listaProizvoda = new List<Proizvod>();
        }

        public async void LoadList(TableSection table)
        {
            _listaProizvoda = await _apiService.Get<IEnumerable<Proizvod>>();

            foreach(var item in _listaProizvoda)
            {
                //NAPRAVITI IMAGE SOURCE DA SLIKA RADI
                Stream stream = new MemoryStream(item.Slika);
                table.Add(new ImageCell() { Text = item.Naziv, Detail = item.Opis });
            }
        }
    }
}
