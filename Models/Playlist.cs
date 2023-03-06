﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace MongoEx.Models
{
    public class Playlist
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string username { get; set; } = null!;
        [BsonElement("items")]
        [JsonPropertyName("items")]
        public List<string> moviesIds { get; set; } = null!;
    }
}