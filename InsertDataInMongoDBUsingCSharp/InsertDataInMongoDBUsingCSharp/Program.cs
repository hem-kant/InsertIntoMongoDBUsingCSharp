using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace InsertDataInMongoDBUsingCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Conntection String 
            var conString = "mongodb://localhost:27017";

            /// creating MongoClient
            var client = new MongoClient(conString);

            ///Get the database
            var DB = client.GetDatabase("MyFirstMongoDatabase");

            ///Get the collcetion from the DB in which you want to insert the data
            /// 
            var collection = DB.GetCollection<BsonDocument>("Student");

            /// initializes BSONDocument with the data you want to insert 
            var documnt = new BsonDocument
            {
                {"FName","Demo Data"},
                {"Subject","Computers"},
                {"Marks","50"} 
            };

            /// use InsertOne menthod to insert single record 
            collection.InsertOne(documnt);

            //var documnt1 = new BsonDocument
            //{
            //    {"FName","Demo1 Data"},
            //    {"Subject","Computers"},
            //    {"Marks","100"}
            //};

            /// use InsertMany menthod to bulk insert the data.
            //collection.InsertMany(new[] { documnt, documnt1 });
        }
    }
}
