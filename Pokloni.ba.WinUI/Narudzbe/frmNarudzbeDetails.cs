using System;
using System.Collections.Generic;
using Pokloni.ba.Model.Requests.Narudzba;
using System.Windows.Forms;
using Pokloni.ba.Model;
using Flurl.Http;
using Pokloni.ba.Model.Requests.Proizvodi;
using Pokloni.ba.WinUI.Korisnici;

namespace Pokloni.ba.WinUI.Narudzbe
{
    public partial class frmNarudzbeDetails : MyMaterialForm
    {
        private readonly APIService _apiServiceNarudzbeDetails = new APIService(Properties.Settings.Default.RouteNarudzbeDetails);
        private readonly APIService _apiServiceNarudzbe = new APIService(Properties.Settings.Default.RouteNarudzbe);
        private readonly APIService _apiServiceKorisnici = new APIService(Properties.Settings.Default.RouteKorisnici);
        private readonly APIService _apiServiceProizvodi = new APIService(Properties.Settings.Default.RouteProizvodi);
        private readonly int _id;
        private string _status = string.Empty;
        private int _kupacId;

        private List<Tuple<ProizvodVM, int?>> _proizvodi = new List<Tuple<ProizvodVM, int?>>();
        public frmNarudzbeDetails(int id)
        {
            InitializeComponent();
            InitialiseMyMaterialDesign(this);

            _id = id;
        }

        private async void FrmNarudzbeDetails_Load(object sender, EventArgs e)
        {
            var result = await _apiServiceNarudzbeDetails.Get<IEnumerable<Model.Requests.Narudzba.NarudzbaDetailsVM>>();
            var narudzba = await _apiServiceNarudzbe.GetbyId<NarudzbaVM>(_id);
            _kupacId = (int)narudzba.KorisnikId;
            _status = narudzba.StatusPoruka;


            decimal? ukupno = 0;

            listaProizvoda.Items.Clear();
            foreach (var item in result)
            {
                if (item.NarudzbaId == _id)
                {
                    ListViewItem temp = new ListViewItem();

                    decimal? popust = 0;
                    if (item.Popust != null)
                        popust = (item.Proizvod.Cijena * (item.Popust / 100));
                    ukupno += (item.Proizvod.Cijena - popust) * item.Kolicina;
                    var tempUkupno = (item.Proizvod.Cijena - popust) * item.Kolicina;
                    Math.Round((double)ukupno, 2);

                    temp.SubItems.Add(item.Proizvod.Naziv);
                    temp.SubItems.Add(item.Kolicina.ToString());

                    if (item.Popust == 0)
                        temp.SubItems.Add("Nema");
                    else
                        temp.SubItems.Add(item.Popust.ToString() + "%");

                    temp.SubItems.Add(((double)tempUkupno).ToString() + "$");

                    listaProizvoda.Items.Add(temp);
                    _proizvodi.Add(new Tuple<ProizvodVM, int?>(item.Proizvod, item.Kolicina));
                }
            }
            UkupnaCijena.Text = ((double)ukupno).ToString() + "$";

            LoadStatusUI();
        }

        private void LoadStatusUI()
        {
            switch (_status)
            {
                case "Aktivno":
                    btnPrihvati.Text = "Prihvati";
                    status.Text = "Aktivna narudžba";
                    break;
                case "Prihvaćeno":
                    btnPrihvati.Text = "Završi";
                    status.Text = "Prihvaćena narudžba";
                    break;
                case "Odbijeno":
                    btnPrihvati.Enabled = false;
                    btnPrihvati.Visible = false;
                    btnOdbij.Enabled = false;
                    btnOdbij.Visible = false;
                    break;
            }
        }

        private async void PrihvatiNarudzbu()
        {
            try
            {
                foreach (var item in _proizvodi)
                {
                    if (item.Item1.StanjeNaLageru > item.Item2.Value)
                    {
                    }
                    else MessageBox.Show("Trenutno nemamo proizvod: " + item.Item1.Naziv + " na stanju u toj količini, trenutno stanje je: " + item.Item1.StanjeNaLageru, "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                var korisnik = await _apiServiceKorisnici.GetUserByUsername<Korisnik>(APIService.Username);

                var temp = await _apiServiceNarudzbe.GetbyId<NarudzbaVM>(_id);
                temp.StatusPoruka = "Prihvaćeno";
                temp.ZaposlenikId = korisnik.KorisnikId;

                await _apiServiceNarudzbe.Update<NarudzbaVM>(temp, _id);
            }
            catch (FlurlHttpException ex)
            {

            }
            btnPrihvati.Enabled = false;
            btnPrihvati.Visible = false;

            MessageBox.Show("Uspješno ste prihvatili narudžbu..", "Uspjeh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void ZavrsiNarudzbu()
        {
            var temp = await _apiServiceNarudzbe.GetbyId<NarudzbaVM>(_id);
            temp.StatusPoruka = "Završeno";

            await _apiServiceNarudzbe.Update<NarudzbaVM>(temp, _id);
            MessageBox.Show("Uspješno ste završili narudžbu..", "Uspjeh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void BtnOdbij_Click(object sender, EventArgs e)
        {
            DialogResult test = MessageBox.Show("Da li ste sigurni da želite odbiti narudžbu?", "Upozorenje!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (test == DialogResult.Yes)
            {
                try
                {

                    var korisnik = await _apiServiceKorisnici.GetUserByUsername<Korisnik>(APIService.Username);

                    var temp = await _apiServiceNarudzbe.GetbyId<NarudzbaVM>(_id);
                    temp.StatusPoruka = "Odbijeno";
                    temp.ZaposlenikId = korisnik.KorisnikId;

                    await _apiServiceNarudzbe.Update<NarudzbaVM>(temp, _id);

                    foreach (var item in _proizvodi)
                    {
                        item.Item1.StanjeNaLageru += item.Item2.Value;
                        await _apiServiceProizvodi.Update<ProizvodVM>(item.Item1, item.Item1.ProizvodId);
                    }

                    btnPrihvati.Enabled = false;
                    btnPrihvati.Visible = false;
                    btnOdbij.Enabled = false;
                    btnOdbij.Visible = false;
                    MessageBox.Show("Uspješno ste odbili narudžbu..", "Uspjeh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dogodila se greška nad dobavljanjem narudžbe sa servera..", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnPrihvati_Click(object sender, EventArgs e)
        {
            DialogResult test = MessageBox.Show("Da li ste sigurni da želite prihvatiti narudžbu?", "Upozorenje!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (test == DialogResult.Yes)
            {
                try
                {

                    switch (_status)
                    {
                        case "Aktivno":
                            PrihvatiNarudzbu();
                            break;
                        case "Prihvaćeno":
                            ZavrsiNarudzbu();
                            break;
                    }
                }
                catch (FlurlHttpException ex)
                {
                    MessageBox.Show("Dogodila se greška nad dobavljanjem narudžbe sa servera..", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnKontakt_Click(object sender, EventArgs e)
        {
            frmKorisniciDetalji frm = new frmKorisniciDetalji(_kupacId);

            frm.Show();
        }
    }
}
