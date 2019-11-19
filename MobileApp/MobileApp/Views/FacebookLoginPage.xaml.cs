using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacebookLoginPage : ContentPage
    {
        public FacebookLoginPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            FacebookLogin();
        }
        public void FacebookLogin()
        {
            var apiRequest = Constants.FacebookAuthorizeUrl + Constants.FacebookAndroidClientId + "&display=popup&response_type=token&redirect_uri=" + Constants.FacebookAccessTokenUrl;

            var webView = new WebView
            {
                Source = apiRequest,
                HeightRequest = 1
            };

            webView.Navigated += WebViewOnNavigated;

            Content = webView;
        }

        private async void WebViewOnNavigated(object sender, WebNavigatedEventArgs e)
        {
            var accessToken = ExtractAccessTokenFromUrl(e.Url);

            if (accessToken != "")
            {
                var profil = await GetFacebookProfileAsync(accessToken);
            }
        }
        private string ExtractAccessTokenFromUrl(string url)
        {
            if (url.Contains("access_token") && url.Contains("&expires_in="))
            {
                var at = url.Replace("https://www.facebook.com/connect/login_success.html#access_token=", "");

                var accessToken = at.Remove(at.IndexOf("&expires_in="));

                return accessToken;
            }

            return string.Empty;
        }

        public async Task<FacebookProfile> GetFacebookProfileAsync(string accessToken)
        {
            var requestUrl =
                 "https://graph.facebook.com/me/?fields=name,location,birthday,email,first_name,last_name,hometown&access_token="
                 + accessToken;

            var httpClient = new HttpClient();

            try
            {
                var userJson = await httpClient.GetStringAsync(requestUrl);

                var facebookProfile = JsonConvert.DeserializeObject<FacebookProfile>(userJson);

                var test = facebookProfile.Email;
                return facebookProfile;
            }
            catch(HttpRequestException ex)
            {

            }

            return null;
        }

        public class FacebookProfile
        {
            public string Name { get; set; }
            [JsonProperty("first_name")]
            public string FirstName { get; set; }
            [JsonProperty("last_name")]
            public string LastName { get; set; }
            [JsonProperty("email")]
            public string Email { get; set; }

        }
    }
}