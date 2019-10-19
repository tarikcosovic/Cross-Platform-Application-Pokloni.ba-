using System;
using System.Collections.Generic;
using System.Text;
using Pokloni.ba.Model.Requests.Narudzba;
using Pokloni.ba.Model.Requests.Proizvodi;
using Xamarin.Forms;

namespace MobileApp.ViewModels
{
    public class KorpaViewModel : BaseViewModel
    {
        public static List<KorpaModel> ListaKorpe { get; set; } = new List<KorpaModel>();

        public static void AddToCart(NarudzbaDetailsVM model, ProizvodVM poklon)
        {
            foreach (var item in ListaKorpe)
            {
                if (item.Proizvod.ProizvodId.Equals(model.ProizvodId))
                {
                    item.Narudzba.Kolicina ++;
                    return;
                }
            }
            ListaKorpe.Add(new KorpaModel()
            {
                Narudzba = model,
                Proizvod = poklon
            });
        }

        public void LoadItems(ListView lw)
        {
            lw.ItemsSource = null;
            lw.ItemsSource = ListaKorpe;
        }

        public class KorpaModel
        {
            public NarudzbaDetailsVM Narudzba { get; set; }
            public ProizvodVM Proizvod { get; set; }
            public int CijenaProizvoda { get; set; }
        }
    }
}
