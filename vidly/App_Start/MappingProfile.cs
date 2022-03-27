using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vidly.Dtos;
using vidly.Models;

namespace vidly.App_Start
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {

            Mapper.CreateMap<Customers, CustomerDto>()
                .ForMember(c => c.MemberShipTypeDto, op => op.MapFrom(x => x.MemberShipTypes));
            Mapper.CreateMap<CustomerDto, Customers>()
                .ForMember(x=>x.Id,opt=>opt.Ignore());
            Mapper.CreateMap<MemberShipTypes, MemberShipTypeDto>();


            Mapper.CreateMap<Movies, MovieDto>()
               .ForMember(x => x.GenreDto, opt => opt.MapFrom(x => x.Genre));
            Mapper.CreateMap<MovieDto, Movies>()
                .ForMember(x => x.Id, opt => opt.Ignore());
            Mapper.CreateMap<Genre, GenreDto>();

        }
    }
}