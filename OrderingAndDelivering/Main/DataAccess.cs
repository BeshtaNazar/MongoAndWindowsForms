using Main.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Main{
    
    class DataAccess
    {
        private const string Connection = "mongodb://localhost:27017";
        private const string DatabaseName = "OrderAndDeliver";
        private const string FoodCollection = "food";
        private const string UsersCollection = "users";
        private const string OrdersCollection = "orders";
        private const string CouriersCollection = "couriers";

        private IMongoCollection<T> ConnectToDatabase<T>(in string collection)
        {            
            var db = Database.getInstance().GetDatabase(DatabaseName);
            return db.GetCollection<T>(collection);
        }

        public async Task<List<FoodModel>> GetAllFood()
        {
            var foodCollection = ConnectToDatabase<FoodModel>(FoodCollection);
            var results = await foodCollection.FindAsync(_=> true);
            return results.ToList();
        }

        public async Task<List<OrderModel>> GetAllOrders()
        {
            var ordersCollection = ConnectToDatabase<OrderModel>(OrdersCollection);
            var results = await ordersCollection.FindAsync(_ => true);
            return results.ToList();
        }

        public async Task<List<UserModel>> GetAllUsers()
        {
            var usersCollection = ConnectToDatabase<UserModel>(UsersCollection);
            var results = await usersCollection.FindAsync(_ => true);
            return results.ToList();
        }

        public async Task<List<CourierModel>> GetAllCouriers()
        {
            var couriersCollection = ConnectToDatabase<CourierModel>(CouriersCollection);
            var results = await couriersCollection.FindAsync(_ => true);
            return results.ToList();
        }

        public Task CreateCourier(CourierModel courier)
        {
            var couriersCollection = ConnectToDatabase<CourierModel>(CouriersCollection);
            return couriersCollection.InsertOneAsync(courier);
        }

        public Task CreateOrder(OrderModel order)
        {
            var ordersCollection = ConnectToDatabase<OrderModel>(OrdersCollection);
            return ordersCollection.InsertOneAsync(order);
        }

        public Task CreateUser(UserModel user)
        {
            var usersCollection = ConnectToDatabase<UserModel>(UsersCollection);
            return usersCollection.InsertOneAsync(user);
        }

        public Task CreateFood(FoodModel food)
        {
            var foodCollection = ConnectToDatabase<FoodModel>(FoodCollection);
            return foodCollection.InsertOneAsync(food);
        }

        public Task UpdateCourier(CourierModel courier)
        {
            var couriersCollection = ConnectToDatabase<CourierModel>(CouriersCollection);
            var filter = Builders<CourierModel>.Filter.Eq("Id", courier.Id);
            return couriersCollection.ReplaceOneAsync(filter, courier, new ReplaceOptions { IsUpsert = true });
        }

        public Task UpdateOrder(OrderModel order)
        {
            var ordersCollection = ConnectToDatabase<OrderModel>(OrdersCollection);
            var filter = Builders<OrderModel>.Filter.Eq("Id", order.Id);
            return ordersCollection.ReplaceOneAsync(filter, order, new ReplaceOptions { IsUpsert = true });
        }

        public Task UpdateFood(FoodModel food)
        {
            var foodCollection = ConnectToDatabase<FoodModel>(FoodCollection);
            var filter = Builders<FoodModel>.Filter.Eq("Id", food.Id);
            return foodCollection.ReplaceOneAsync(filter, food, new ReplaceOptions { IsUpsert = true});
        }

        public Task UpdateUser(UserModel user)
        {
            var usersCollection = ConnectToDatabase<UserModel>(UsersCollection);
            var filter = Builders<UserModel>.Filter.Eq("Id", user.Id);
            return usersCollection.ReplaceOneAsync(filter, user, new ReplaceOptions { IsUpsert = true });
        }

        public Task DeleteUser(string id)
        {
            var usersCollection = ConnectToDatabase<UserModel>(UsersCollection);
            return usersCollection.DeleteOneAsync(u => u.Id == id);
        }

        public Task DeleteCourier(string id)
        {
            var couriersCollection = ConnectToDatabase<CourierModel>(CouriersCollection);
            return couriersCollection.DeleteOneAsync(c => c.Id == id);
        }

        public Task DeleteOrder(string id)
        {
            var ordersCollection = ConnectToDatabase<OrderModel>(OrdersCollection);
            return ordersCollection.DeleteOneAsync(o => o.Id == id);
        }

        public Task DeleteFood (string id)
        {
            var foodCollection = ConnectToDatabase<FoodModel>(FoodCollection);
            return foodCollection.DeleteOneAsync(f => f.Id == id);
        }      
        
        public UserModel FindUserById(string id)
        {
            var usersCollection = ConnectToDatabase<UserModel>(UsersCollection);
            var result = usersCollection.Find(u => u.Id.Equals(id));
            return result.ToList()[0];
        }

        public OrderModel FindOrderById(string id)
        {
            var ordersCollection = ConnectToDatabase<OrderModel>(OrdersCollection);
            var result = ordersCollection.Find(o => o.Id.Equals(id));
            return result.ToList()[0];
        }
    }
}
