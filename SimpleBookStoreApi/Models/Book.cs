using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SimpleBookStoreApi.Models
{
    [Table("books")]
    public class Book
    {
        [JsonProperty("id")]
        [Column("id"), Key]
        public Guid ID { get; set; }

        [JsonProperty("title")]
        [Column("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        [Column("description")]
        public string Description { get; set; }

        [JsonProperty("author")]
        [Column("author")]
        public string Author { get; set; }

        [JsonProperty("publicationYear")]
        [Column("publication_year")]
        public int PublicationYear { get; set; }

        [JsonProperty("imageUrl")]
        [Column("image_url")]
        public String ImageUrl { get; set; }
    }
}