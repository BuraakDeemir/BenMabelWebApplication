using BenMabelProject.Entity.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenMabelProject.Entity.DtoS
{
    public class ArticleDto
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? SmlContent { get; set; }
        public string? Content { get; set; }
        public bool IsDeleted { get; set; }
        public IFormFile? BigImage { get; set; }
        public IFormFile? SmlImage { get; set; }
        public DateTime CreatedDate { get; set; }
        public ArticleImage Image { get; set; }
    }
}
