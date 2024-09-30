using MongoDB.Driver;

namespace MongoDBWithCrud;

internal class Program
{
    public static async Task Main(string[] args)
    {
        var connectionString = "mongodb://localhost:27017"; // MongoDB bağlantı URI'si
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase("myDatabase");
        var collection = database.GetCollection<User>("users");

        // 1. İlk kullanıcıyı ekleyelim (First User)
        var firstUser = new User { Name = "First User",
            Email = "first.user@example.com" };
        await collection.InsertOneAsync(firstUser);
        Console.WriteLine("Kullanıcı eklendi: " + firstUser.Name);

        // 2. İkinci kullanıcıyı ekleyelim (Second User)
        var secondUser = new User { Name = "Second User",
            Email = "second.user@example.com" };
        await collection.InsertOneAsync(secondUser);
        Console.WriteLine("Kullanıcı eklendi: " + secondUser.Name);

        // 3. İlk kullanıcıyı (First User) sorgulama
        var user = await collection.Find(x => x.Name == "First User")
            .FirstOrDefaultAsync();
        Console.WriteLine("Kullanıcı bulundu: " + user.Email);

        // 4. İlk kullanıcıyı (First User) güncelleme
        var update = Builders<User>.Update
            .Set(u => u.Email, "first.user@newmail.com");
        await collection.UpdateOneAsync(u => u.Name == "First User", update);
        Console.WriteLine("Kullanıcı güncellendi.");

        // 5. İkinci kullanıcıyı (Second User) silme
        await collection.DeleteOneAsync(u => u.Name == "Second User");
        Console.WriteLine("Kullanıcı silindi: Second User");

        // Silme işleminden sonra First User hala koleksiyonda mevcut olacak.
    }
}