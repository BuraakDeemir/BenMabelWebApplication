using AutoMapper;
using BenMabelProject.Entity.DtoS.Basket;
using BenMabelProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenMabelProject.Services.AutoMapper.Basket
{
    public class BasketProfile : Profile
    {
        public BasketProfile()
        {
            CreateMap<BasketDetail, BasketDto>()
                .ForMember(x => x.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(x => x.BasketId, opt => opt.MapFrom(x => x.BasketId))
                .ForMember(x => x.ProductName, opt => opt.MapFrom(x => x.ProductName))
                .ForMember(x => x.ProductId, opt => opt.MapFrom(x => x.ProductId))
                .ForMember(x => x.Piece, opt => opt.MapFrom(x => x.Piece))
                .ForMember(x => x.ProductPrice, opt => opt.MapFrom(x => x.Price))
                .ForMember(x => x.KDV, opt => opt.MapFrom(x => x.KDV))
                .ForMember(x => x.TotalPrice, opt => opt.MapFrom(x => x.TotalPrice));
        }
    }
}
