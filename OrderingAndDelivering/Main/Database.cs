using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Database
    {
        private static MongoClient instance;
        private const string Connection  = "mongodb://localhost:27017";

        public static MongoClient getInstance()
        {
            if (instance == null)
            {
                instance = new MongoClient(Connection);
            }
            return instance;
        }

    }
}
