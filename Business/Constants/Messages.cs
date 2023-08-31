using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz";
        public static string MaintenanceTime="Sistem Bakımda";
        public static string ProductsListed="Ürünler Listelendi ";
        public static string CategoryLengthMuch = "1 kategoride 10dan fazla ürün olamaz";
        public static string ProductNameAlreadyExists = "Aynı isimde 2 tane ürün olamaz";
        public static string CategoryLimitExceded="category limiti aşıldı";
        public static string AuthorizationDenied = "yetkiniz yok";
    }
}
