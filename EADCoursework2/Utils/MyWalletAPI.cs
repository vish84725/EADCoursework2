using EADCoursework2.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EADCoursework2.Utils
{
    public static class MyWalletAPI<T> where T : class
    {
        //static HttpClient client = new HttpClient();

        //public MyWalletAPI()
        //{
        //    // Update port # in the following line.
        //    client.BaseAddress = new Uri("https://localhost:44314/");
        //    client.DefaultRequestHeaders.Accept.Clear();
        //    client.DefaultRequestHeaders.Accept.Add(
        //        new MediaTypeWithQualityHeaderValue("application/json"));
        //}

        public static async Task<T> Get(string url)
        {
            T result = null;
            using (var httpClient = new HttpClient())
            {
                var response = httpClient.GetAsync(new Uri(url)).Result;

                response.EnsureSuccessStatusCode();
                await response.Content.ReadAsStringAsync().ContinueWith((Task<string> x) =>
                {
                    if (x.IsFaulted)
                        throw x.Exception;

                    result = JsonConvert.DeserializeObject<T>(x.Result);
                });
            }
            return result;
        }

        public static async Task<T> PostRequest(string apiUrl, T postObject)
        {
            T result = null;

            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(apiUrl, postObject, new JsonMediaTypeFormatter()).ConfigureAwait(false);

                response.EnsureSuccessStatusCode();

                await response.Content.ReadAsStringAsync().ContinueWith((Task<string> x) =>
                {
                    if (x.IsFaulted)
                        throw x.Exception;

                    result = JsonConvert.DeserializeObject<T>(x.Result);

                });
            }

            return result;
        }

        public static async Task PutRequest(string apiUrl, T putObject)
        {
            using (var client = new HttpClient())
            {
                var response = await client.PutAsync(apiUrl, putObject, new JsonMediaTypeFormatter()).ConfigureAwait(false);

                response.EnsureSuccessStatusCode();
            }
        }

        //public static async Task<List<User>> GetUsers()
        //{
        //    List<User> users = null;
        //    HttpResponseMessage response = await client.GetAsync("api/user");
        //    if (response.IsSuccessStatusCode)
        //    {
        //        users = await response.Content.ReadAsAsync<List<User>>();
        //    }
        //    return users;
        //}
    }
}
