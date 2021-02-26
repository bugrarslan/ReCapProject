using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç eklendi";
        public static string CarNameInvalid = "Araç ismi en az 2 karakter olmalıdır";
        public static string CarNameEmpty = "Araç ismi boş bırakılamaz";
        public static string CarDeleted = "Araç silindi";
        public static string CarUpdated = "Araç güncellendi";
        public static string Maintenancetime = "Sistem bakımda";
        public static string CarsListed = "Araçlar listelendi";
        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandsListed = "Markalar listelendi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorsListed = "Renkler listelendi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string Userslisted = "Kullanıcılar listelendi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string RentAdded = "Kiralama kaydedildi";
        public static string RentDeleted = "Kiralama silindi";
        public static string Rentslisted = "Kiralamalar listelendi";
        public static string RentUpdated = "kiralama güncellendi";
        public static string CarIsNotEmpty = "Araç şuanda başka birisine kiralanmıştır";
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomersListed = "Müşteriler listelendi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string DailyPriceEmpty = "Araç fiyatı boş bırakılamaz";
        public static string DailyPriceInvalid = "Araç fiyatı 0'dan büyük olmalıdır";
        public static string CarNameAlreadyExists = "Bu isimde bir araç zaten var";
        public static string CarCountOfBrandError = "Bir markada en fazla 15 araç olabilir";
    }
}
