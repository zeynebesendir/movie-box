using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Text.Json.Serialization;

namespace MovieBox.Model
{
    public class Response 
    {

        [JsonPropertyName("page")]
        public long Page { get; set; }

        [JsonPropertyName("total_results")]
        public long TotalResults { get; set; }

        [JsonPropertyName("total_pages")]
        public long TotalPages { get; set; }

        [JsonPropertyName("results")]
        public List<Content> Results { get; set; }

        [JsonPropertyName("status_message")]
        public string Message { get; set; }

        [JsonPropertyName("status_code")]
        public string Code { get; set; }
    }




}
