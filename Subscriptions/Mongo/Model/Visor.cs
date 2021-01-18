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
    public class Visor
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")]
        [Display(Name = "���")]
        public string Name { get; set; }

        [BsonElement("gender")]
        [Display(Name = "���")]
        public string Gender { get; set; }

        [BsonElement("age")]
        [Display(Name = "�������")]
        public int Age { get; set; }

        [BsonElement("subscriptions")]
        public string[] Subscriptions { get; set; }
    }
}