using Agili.Food.Dominio;
using Agili.Food.ViewModels.Cardapio;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agili.Food.AutoMapper
{
    public class DominioParaViewModelProfile: Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Cardapio, CardapioIndexViewModel>()
                .ForMember(p => p.NomePedido, opt => {
                    opt.MapFrom(src =>

                        string.Format("{0} ({1})", src.NomePedido, src.NomeFornecedor.ToString())
                    );
                });
            Mapper.CreateMap<Cardapio, CardapioViewModel>();
        }
    }
}