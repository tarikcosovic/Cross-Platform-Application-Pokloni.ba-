using Flurl.Http;
using MobileApp.Views.Popups;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileApp
{
    public class APIService
    {
        public static string Username { get; set; }
        public static string Password { get; set; }

        const string apiUrl = "https://pokloniwebapi.azurewebsites.net/api";


        private string _route = null;
        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(string attribute = "", string queries = "")
        {
            var filter = "";
            if (!string.IsNullOrWhiteSpace(queries))
                filter = "?$filter=" + attribute + " eq " + "'" + queries + "'";

            try
            {
                var result = await $"{apiUrl}/{ _route}{filter}".WithBasicAuth(Username, Password).GetJsonAsync<T>();

                return result;
            }
            catch(FlurlHttpException ex)
            {
                if(ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    await PopupNavigation.Instance.PushAsync(new NotAuthorisedPopupView("Invalid Username or Password!"));
                }
                else
                    await PopupNavigation.Instance.PushAsync(new Error404PopupView());
                throw;
            }
        }

        public async Task<T> GetAndSort<T>(string queries = "")
        {
            var filter = "";
            if (!string.IsNullOrWhiteSpace(queries))
                filter = "?$orderBy=" + queries;

            var result = await $"{apiUrl}/{ _route}{filter}".WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }

        public async Task<T> GetbyId<T>(int? id)
        {
            var result = await $"{apiUrl}/{ _route}/{id}".WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }

        public async Task<T> GetUserByUsername<T>(string id)
        {
            var result = await $"{apiUrl}/{ _route}/GetByUsername/{id}".WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }

        public async Task<int> GetProizvodOcjena(int? id)
        {
            var result = await $"{apiUrl}/{ _route}/GetProizvodOcjena/{id}".WithBasicAuth(Username, Password).GetJsonAsync<int>();

            return result;
        }

        public async Task<T> Insert<T>(object request)
        {
            var result = $"{apiUrl}/{ _route}";

            return await result.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
        }

        public async Task<T> Update<T>(object request, object id)
        {
            var result = $"{apiUrl}/{ _route}/{id}";

            return await result.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
        }

        public async Task Delete(int? id)
        {
            await $"{apiUrl}/{ _route}/{id}".WithBasicAuth(Username, Password).DeleteAsync();
        }
    }
}
