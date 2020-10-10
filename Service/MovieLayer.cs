using MovieBox.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static MovieBox.Common.Enums;

namespace MovieBox.Service
{
    public class MovieLayer
    {

        public event EventHandler MoviesLoaded;
        public event EventHandler StreamingLoaded;
        public event EventHandler TrendingLoaded;

        public event EventHandler InTheatreLoaded;
        public event EventHandler ContentDetailLoaded;
        public event EventHandler SearchResultLoaded;

  
        private Response response = new Response();
        private Content content = new Content();

        public List<Content> searchResult;

        public MovieLayer()
        {

        }

        public async Task getPopularMoviesAsync()
        {
            response = await Client.Instance.GetContentAsync("movie/popular");
            MoviesLoaded?.Invoke(response.Results, null);
        }

        public async Task getStreamingAsync()
        {
            response = await Client.Instance.GetContentAsync("movie/now_playing");
            StreamingLoaded?.Invoke(response.Results, null);
        }

        public async Task getInTheaterAsync()
        {
            response = await Client.Instance.GetContentAsync("movie/upcoming");
            InTheatreLoaded?.Invoke(response.Results, null);
        }

        public async Task GetTrending()
        {
            response = await Client.Instance.GetContentAsync("trending/all/day");
            TrendingLoaded?.Invoke(response.Results, null);
        }

        public async Task GetContentDetail(string id)
        {
            content = await Client.Instance.GetContentDetailAsync("movie/" + id);
            ContentDetailLoaded?.Invoke(content, null);
        }

        public async Task GetSearchResult(string keyword)
        {
            response = await Client.Instance.GetContentAsync("search/movie", "&query=" + keyword);
            searchResult = response.Results;
            SearchResultLoaded?.Invoke(response, null);
        }
    }

}
