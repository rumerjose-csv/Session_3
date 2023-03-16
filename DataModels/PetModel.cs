﻿using Newtonsoft.Json;

namespace Session_3.DataModels
{
    public class PetModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("category")]
        public Category Category { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("photoUrls")]
        public List<string> PhotoUrls { get; set; }
        [JsonProperty("tags")]
        public List<Tag> Tags { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
    }
    public partial class Category
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
    public partial class Tag
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
