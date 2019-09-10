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

        public async Task<T> Get<T>(string queries)
        {
            string filter ="";

            if (!string.IsNullOrWhiteSpace(queries))
                filter = "?$filter=username eq " + "'" + queries + "'";

           // MessageBox.Show("Korisnik pod tim imenom ne postoji.", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            var result = await $"{Properties.Settings.Default.APIUrl}/{ _route}{filter}".GetJsonAsync<T>();

            return result;
        }
    }
}
