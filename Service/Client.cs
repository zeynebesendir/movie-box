using MovieBox.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MovieBox.Service
{
    public class Client
    {

        private static Client instance;

        private static readonly HttpClient httpClient = new HttpClient();


        string API_KEY = ConfigurationManager.AppSettings["APIKey"].ToString();
        public MovieLayer MovieLayer;

        private Client()
        {
            MovieLayer = new MovieLayer();
        }

        public static Client Instance
        {
            get
            {
                if (instance == null)
                    instance = new Client();
                return instance;
            }
        }

        string API_URL = "https://api.themoviedb.org/3/";

        private string getEndOfUrl()
        {
            string url = "?api_key=" + API_KEY + "&language=en-US&page=1";
            return url;
        }

        private Response getFailureResponse(string msg)
        {
            Response response = new Response();
            response.Message = msg;

            return response;
        }

        public async Task<Response> GetContentAsync(string requestUrl, string keyword = "")
        {
            try
            {
                var url = API_URL + requestUrl + getEndOfUrl();

                if (!keyword.Equals(""))//search requested
                    url += keyword;

                var result = httpClient.GetStreamAsync(url);
                var x = await JsonSerializer.DeserializeAsync<Response>(await result);

                return x;
            }
            catch (Exception e)
            {
                return getFailureResponse(e.Message); ;
            }
        }

        public async Task<Content> GetContentDetailAsync(string requestUrl)
        {

            var result = httpClient.GetStreamAsync(API_URL + requestUrl + getEndOfUrl());
            var x = await JsonSerializer.DeserializeAsync<Content>(await result);

            return x;

        }


    }

}

