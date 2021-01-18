using Microsoft.Extensions.Localization.Internal;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Subscriptions.Mongo.Model
{
    public class Team
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")]
        [Display(Name = "Название")]
        public string Name { get; set; }

        [BsonElement("description")]
        [Display(Name = "описание")]
        public string Description { get; set; }

        [BsonElement("subscriptions")]
        public string[] Subscriptions { get; set; }
    }
}