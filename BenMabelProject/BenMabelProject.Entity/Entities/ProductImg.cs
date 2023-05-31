namespace BenMabelProject.Entity.Entities
{
    public class ProductImg
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string? Img_1_FileName { get; set; }
        public string? Img_1_FileType { get; set; }
        public string? Img_1_Sml_FileName { get; set; }
        public string? Img_1_Sml_FileType { get; set; }
        public string? Img_2_FileName { get; set; }
        public string? Img_2_FileType { get; set; }
        public string? Img_2_Sml_FileName { get; set; }
        public string? Img_2_Sml_FileType { get; set; }
        public string? Img_3_FileName { get; set; }
        public string? Img_3_FileType { get; set; }
        public string? Img_3_Sml_FileName { get; set; }
        public string? Img_3_Sml_FileType { get; set; }
        public string? Img_4_FileName { get; set; }
        public string? Img_4_FileType { get; set; }
        public string? Img_4_Sml_FileName { get; set; }
        public string? Img_4_Sml_FileType { get; set; }
        public Product? Product { get; set; }
    }
}
