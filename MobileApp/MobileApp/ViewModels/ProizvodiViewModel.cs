using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobileApp.ViewModels
{
    public class Proizvod
    {
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Sifra { get; set; }
        public string Cijena { get; set; }

    }
    public class ProizvodiViewModel
    {
        public ObservableCollection<Proizvod> ListaProizvoda { get; set; } = new ObservableCollection<Proizvod>();
        public ICommand InitCommand{ get; set; }

        public ProizvodiViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public async Task Init()
        {

            var dummyList = new List<Proizvod>() { new Proizvod { Naziv = "Kutija bojica", Opis = "To je kutija..", Sifra = "0007", Cijena = "15$" },
            new Proizvod { Naziv = "Transformers Megatron", Opis = "Igračka za djecu megatron", Sifra = "00022", Cijena = "23$" },
            new Proizvod { Naziv = "Lančić Lotus", Opis = "Lančić zlatnih boja predivan kao poklon..", Sifra = "00056", Cijena = "9.99$" }};

            ListaProizvoda.Clear();

            foreach(var item in dummyList)
            {
                ListaProizvoda.Add(item);
            }
        }
    }
}
