using System;
using System.Threading.Tasks;
using Flurl.Http;

namespace Pokloni.ba.WinUI
{
    public class APIService
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static int UserId { get; set; }

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

            var result = await $"{Properties.Settings.Default.APIUrl}/{ _route}{filter}".WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }

        public async Task<T> GetAndSort<T>(string queries = "")
        {
            var filter = "";
            if (!string.IsNullOrWhiteSpace(queries))
                filter = "?$orderBy=" + queries;

            var result = await $"{Properties.Settings.Default.APIUrl}/{ _route}{filter}".WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }

        public async Task<T> GetbyId<T>(int? id)
        {
            var result = await $"{Properties.Settings.Default.APIUrl}/{ _route}/{id}".WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }

        public async Task<T> GetUserByUsername<T>(string id)
        {
            var result = await $"{Properties.Settings.Default.APIUrl}/{ _route}/GetByUsername/{id}".WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }

        public async Task<T> Insert<T>(object request)
        {
            var result = $"{Properties.Settings.Default.APIUrl}/{ _route}";

            return await result.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
        }

        public async Task<T> Update<T>(object request, object id)
        {
            var result = $"{Properties.Settings.Default.APIUrl}/{ _route}/{id}";

            return await result.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
        }

        public async Task Delete(int? id)
        {
            await $"{Properties.Settings.Default.APIUrl}/{ _route}/{id}".WithBasicAuth(Username, Password).DeleteAsync();
        }
    }
}
