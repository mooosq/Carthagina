using AutoMapper;
using Carthagina.Core.Models;
using Carthagina.Database.DbModels;

namespace Carthagina.Core.MapperProfiles
{
    internal class TransactionMapperProfile : Profile
    {
        public TransactionMapperProfile()
        {
            CreateMap<Transaction, TransactionModel>()
                .ForMember(dest => dest.OrderDate,
                    m => m.MapFrom(src => new Date
                    {
                        Day = src.OrderDateTime.Day,
                        Month = src.OrderDateTime.Month,
                        Year = src.OrderDateTime.Year
                    }));
        }
    }
}