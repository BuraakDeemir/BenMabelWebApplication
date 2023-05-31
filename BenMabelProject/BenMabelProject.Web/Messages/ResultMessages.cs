namespace BenMabelProject.Web.Messages
{
    public static class ResultMessages
    {
        public static class Product
        {
            public static string Add(string ProductName)
            {
                return $"{ProductName} isimli Ürün başarılı bir şekilde eklendi.";
            }

            public static string Update(string ProductName)
            {
                return $"{ProductName} isimli Ürün başarılı bir şekilde Güncellendi.";
            }

            public static string Delete(string ProductName)
            {
                return $"{ProductName} isimli Ürün başarılı bir şekilde Satıştan Kaldırıldı.";
            }

            public static string UndoDelete(string ProductName)
            {
                return $"{ProductName} isimli Ürün başarılı bir şekilde Tekrar Satışa Alındı.";
            }
        }
    }
}
