using Agili.Food.AutoMapper;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agili.Food.App_Start
{
    public class AutoMapperConfig
    {
        public static void Configurar()
        {
            Mapper.AddProfile<DominioParaViewModelProfile>();
            Mapper.AddProfile<ViewModelParaDominioProfile>();
        }
    }
}