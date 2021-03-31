using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Urun eklendi";
        public static string ProductNameInvalid="Urun ismi gecersiz";
        public static string MaintenanceTime="Sistem bakimda";
        public static string Productlisted="Urunler listelendi";
        public static string ProductUpdated = "Urun guncellendi";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 urun ola bilir";
        public static string ProductNameAlreadyExists="Bu isimde zaten baska  bir urun var";
        public static string CategoryLimitExceded="Kategori limiti asildigi ucun yeni urun eklenemiyor";
    }
}
