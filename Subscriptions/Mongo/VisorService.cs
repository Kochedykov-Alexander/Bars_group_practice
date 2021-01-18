using Judges.Mongo.Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace  Subscriptions.Mongo
{
    public class VisorService
    {
        private IMongoCollection<Subscription> _subscriptions;

        public VisorService()
        {
            string connection = "mongodb://localhost:27017/visorsDataBase";

            MongoUrlBuilder builder = new MongoUrlBuilder(connection);

            MongoClient client = new MongoClient(connection);

            IMongoDatabase db = client.GetDatabase(builder.DatabaseName);

            _subscriptions = db.GetCollection<Subscription>("subscriptions");
        }

        public async Task<Subscription> Get(string id)
        {
            return await _subscriptions.Find(new BsonDocument("_id", new ObjectId(id))).FirstOrDefaultAsync();
        }

        public async Task<string> Create(Subscription subscriptionModel)
        {
            await _subscriptions.InsertOneAsync(subscriptionModel);

            return subscriptionModel.Id;
        }

        public async Task Update(Subscription subscriptionModel)
        {
            await _subscriptions.ReplaceOneAsync(new BsonDocument("_id", new ObjectId(subscriptionModel.Id)), subscriptionModel);
        }

        public async Task Delete(string id)
        {
            await _subscriptions.DeleteOneAsync(new BsonDocument("_id", new ObjectId(id)));
        }
    }
}
