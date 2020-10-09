using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MovieBox.Model
{
    public class Content
    {

        [JsonPropertyName("adult")]
        public bool Adult { get; set; }

        [JsonPropertyName("backdrop_path")]
        public string BackdropPath { get; set; }

        public string BackdropSource
        {
            get
            {
                return "https://image.tmdb.org/t/p/w500" + BackdropPath;
            }
        }

        [JsonPropertyName("belongs_to_collection")]
        public object BelongsToCollection { get; set; }

        [JsonPropertyName("budget")]
        public long Budget { get; set; }

        [JsonPropertyName("genres")]
        public List<Genre> Genres { get; set; }

        public string GenreStr
        {
            get
            {
                string str = "";


                foreach (Genre g in Genres)
                {
                    str += g.Name;

                    if (Genres.Last() != g)
                        str += ", ";
                }


                return str;
            }
        }



        [JsonPropertyName("homepage")]
        public Uri Homepage { get; set; }

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("imdb_id")]
        public string ImdbId { get; set; }

        [JsonPropertyName("original_language")]
        public string OriginalLanguage { get; set; }

        [JsonPropertyName("original_title")]
        public string OriginalTitle { get; set; }

        [JsonPropertyName("overview")]
        public string Overview { get; set; }

        [JsonPropertyName("popularity")]
        public double Popularity { get; set; }

        [JsonPropertyName("poster_path")]
        public string PosterPath { get; set; }

        public string PosterSource
        {
            get
            {
                if (String.IsNullOrEmpty(PosterPath))
                {
                    return "https://via.placeholder.com/160x225?text=no+image";
                }
                return "https://image.tmdb.org/t/p/w500" + PosterPath;                            //w220_and_h330_face" + PosterPath;
            }
        }

        [JsonPropertyName("production_companies")]
        public List<ProductionCompany> ProductionCompanies { get; set; }

        [JsonPropertyName("production_countries")]
        public List<ProductionCountry> ProductionCountries { get; set; }

        [JsonPropertyName("release_date")]
        public DateTimeOffset ReleaseDate { get; set; }

        [JsonPropertyName("first_air_date")]
        public DateTimeOffset airDate { get; set; }

        public string Date
        {
            get
            {
                if (ReleaseDate.Year == 0001)
                    return airDate.ToString("D");

                return ReleaseDate.ToString("D");
            }
        }

        public string Year
        {
            get { return "(" + ReleaseDate.Year.ToString() + ")"; }
        }

        [JsonPropertyName("revenue")]
        public long Revenue { get; set; }

        [JsonPropertyName("runtime")]
        public long Runtime { get; set; }

        [JsonPropertyName("spoken_languages")]
        public List<SpokenLanguage> SpokenLanguages { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("tagline")]
        public string Tagline { get; set; }

        [JsonPropertyName("title")]
        public string title { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }

        public string Title
        {
            get
            {
                if (title == null)
                    return name;

                return title;
            }
            set { }

        }

        [JsonPropertyName("video")]
        public bool Video { get; set; }

        [JsonPropertyName("vote_average")]
        public double VoteAverage { get; set; }

        public double VotePercentage
        {
            get
            {
                double percent = VoteAverage * 10;

                if (percent > 100)
                    return 100;

                return percent;
            }
            set { }

        }

        [JsonPropertyName("vote_count")]
        public long VoteCount { get; set; }
    }

    public partial class Genre
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }


    public partial class ProductionCompany
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("logo_path")]
        public object LogoPath { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("origin_country")]
        public string OriginCountry { get; set; }
    }

    public partial class ProductionCountry
    {
        [JsonPropertyName("iso_3166_1")]
        public string Iso3166_1 { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public partial class SpokenLanguage
    {
        [JsonPropertyName("iso_639_1")]
        public string Iso639_1 { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }


}
