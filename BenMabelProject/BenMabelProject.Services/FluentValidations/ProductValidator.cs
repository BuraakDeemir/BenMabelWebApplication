using BenMabelProject.Entity.Entities;
using FluentValidation;

namespace BenMabelProject.Services.FluentValidations
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {

            RuleFor(x => x.ProductName)
                .NotEmpty()
                .NotNull()
                .MinimumLength(10)
                .WithName("Ürün İsmi");
            RuleFor(x => x.Stock)
                .NotEmpty()
                .NotNull()
                .WithName("Stok");

            //--------------------------------------------//

            RuleFor(x => x.ProductPrice.Price)
                .NotEmpty()
                .NotNull()
                .WithName("Ürün Fiyatı");
            RuleFor(x => x.ProductPrice.KDV)
                .NotEmpty()
                .NotNull()
                .WithName("KDV");

            ////--------------------------------------------//

            RuleFor(x => x.ProductDetail.detail)
                .NotEmpty()
                .NotNull()
                .MinimumLength(10)
                .WithName("Ürün Özellikleri");


            ////--------------------------------------------//

            //RuleFor(x => x.)
            //    .NotEmpty()
            //    .NotNull()
            //    .MinimumLength(10)
            //    .WithName("Resim");
            //RuleFor(x => x.ProductImg.Img_1_FileName)
            //    .NotEmpty()
            //    .NotNull()
            //    .MinimumLength(10)
            //    .WithName("Resim");
            //RuleFor(x => x.ProductImg.Img_1_FileName)
            //    .NotEmpty()
            //    .NotNull()
            //    .MinimumLength(10)
            //    .WithName("Resim");
            //RuleFor(x => x.ProductImg.Img_1_FileName)
            //    .NotEmpty()
            //    .NotNull()
            //    .MinimumLength(10)
            //    .WithName("Resim");
        }
    }
    //public class ProducPricetValidator : AbstractValidator<ProductPrice>
    //{
    //    public ProducPricetValidator()
    //    {
    //        RuleFor(x => x.Price.ToString())
    //            .NotEmpty()
    //            .NotNull()
    //            .MinimumLength(10)
    //            .WithName("Ürün Fiyatı");
    //        RuleFor(x => x.KDV.ToString())
    //            .NotEmpty()
    //            .NotNull()
    //            .MinimumLength(10)
    //            .WithName("KDV");
    //    }
    //}


    //public class CategoryValidator : AbstractValidator<Category>
    //{
    //    public CategoryValidator()
    //    {
    //    RuleFor(x => x.CategoryName)
    //        .NotEmpty()
    //        .NotNull()
    //        .MinimumLength(10)
    //        .WithName("Kategori");
    //    }
    //}
    //public class ProductDetailValidator : AbstractValidator<ProductDetail>
    //{   
    //    public ProductDetailValidator()
    //    {
    //    RuleFor(x => x.detail)
    //        .NotEmpty()
    //        .NotNull()
    //        .MinimumLength(10)
    //        .WithName("Ürün Özellikleri");
    //    }
    //}
    //public class ProductImgValidator : AbstractValidator<ProductImg>
    //{
    //    public ProductImgValidator()
    //    {
    //    RuleFor(x => x.Img_1)
    //            .NotEmpty()
    //            .NotNull()
    //            .MinimumLength(10)
    //            .WithName("Resim");
    //    RuleFor(x => x.Img_2)
    //        .NotEmpty()
    //        .NotNull()
    //        .MinimumLength(10)
    //        .WithName("Resim");
    //    RuleFor(x => x.Img_3)
    //        .NotEmpty()
    //        .NotNull()
    //        .MinimumLength(10)
    //        .WithName("Resim");
    //    RuleFor(x => x.Img_4)
    //        .NotEmpty()
    //        .NotNull()
    //        .MinimumLength(10)
    //        .WithName("Resim");
    //    }
    //}



}