using System;
using System.Collections.Generic;
using System.Text;

namespace ResitalWE.Business.Constants
{
    public static class Messages
    {
        public static string Added = "Başarıyla Eklendi";
        public static string Deleted = "Başarıyla Silindi";
        public static string Updated = "Başarıyla Güncellendi";

        public static string NotAdded = "Hata Oluştu -- Ekleme Başarısız";
        public static string NotDeleted = "Hata Oluştu -- Silme Başarısız";
        public static string NotUpdated = "Hata Oluştu -- Güncelleme Başarısız";

        public static string UnExErr = "Beklenmeye Bir Hata Oluştu";
        public static string NullErr = "Geçersiz Değer Girişi- (NullReferenceExpected)";
        public static string EmpErr = "Boş Değer Gönderilemez - (EmptyReferenceError)";
    }
}
