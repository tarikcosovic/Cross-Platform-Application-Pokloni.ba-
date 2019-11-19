using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp
{
    public static class Constants
    {
        // Facebook OAuth
        // For Facebook login, configure at https://developers.facebook.com
        public static string FacebookAndroidClientId = "2811733528845732";

        // These values do not need changing
        public static string FacebookScope = "email";
        public static string FacebookAuthorizeUrl = "https://www.facebook.com/dialog/oauth?client_id=";
        public static string FacebookAccessTokenUrl = "https://www.facebook.com/connect/login_success.html";
        public static string FacebookUserInfoUrl = "https://graph.facebook.com/me?fields=email&access_token={accessToken}";
    }
}
