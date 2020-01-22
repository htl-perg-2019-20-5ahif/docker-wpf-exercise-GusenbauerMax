using System.Net.Http;

namespace Wpf_Client
{
    public class HttpClient
    {
        private static System.Net.Http.HttpClient httpClient;

        public static System.Net.Http.HttpClient GetHttpClient()
        {
            if (httpClient == null)
            {
                httpClient = new System.Net.Http.HttpClient();
            }

            return httpClient;
        }
    }
}
