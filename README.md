## MongoDB: Esneklik ve Performansın Gücü - Adım Adım Uygulama Örneği

Bu proje, MongoDB'nin temel özelliklerini ve C# ile birlikte kullanımını gösteren basit bir CRUD (Create, Read, Update, Delete) uygulamasını içermektedir.
MongoDB'nin NoSQL yapısının esnekliği ve yatay ölçeklenebilirliği ile C# dilinin gücünü bir araya getirerek, yazılım projelerinde veri yönetimi ve performans
avantajlarını keşfetmek isteyen geliştiriciler için hazırlanmıştır.

### Proje İçeriği
Bu proje kapsamında gerçekleştirilen başlıca işlemler şunlardır:
1. MongoDB veritabanı ile bağlantı kurma
2. Kullanıcı verileri ekleme (Create)
3. Kullanıcı verilerini sorgulama (Read)
4. Kullanıcı verilerini güncelleme (Update)
5. Kullanıcı verilerini silme (Delete)

### Kullanılan Teknolojiler
- **C#**: Uygulama mantığı ve MongoDB ile etkileşim için kullanıldı.
- **MongoDB**: NoSQL veritabanı, kullanıcı bilgilerini depolamak için kullanıldı.
- **MongoDB.Driver**: C# ile MongoDB arasında bağlantı kurmak ve veritabanı işlemlerini gerçekleştirmek için kullanıldı.

### Nasıl Kullanılır?
1. **Proje Kopyalama**:
   - Projeyi kendi bilgisayarınıza klonlayın veya indirin.
   
     ```bash
     git clone https://github.com/mehmetalbyrak/MongoDBWithCrudOperations
     ```

2. **MongoDB Kurulumu**:
   - Yerel ortamınızda MongoDB'yi kurun ve çalıştırın. MongoDB'nin yerel bağlantı URI'si proje içinde kullanılmıştır.

3. **Gerekli Paketlerin Yüklenmesi**:
   - MongoDB ile etkileşim kurabilmek için **MongoDB.Driver** paketini yükleyin:
     
     ```bash
     dotnet add package MongoDB.Driver
     ```

4. **Uygulamanın Çalıştırılması**:
   - Projeyi çalıştırmak için .NET CLI veya Visual Studio kullanabilirsiniz:
     
     ```bash
     dotnet run
     ```

5. **MongoDB Compass ile Kontrol**:
   - MongoDB veritabanına eklenen, güncellenen veya silinen kullanıcı verilerini kontrol etmek için **MongoDB Compass** kullanabilirsiniz.


