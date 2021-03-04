using Agili.Food.Dominio;
using Agili.Food.ViewModels.Cardapio;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agili.Food.AutoMapper
{
    public class ViewModelParaDominioProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<CardapioViewModel, Cardapio>();
        }

    }
}