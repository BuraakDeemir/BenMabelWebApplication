using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenMabelProject.Entity.Entities
{
    public class ArticleImage
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public string? Big_FileName { get; set; }
        public string? Big_FileType { get; set; }
        public string? Sml_FileName { get; set; }
        public string? Sml_FileType { get; set; }
        public Article Article { get; set; }
    }
}
