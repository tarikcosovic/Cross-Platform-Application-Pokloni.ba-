using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using Flurl;
using System.Windows.Forms;

namespace Pokloni.ba.WinUI
{
    public class APIService
    {
        private string _route = null;
        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(string attribute="", string queries="")
        {
            var filter = "";
            if (!string.IsNullOrWhiteSpace(queries))
                filter = "?$filter="+ attribute + " eq " + "'" + queries + "'";

            var result = await $"{Properties.Settings.Default.APIUrl}/{ _route}{filter}".GetJsonAsync<T>();
            //if(result.Equals(new List<T>())) PROVJERITI STA VRACA RESULT KAD VRATA NISTA, TJ. PRAZNU LISTU
               // MessageBox.Show("Korisnik pod tim imenom ne postoji.", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }

        public async Task<T> GetbyId<T>(int? id)
        {
            var result = await $"{Properties.Settings.Default.APIUrl}/{ _route}/{id}".GetJsonAsync<T>();

            return result;
        }

        public async Task<T> Inset<T>(object request)
        {
            var result = $"{Properties.Settings.Default.APIUrl}/{ _route}";

            return await result.PostJsonAsync(result).ReceiveJson<T>();
        }

        public async Task<T> Update<T>(object request, object id)
        {
            var result = $"{Properties.Settings.Default.APIUrl}/{ _route}/{id}";

            return await result.PutJsonAsync(request).ReceiveJson<T>();
        }
    }
}
