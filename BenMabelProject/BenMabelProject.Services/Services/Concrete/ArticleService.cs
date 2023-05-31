using AutoMapper;
using BenMabelProject.Data.UnitOfWorks;
using BenMabelProject.Entity.DtoS;
using BenMabelProject.Entity.Entities;
using BenMabelProject.Entity.Enums;
using BenMabelProject.Services.Helpers.Images;
using BenMabelProject.Services.Services.Abstractions;

namespace BenMabelProject.Services.Services.Concrete
{
    public class ArticleService : IArticleService
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;
        private readonly IImageHelper imageHelper;
        public ArticleService(IMapper mapper,IUnitOfWork unitOfWork,IImageHelper imageHelper)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
            this.imageHelper = imageHelper;
        }

        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Admin Arayüzünde Seçilen Makalenin Aktif Olması İşlemini Gerçekleştirir.
        /// </summary>
        public async Task ActiveArticle(int id)
        {
            var article = await unitOfWork.GetRepository<Article>().GetByIdAsync(id);
            article.IsDeleted = false;
            await unitOfWork.GetRepository<Article>().UpdateAsync(article);
            await unitOfWork.SaveAsync();
        } // Admin İçin
        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Admin Arayüzünde Yeni Makale Ekleme İşlemini Gerçekleştirir.
        /// </summary>
        public async Task AddArticle(ArticleDto articleDto)
        {
            var article = new Article();
            article.Title = articleDto.Title;
            article.Content = articleDto.Content;
            article.SmlContent = articleDto.SmlContent;
            article.CreatedDate = DateTime.Now;
            article.IsDeleted = false;
            await unitOfWork.GetRepository<Article>().AddAsync(article);
            await unitOfWork.SaveAsync();
            var BigImg = await imageHelper.Upload((articleDto.Title + "_Big"), articleDto.BigImage, ImageType.Post);
            var SmlImg = await imageHelper.Upload((articleDto.Title + "_Sml"), articleDto.SmlImage, ImageType.Post);
            ArticleImage articleImage = new ArticleImage();
            articleImage.ArticleId = article.Id;
            articleImage.Big_FileName = BigImg.FullName;
            articleImage.Big_FileType = articleDto.BigImage.ContentType;
            articleImage.Sml_FileName = SmlImg.FullName;
            articleImage.Sml_FileType = articleDto.SmlImage.ContentType;
            await unitOfWork.GetRepository<ArticleImage>().AddAsync(articleImage);
            await unitOfWork.SaveAsync();
        } // Admin İçin
        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Admin Arayüzünde Aktif OLMAYAN Makaleleleri Listeleme İşlemini Gerçekleştirir.
        /// </summary>
        public async Task<List<ArticleDto>> GetInActiveArticle()
        {
            var articles = await unitOfWork.GetRepository<Article>().GetAllAsync(x => x.IsDeleted);
            var map = mapper.Map<List<ArticleDto>>(articles);
            return map;
        } // Admin İçin
        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Admin Arayüzünde Seçilen Makalenin InAktif olma İşlemini Gerçekleştirir.
        /// </summary>
        public async Task InActiveArticle(int id)
        {
            var article = await unitOfWork.GetRepository<Article>().GetByIdAsync(id);
            article.IsDeleted = true;
            await unitOfWork.GetRepository<Article>().UpdateAsync(article);
            await unitOfWork.SaveAsync();
        } // Admin İçin
        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Admin Arayüzünde Güncelleme Yapılmak İstenen Makalenin Bilgilerini Getirme (Update Bu Methodda Yapılmaz.) İşlemini Gerçekleştirir.
        /// </summary>
        public async Task<ArticleUpdateDto> GetUpdateArticle(int Id)
        {
            var article = await unitOfWork.GetRepository<Article>().GetAsync(x => x.Id == Id);
            article.Image = await unitOfWork.GetRepository<ArticleImage>().GetAsync(x => x.ArticleId == article.Id);
            var map = mapper.Map<ArticleUpdateDto>(article);
            return map;
        }  // Admin İçin
        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Admin Arayüzünde Seçilen Makalenin Güncellenmesi İşlemini Gerçekleştirir.
        /// </summary>
        public async Task UpdateArticle(ArticleUpdateDto articleDto)
        {
            var article = await unitOfWork.GetRepository<Article>().GetAsync(x => x.Id == articleDto.Id, x => x.Image);
            article.Title = articleDto.Title;
            article.Content = articleDto.Content;
            article.SmlContent = articleDto.SmlContent;
            await unitOfWork.GetRepository<Article>().UpdateAsync(article);
            var Img = await unitOfWork.GetRepository<ArticleImage>().GetAsync(x => x.ArticleId == article.Id);
            if (articleDto.BigImage != null)
            {
                imageHelper.Delete(Img.Big_FileName);
                var BigImgUpload = await imageHelper.Upload(articleDto.Title, articleDto.BigImage, ImageType.Post);
                Img.Big_FileName = BigImgUpload.FullName;
                Img.Big_FileType = articleDto.BigImage.ContentType;
            }
            if (articleDto.SmlImage != null)
            {
                imageHelper.Delete(Img.Sml_FileName);
                var SmlImgUpload = await imageHelper.Upload(articleDto.Title, articleDto.SmlImage, ImageType.Post);
                Img.Sml_FileName = SmlImgUpload.FullName;
                Img.Sml_FileType = articleDto.SmlImage.ContentType;
            }
            await unitOfWork.GetRepository<ArticleImage>().UpdateAsync(Img);
            await unitOfWork.SaveAsync();
        }  // Admin İçin
        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Kullanıcı ve Admin Arayüzünde Aktif Makaleleleri Listeleme İşlemini Gerçekleştirir.
        /// </summary>
        public async Task<List<ArticleDto>> GetActiveArticle()
        {
            var articles = await unitOfWork.GetRepository<Article>().GetAllAsync(x => !x.IsDeleted);
            var map = mapper.Map<List<ArticleDto>>(articles);
            return map;
        } // Kullanıcı İçin
        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Kullanıcı ve Admin Arayüzünde Tüm Makaleleleri Listeleme İşlemini Gerçekleştirir.
        /// </summary>
        public async Task<List<ArticleDto>> GetAllArticle()
        {
           var articles = await unitOfWork.GetRepository<Article>().GetAllAsync();
           var map = mapper.Map<List<ArticleDto>>(articles);
            return map;
        } // Kullanıcı İçin
        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Kullanıcı Arayüzünde Seöilen Makalenin Detaylı Bilgilerini Getirme İşlemini Gerçekleştirir.
        /// </summary>
        public async Task<ArticleDto> GetArticleDetail(int Id)
        {
            var article = await unitOfWork.GetRepository<Article>().GetAsync(x => x.Id == Id);
            article.Image = await unitOfWork.GetRepository<ArticleImage>().GetAsync(x => x.ArticleId == article.Id);
            var map = mapper.Map<ArticleDto>(article);
            return map;
        }  // Kullanıcı İçin
        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Kullanıcı Arayüzünde Tüm Makaleleri Listeleme İşlemini Gerçekleştirir.
        /// </summary>
        public async Task<List<ArticleDto>> AllArticleWidtImage()
        {
            var articles = await unitOfWork.GetRepository<Article>().GetAllAsync(x=> !x.IsDeleted,x=> x.Image);
            var map = mapper.Map<List<ArticleDto>>(articles);
            return map;
        } // Kullanıcı İçin
    }
}
