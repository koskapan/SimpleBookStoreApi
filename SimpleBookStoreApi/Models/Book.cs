using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBookStoreApi.Models
{
    public class Book
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("publicationYear")]
        public int PublicationYear { get; set; }
    }
}